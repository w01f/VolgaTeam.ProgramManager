using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace ProgramManager.CoreObjects
{
    [DataContract]
    public class Day
    {
        public Station Station { get; set; }
        [DataMember]
        public DateTime Date { get; private set; }
        [DataMember]
        public List<ProgramActivity> ProgramActivities { get; private set; }

        public bool DataNotSaved { get; set; }

        private string DataFilePath
        {
            get
            {
                return Path.Combine(this.Station.RootFolderPath, string.Format(@"{0}\{1}.xml", new string[] { this.Date.Year.ToString(), this.Date.ToString("MMddyy") }));
            }
        }

        public DateTime StartTime
        {
            get
            {
                return new DateTime(this.Date.Year, this.Date.Month, this.Date.Day, 5, 0, 0);
            }
        }

        public DateTime EndTime
        {
            get
            {
                return new DateTime(this.Date.Year, this.Date.Month, this.Date.Day, 4, 59, 59).AddDays(1);
            }
        }


        public Day(Station station, DateTime date)
        {
            this.Station = station;
            this.Date = date;
            this.ProgramActivities = new List<ProgramActivity>();

            Load();
        }

        private void InitDay()
        {
            this.ProgramActivities.Clear();
            DateTime programActivityTime = this.StartTime;
            do
            {
                ProgramActivity programActivity = new ProgramActivity(this, programActivityTime);
                ApplyPrograms(programActivity);
                this.ProgramActivities.Add(programActivity);
                programActivityTime = programActivityTime.AddMinutes(30);
            }
            while (!(programActivityTime.Hour == 5 && programActivityTime.Minute == 0));
        }

        private void ApplyPrograms(ProgramActivity programActivity)
        {
            foreach (Program program in this.Station.Programs)
                if (program.ContainsGivenTime(programActivity.Time))
                {
                    programActivity.Program = program.Name;
                    programActivity.ProgramLink = program.Id;
                    programActivity.Type = program.Type;
                    programActivity.FCC = program.FCC;
                    programActivity.MovieTitle = program.MovieTitle;
                    programActivity.Distributor = program.Distributor;
                    programActivity.ContractLength = program.ContractLength;
                    programActivity.CustomNote = program.CustomNote;
                }
        }

        private void Load()
        {
            this.ProgramActivities.Clear();
            if (File.Exists(this.DataFilePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(this.DataFilePath);

                XmlNode node = document.SelectSingleNode(@"/Programs");
                if (node != null)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        ProgramActivity programActivity = new ProgramActivity(this);
                        programActivity.Deserialize(childNode);
                        if (this.Station.Programs.Where(x => x.Id.Equals(programActivity.ProgramLink)).Count() == 0 && !programActivity.ProgramLink.Equals(Guid.Empty))
                            programActivity.Clear();
                        ApplyPrograms(programActivity);
                        this.ProgramActivities.Add(programActivity);
                    }
                }
                if (this.ProgramActivities.Count == 0)
                {
                    InitDay();
                    Save();
                }
            }
            else
            {
                InitDay();
                Save();
            }
            this.ProgramActivities.Sort((x, y) => x.Time.CompareTo(y.Time));
            this.DataNotSaved = false;
        }

        public void Save()
        {
            StringBuilder xml = new StringBuilder();

            xml.AppendLine(@"<Programs>");
            foreach (ProgramActivity programActivity in this.ProgramActivities)
                xml.AppendLine(@"<ProgramActivity>" + programActivity.Serialize() + @"</ProgramActivity>");
            xml.AppendLine(@"</Programs>");

            if (!Directory.Exists(Path.GetDirectoryName(this.DataFilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(this.DataFilePath));

            using (StreamWriter sw = new StreamWriter(this.DataFilePath, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
                sw.Close();
            }
            this.DataNotSaved = false;
        }

        public void AddProgramActivityRange(ProgramActivity[] programActivities)
        {
            foreach (ProgramActivity programActivity in programActivities)
            {
                ProgramActivity existedProgramActivity = this.ProgramActivities.Where(x => x.Time.Equals(programActivity.Time)).FirstOrDefault();
                if (existedProgramActivity != null)
                {
                    existedProgramActivity.Program = programActivity.Program;
                    existedProgramActivity.ProgramLink = programActivity.ProgramLink;
                    existedProgramActivity.Episode = programActivity.Episode;
                    existedProgramActivity.Type = programActivity.Type;
                    existedProgramActivity.FCC = programActivity.FCC;
                    existedProgramActivity.MovieTitle = programActivity.MovieTitle;
                    existedProgramActivity.Distributor = programActivity.Distributor;
                    existedProgramActivity.ContractLength = programActivity.ContractLength;
                    existedProgramActivity.CustomNote = programActivity.CustomNote;
                }
                else
                {
                    this.ProgramActivities.Add(programActivity);
                    this.ProgramActivities.Sort((x, y) => x.Time.CompareTo(y.Time));
                }
            }
            this.DataNotSaved = true;
        }

        public void AddProgramActivity(ProgramActivity programActivity)
        {
            ProgramActivity existedProgramActivity = this.ProgramActivities.Where(x => x.Time.Year.Equals(programActivity.Time.Year) && x.Time.Month.Equals(programActivity.Time.Month) && x.Time.Day.Equals(programActivity.Time.Day) && x.Time.Hour.Equals(programActivity.Time.Hour) && x.Time.Minute.Equals(programActivity.Time.Minute)).FirstOrDefault();
            if (existedProgramActivity != null)
            {
                existedProgramActivity.Program = programActivity.Program;
                existedProgramActivity.ProgramLink = programActivity.ProgramLink;
                existedProgramActivity.Episode = programActivity.Episode;
                existedProgramActivity.Type = programActivity.Type;
                existedProgramActivity.FCC = programActivity.FCC;
                existedProgramActivity.MovieTitle = programActivity.MovieTitle;
                existedProgramActivity.Distributor = programActivity.Distributor;
                existedProgramActivity.ContractLength = programActivity.ContractLength;
                existedProgramActivity.CustomNote = programActivity.CustomNote;
            }
            else
            {
                this.ProgramActivities.Add(programActivity);
                this.ProgramActivities.Sort((x, y) => x.Time.CompareTo(y.Time));
            }
            this.DataNotSaved = true;
        }
    }
}
