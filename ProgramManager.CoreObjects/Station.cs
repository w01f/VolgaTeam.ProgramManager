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
        public string Name { get; private set; }
        [DataMember]
        public Bitmap Logo { get; private set; }

        [DataMember]
        public List<Day> Days { get; private set; }
        [DataMember]
        public List<Program> Programs { get; private set; }
        [DataMember]
        public List<string> ProgramNames { get; private set; }

        public DateTime LastLoaded { get; set; }
        public bool NeedToUpdate { get; set; }

        private string ProgramsStoragePath
        {
            get
            {
                return Path.Combine(this.RootFolderPath, "Programs.xml");
            }
        }

        private string ProgramNamesStoragePath
        {
            get
            {
                return Path.Combine(this.RootFolderPath, "ProgramNames.xml");
            }
        }

        private string MetaDataStoragePath
        {
            get
            {
                return Path.Combine(this.RootFolderPath, "StationInfo.xml");
            }
        }

        public string RootFolderPath
        {
            get
            {
                return Path.Combine(ConfigurationClasses.SettingsManager.Instance.StationsRootPath, this.Name);
            }
        }

        public Station(string stationName)
        {
            this.Name = stationName;

            string logoPath = Path.Combine(this.RootFolderPath, this.Name + ".png");
            if (File.Exists(logoPath))
                this.Logo = new Bitmap(logoPath);
            else
                this.Logo = Properties.Resources.Logo;

            this.Days = new List<Day>();

            this.Programs = new List<Program>();
            this.ProgramNames = new List<string>();

            LoadPrograms();

            LoadProgramNames();

            LoadStationMetaData();

            LoadDataFromOldFormat();
        }

        public void ReleaseResources()
        {
            if (this.Logo != null)
            {
                this.Logo.Dispose();
                this.Logo = null;
            }
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

        public Day[] GetDays(DateTime startDate, DateTime endDate)
        {
            List<Day> result = new List<Day>();
            DateTime date = startDate;
            while (date <= endDate)
            {
                result.Add(GetDay(date));
                date = date.AddDays(1);
            }
            return result.ToArray();
        }

        public void LoadExistedDays(DateTime startDate, DateTime endDate)
        {
            while (startDate <= endDate)
            {
                string directoryName = Path.Combine(this.RootFolderPath, startDate.ToString("yyyy"));
                if (Directory.Exists(directoryName))
                {
                    if (Directory.GetFiles(directoryName, string.Format("{0}*.*", startDate.ToString("MMddyy"))).Length > 0)
                        GetDay(startDate);
                    try
                    {
                        startDate = startDate.AddDays(1);
                    }
                    catch
                    {
                        break;
                    }
                }
                else
                    try
                    {
                        startDate = startDate.AddYears(1);
                    }
                    catch
                    {
                        break;
                    }
            }
        }

        public void SaveProgramActivities()
        {
            if (!Directory.Exists(this.RootFolderPath))
                Directory.CreateDirectory(this.RootFolderPath);
            foreach (Day day in this.Days)
            {
                foreach (ProgramActivity programActivity in day.ProgramActivities)
                    programActivity.Day = day;
                day.Station = this;
                day.Save();
            }
        }

        public void SaveLogo()
        {
            string logoFilePath = Path.Combine(this.RootFolderPath, this.Name + ".png");
            try
            {
                if (File.Exists(logoFilePath))
                    File.Delete(logoFilePath);
                if (this.Logo != null)
                    this.Logo.Save(logoFilePath);
            }
            catch { }
        }

        public ProgramActivity[] Search(DateTime startDate, DateTime endDate, string programName)
        {
            List<ProgramActivity> searchResult = new List<ProgramActivity>();

            startDate = new DateTime(startDate.Year, startDate.Month, startDate.Day, 0, 0, 0);
            endDate = endDate.AddDays(1);
            endDate = new DateTime(endDate.Year, endDate.Month, endDate.Day, 0, 0, 0);

            LoadExistedDays(startDate, endDate);

            foreach (Day day in this.Days.Where(x => x.Date >= startDate && x.Date <= endDate))
                searchResult.AddRange(day.ProgramActivities.Where(x => string.IsNullOrEmpty(programName) || (!string.IsNullOrEmpty(x.Program) && x.Program.ToLower().Contains(programName.ToLower()))));

            searchResult.Sort((x, y) => x.Time.CompareTo(y.Time));

            return searchResult.ToArray();
        }

        public StationInformation GetStationInfo()
        {
            StationInformation result = new StationInformation();
            ProgramActivity lastChangedActivity = this.Days.Select(x => x.ProgramActivities.OrderBy(y => y.LastModified).LastOrDefault()).OrderBy(x => x.LastModified).LastOrDefault();
            result.LastModified = lastChangedActivity != null ? (lastChangedActivity.LastModified.HasValue ? lastChangedActivity.LastModified.Value : DateTime.MinValue) : DateTime.MinValue;
            result.AuthorOfChanges = lastChangedActivity != null ? (!string.IsNullOrEmpty(lastChangedActivity.UserName) ? lastChangedActivity.UserName : string.Empty) : string.Empty;
            return result;
        }

        #region MetaData Stuff
        private void LoadStationMetaData()
        {
            DateTime tempDate;
            if (File.Exists(this.MetaDataStoragePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(this.MetaDataStoragePath);

                XmlNode node = document.SelectSingleNode(@"/StationMetaData/LastLoaded");
                if (node != null)
                {
                    if (DateTime.TryParse(node.InnerText, out tempDate))
                        this.LastLoaded = tempDate;
                }
            }
        }

        public void SaveStationMetaData()
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine(@"<StationMetaData>");
            xml.AppendLine(@"<LastLoaded>" + this.LastLoaded.ToString() + @"</LastLoaded>");
            xml.AppendLine(@"</StationMetaData>");

            using (StreamWriter sw = new StreamWriter(this.MetaDataStoragePath, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
                sw.Close();
            }
        }
        #endregion

        #region Program Names Stuff
        private void CreateProgramNamesList()
        {
            LoadExistedDays(DateTime.MinValue, DateTime.MaxValue);
            foreach (Day day in this.Days)
            {
                string[] programNames = day.ProgramActivities.Where(x => !string.IsNullOrEmpty(x.Program)).Select(x => x.Program.Trim()).Distinct().ToArray();
                this.ProgramNames.AddRange(programNames.Where(x => !this.ProgramNames.Contains(x)));
            }

            SaveProgramNames();
        }

        private void LoadProgramNames()
        {
            this.ProgramNames.Clear();
            if (File.Exists(this.ProgramNamesStoragePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(this.ProgramNamesStoragePath);

                XmlNode node = document.SelectSingleNode(@"/ProgramNames");
                if (node != null)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name.Equals("ProgramName"))
                        {
                            if (!this.ProgramNames.Contains(childNode.InnerText.Trim()))
                                this.ProgramNames.Add(childNode.InnerText);
                        }
                    }
                }
                this.ProgramNames.Sort((x, y) => InteropClasses.WinAPIHelper.StrCmpLogicalW(x, y));
            }
            else
                CreateProgramNamesList();
        }

        public void SaveProgramNames()
        {
            this.ProgramNames.Sort((x, y) => InteropClasses.WinAPIHelper.StrCmpLogicalW(x, y));

            StringBuilder xml = new StringBuilder();
            xml.AppendLine(@"<ProgramNames>");
            foreach (string programName in this.ProgramNames)
                xml.AppendLine(@"<ProgramName>" + programName.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</ProgramName>");
            xml.AppendLine(@"</ProgramNames>");

            using (StreamWriter sw = new StreamWriter(this.ProgramNamesStoragePath, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
                sw.Close();
            }
        }
        #endregion

        #region Programs Stuff
        public void LoadPrograms()
        {
            this.Programs.Clear();
            if (File.Exists(this.ProgramsStoragePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(this.ProgramsStoragePath);

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

            using (StreamWriter sw = new StreamWriter(this.ProgramsStoragePath, false))
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
            DateTime[] programProgramActivityDates = program.GetUsedTimes(lastCreatedDay.Date.AddDays(1));
            foreach (Day day in this.Days)
            {
                foreach (DateTime time in programProgramActivityDates.Where(x => x >= day.StartTime && x <= day.EndTime))
                {
                    ProgramActivity programActivity = new ProgramActivity(day, time);
                    programActivity.ProgramLink = program.Id;
                    programActivity.Program = program.Name;
                    programActivity.Type = program.Type;
                    programActivity.FCC = program.FCC;
                    programActivity.HouseNumber = program.HouseNumber;
                    programActivity.MovieTitle = program.MovieTitle;
                    programActivity.Distributor = program.Distributor;
                    programActivity.ContractLength = program.ContractLength;
                    programActivity.CustomNote = program.CustomNote;
                    day.AddProgramActivity(programActivity);
                }
            }
        }

        public void DeleteProgram(Program program, bool clearProgramActivities)
        {
            if (clearProgramActivities)
            {
                foreach (Day day in this.Days)
                {
                    foreach (ProgramActivity programActivity in day.ProgramActivities.Where(x => x.ProgramLink.Equals(program.Id)))
                        programActivity.Clear();
                    day.Save();
                }
            }
            this.Programs.Remove(program);
            SavePrograms();
        }
        #endregion

        #region Old Format Loading
        private void LoadDataFromOldFormat()
        {
            DateTime tempDate;
            int tempInt;

            string filePath = Path.Combine(this.RootFolderPath, "olddata.xml");
            Day fakeDay = new Day(this, DateTime.Now);
            List<ProgramActivity> programActivities = new List<ProgramActivity>();

            if (File.Exists(filePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(filePath);

                XmlNode node = document.SelectSingleNode(@"/RECORDS");
                if (node != null)
                {
                    foreach (XmlNode recordNode in node.ChildNodes)
                    {
                        ProgramActivity programActivity = new ProgramActivity(fakeDay);
                        foreach (XmlNode rowNode in recordNode.ChildNodes)
                        {
                            foreach (XmlAttribute attribute in rowNode.Attributes)
                            {
                                switch (attribute.Name)
                                {
                                    case "PROG_DATE":
                                        if (DateTime.TryParseExact(attribute.Value, "yyyyMMdd", new System.Globalization.CultureInfo("en-us"), System.Globalization.DateTimeStyles.None, out tempDate))
                                            programActivity.Time = tempDate;
                                        break;
                                    case "PROG_SO":
                                        if (int.TryParse(attribute.Value, out tempInt))
                                            programActivity.Time = new DateTime(programActivity.Time.Year, programActivity.Time.Month, programActivity.Time.Day, 5, 0, 0).AddMinutes(30 * (tempInt - 1));
                                        break;
                                    case "PROG_PROG":
                                        programActivity.Program = attribute.Value;
                                        break;
                                    case "PROG_LSN":
                                        programActivity.Type = attribute.Value;
                                        break;
                                    case "PROG_EPI":
                                        programActivity.Episode = attribute.Value;
                                        break;
                                }
                            }
                        }
                        if (programActivity.Time.Year >= 2012 && programActivity.Time.Year <= 2015)
                            programActivities.Add(programActivity);
                    }
                }
                if (programActivities.Count > 1)
                {
                    string programName = string.Empty;
                    foreach (ProgramActivity programActivity in programActivities)
                    {
                        if (!string.IsNullOrEmpty(programActivity.Program))
                            programName = programActivity.Program;
                        else if (!string.IsNullOrEmpty(programActivity.Type))
                            programActivity.Program = programName;
                    }

                    DateTime minDate = programActivities.Select(x => x.Time).Min();
                    DateTime maxDate = programActivities.Select(x => x.Time).Max();
                    while (minDate < maxDate)
                    {
                        Day day = new Day(this, minDate);
                        day.AddProgramActivityRange(programActivities.Where(x => x.Time >= day.StartTime && x.Time < day.EndTime).ToArray());
                        day.Save();
                        minDate = minDate.AddDays(1);
                    }
                }
            }
        }
        #endregion
    }
}
