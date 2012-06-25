using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;

namespace ProgramManager.BusinessClasses
{
    public class Station
    {
        private string _neverendedProgramsStoragePath = string.Empty;

        public string Name { get; private set; }
        public Image Logo { get; private set; }
        public DirectoryInfo RootFolder { get; private set; }

        public List<Day> Days { get; private set; }
        public List<Program> RecurentedPrograms { get; private set; }

        public Station(DirectoryInfo rootFolder)
        {
            this.RootFolder = rootFolder;
            this.Name = this.RootFolder.Name;

            string logoPath = Path.Combine(this.RootFolder.FullName, this.RootFolder.Name + ".png");
            if (File.Exists(logoPath))
                this.Logo = Image.FromFile(logoPath);
            else
                this.Logo = Properties.Resources.Logo;

            this.Days = new List<Day>();

            _neverendedProgramsStoragePath = Path.Combine(this.RootFolder.FullName, "NeverendedPrograms.xml");
            this.RecurentedPrograms = new List<Program>();
            LoadNeverendedPrograms();
        }

        public Day GetDay(DateTime date)
        {
            Day day = this.Days.Where(x => x.Date.Year.Equals(date.Date.Year) && x.Date.Month.Equals(date.Date.Month) && x.Date.Day.Equals(date.Date.Day)).FirstOrDefault();
            if (day == null && date != DateTime.MinValue)
            {
                day = new Day(this, date);
                this.Days.Add(day);
                this.Days.Sort((x, y) => x.Date.CompareTo(y.Date));
            }
            return day;
        }

        public void AddProgram(Program program)
        {
            this.RecurentedPrograms.Add(program);
            SaveNeverendedPrograms();

            BusinessClasses.Day lastCreatedDay = this.Days.LastOrDefault();
            DateTime[] programSpotDates = program.GetUsedTimes(lastCreatedDay.Date.AddDays(1));
            foreach (Day day in this.Days)
            {
                foreach (DateTime time in programSpotDates.Where(x => x >= day.StartTime && x <= day.EndTime))
                {
                    Spot spot = new Spot(day, time);
                    spot.Program = program.Name;
                    spot.Type = program.Type;
                    spot.FCC = program.FCC;
                    spot.MovieTitle = program.MovieTitle;
                    spot.Distributor = program.Distributor;
                    spot.ContractLength = program.ContractLength;
                    spot.CustomNote = program.CustomNote;
                    day.AddSpot(spot);
                }
            }
        }

        public void SaveData()
        {
            foreach (Day day in this.Days.Where(x => x.DataNotSaved))
                day.Save();
        }

        public void LoadNeverendedPrograms()
        {
            this.RecurentedPrograms.Clear();
            if (File.Exists(_neverendedProgramsStoragePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(_neverendedProgramsStoragePath);

                XmlNode node = document.SelectSingleNode(@"/Programs");
                if (node != null)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name.Equals("Program"))
                        {
                            Program progarm = new Program();
                            progarm.Deserialize(childNode);
                            this.RecurentedPrograms.Add(progarm);
                        }
                    }
                }
            }
        }

        public void SaveNeverendedPrograms()
        {
            if (this.RecurentedPrograms.Where(x => x.NoEndRecurence).Count() > 0)
            {
                StringBuilder xml = new StringBuilder();
                xml.AppendLine(@"<Programs>");
                foreach (Program program in this.RecurentedPrograms.Where(x => x.NoEndRecurence))
                    xml.AppendLine(@"<Program>" + program.Serialize() + @"</Program>");
                xml.AppendLine(@"</Programs>");

                using (StreamWriter sw = new StreamWriter(_neverendedProgramsStoragePath, false))
                {
                    sw.Write(xml.ToString());
                    sw.Flush();
                    sw.Close();
                }
            }
        }
    }
}
