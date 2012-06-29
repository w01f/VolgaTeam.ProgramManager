using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace ProgramManager.CoreObjects
{
    [DataContract]
    public class Station
    {
        [DataMember]
        private string _programsStoragePath = string.Empty;

        [DataMember]
        public string Name { get; private set; }
        [DataMember]
        public Image Logo { get; private set; }
        [DataMember]
        public DirectoryInfo RootFolder { get; private set; }

        [DataMember]
        public List<Day> Days { get; private set; }
        [DataMember]
        public List<Program> Programs { get; private set; }

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

            _programsStoragePath = Path.Combine(this.RootFolder.FullName, "Programs.xml");
            this.Programs = new List<Program>();
            LoadPrograms();
            LoadDataFromOldFormat();
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

        public void SaveData()
        {
            foreach (Day day in this.Days.Where(x => x.DataNotSaved))
                day.Save();
        }

        public void LoadPrograms()
        {
            this.Programs.Clear();
            if (File.Exists(_programsStoragePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(_programsStoragePath);

                XmlNode node = document.SelectSingleNode(@"/Programs");
                if (node != null)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name.Equals("Program"))
                        {
                            Program progarm = new Program();
                            progarm.Deserialize(childNode);
                            this.Programs.Add(progarm);
                        }
                    }
                }
            }
        }

        public void SavePrograms()
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine(@"<Programs>");
            foreach (Program program in this.Programs)
                xml.AppendLine(@"<Program>" + program.Serialize() + @"</Program>");
            xml.AppendLine(@"</Programs>");

            using (StreamWriter sw = new StreamWriter(_programsStoragePath, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
                sw.Close();
            }
        }

        public void AddProgram(Program program, int index = 0)
        {
            if (index != 0)
                this.Programs.Insert(index, program);
            else
                this.Programs.Add(program);
            SavePrograms();

            ApplyProgram(program);
        }

        public void ApplyProgram(Program program)
        {
            Day lastCreatedDay = this.Days.LastOrDefault();
            DateTime[] programSpotDates = program.GetUsedTimes(lastCreatedDay.Date.AddDays(1));
            foreach (Day day in this.Days)
            {
                foreach (DateTime time in programSpotDates.Where(x => x >= day.StartTime && x <= day.EndTime))
                {
                    Spot spot = new Spot(day, time);
                    spot.ProgramLink = program.Id;
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

        public void DeleteProgram(Program program, bool clearSpots)
        {
            if (clearSpots)
            {
                foreach (Day day in this.Days)
                {
                    foreach (Spot spot in day.Spots.Where(x => x.ProgramLink.Equals(program.Id)))
                        spot.Clear();
                    day.Save();
                }
            }
            this.Programs.Remove(program);
            SavePrograms();
        }

        private void LoadDataFromOldFormat()
        {
            DateTime tempDate;
            int tempInt;

            string filePath = Path.Combine(this.RootFolder.FullName, "olddata.xml");
            Day fakeDay = new Day(this, DateTime.Now);
            List<Spot> spots = new List<Spot>();

            if (File.Exists(filePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(filePath);

                XmlNode node = document.SelectSingleNode(@"/RECORDS");
                if (node != null)
                {
                    foreach (XmlNode recordNode in node.ChildNodes)
                    {
                        Spot spot = new Spot(fakeDay);
                        foreach (XmlNode rowNode in recordNode.ChildNodes)
                        {
                            foreach (XmlAttribute attribute in rowNode.Attributes)
                            {
                                switch (attribute.Name)
                                {
                                    case "PROG_DATE":
                                        if (DateTime.TryParseExact(attribute.Value, "yyyyMMdd", new System.Globalization.CultureInfo("en-us"), System.Globalization.DateTimeStyles.None, out tempDate))
                                            spot.Time = tempDate;
                                        break;
                                    case "PROG_SO":
                                        if (int.TryParse(attribute.Value, out tempInt))
                                            spot.Time = new DateTime(spot.Time.Year, spot.Time.Month, spot.Time.Day, 5, 0, 0).AddMinutes(30 * (tempInt - 1));
                                        break;
                                    case "PROG_PROG":
                                        spot.Program = attribute.Value;
                                        break;
                                    case "PROG_LSN":
                                        spot.Type = attribute.Value;
                                        break;
                                    case "PROG_EPI":
                                        spot.Episode = attribute.Value;
                                        break;
                                }
                            }
                        }
                        if (spot.Time.Year >= 2012 && spot.Time.Year <= 2015)
                            spots.Add(spot);
                    }
                }
                if (spots.Count > 1)
                {
                    string programName = string.Empty;
                    foreach (Spot spot in spots)
                    {
                        if (!string.IsNullOrEmpty(spot.Program))
                            programName = spot.Program;
                        else if (!string.IsNullOrEmpty(spot.Type))
                            spot.Program = programName;
                    }

                    DateTime minDate = spots.Select(x => x.Time).Min();
                    DateTime maxDate = spots.Select(x => x.Time).Max();
                    while (minDate < maxDate)
                    {
                        Day day = new Day(this, minDate);
                        day.AddSpotRange(spots.Where(x => x.Time >= day.StartTime && x.Time < day.EndTime).ToArray());
                        day.Save();
                        minDate = minDate.AddDays(1);
                    }
                }
            }
        }
    }
}
