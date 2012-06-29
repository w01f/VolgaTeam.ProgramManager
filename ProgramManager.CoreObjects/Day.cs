using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace ProgramManager.CoreObjects
{
    [DataContract]
    public class Day
    {
        [DataMember]
        private string _dataFilePath = string.Empty;

        [DataMember]
        public Station Station { get; private set; }
        [DataMember]
        public DateTime Date { get; private set; }
        [DataMember]
        public List<Spot> Spots { get; private set; }

        [DataMember]
        public bool DataNotSaved { get; set; }

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
            this.Spots = new List<Spot>();

            _dataFilePath = Path.Combine(this.Station.RootFolder.FullName, string.Format(@"{0}\{1}.xml", new string[] { this.Date.Year.ToString(), this.Date.ToString("MMddyy") }));
            if (!Directory.Exists(Path.GetDirectoryName(_dataFilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(_dataFilePath));

            Load();
        }

        private void InitDay()
        {
            this.Spots.Clear();
            DateTime spotTime = this.StartTime;
            do
            {
                Spot spot = new Spot(this, spotTime);
                foreach (Program program in this.Station.Programs)
                    if (program.ContainsGivenTime(spot.Time))
                    {
                        spot.Program = program.Name;
                        spot.ProgramLink = program.Id;
                        spot.Type = program.Type;
                        spot.FCC = program.FCC;
                        spot.MovieTitle = program.MovieTitle;
                        spot.Distributor = program.Distributor;
                        spot.ContractLength = program.ContractLength;
                        spot.CustomNote = program.CustomNote;
                    }
                this.Spots.Add(spot);
                spotTime = spotTime.AddMinutes(30);
            }
            while (!(spotTime.Hour == 5 && spotTime.Minute == 0));
        }

        private void Load()
        {
            this.Spots.Clear();
            if (File.Exists(_dataFilePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(_dataFilePath);

                XmlNode node = document.SelectSingleNode(@"/Programs");
                if (node != null)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name.Equals("Spot"))
                        {
                            Spot spot = new Spot(this);
                            spot.Deserialize(childNode);
                            if (this.Station.Programs.Where(x => x.Id.Equals(spot.ProgramLink)).Count() == 0 && !spot.ProgramLink.Equals(Guid.Empty))
                                spot.Clear();
                            this.Spots.Add(spot);
                        }
                    }
                }
                if (this.Spots.Count == 0)
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
            this.Spots.Sort((x, y) => x.Time.CompareTo(y.Time));
            this.DataNotSaved = false;
        }

        public void Save()
        {
            StringBuilder xml = new StringBuilder();

            xml.AppendLine(@"<Programs>");
            foreach (Spot spot in this.Spots)
                xml.AppendLine(@"<Spot>" + spot.Serialize() + @"</Spot>");
            xml.AppendLine(@"</Programs>");

            using (StreamWriter sw = new StreamWriter(_dataFilePath, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
                sw.Close();
            }
            this.DataNotSaved = false;
        }

        public void AddSpotRange(Spot[] spots)
        {
            foreach (Spot spot in spots)
            {
                Spot existedSpot = this.Spots.Where(x => x.Time.Equals(spot.Time)).FirstOrDefault();
                if (existedSpot != null)
                {
                    existedSpot.Program = spot.Program;
                    existedSpot.ProgramLink = spot.ProgramLink;
                    existedSpot.Episode = spot.Episode;
                    existedSpot.Type = spot.Type;
                    existedSpot.FCC = spot.FCC;
                    existedSpot.MovieTitle = spot.MovieTitle;
                    existedSpot.Distributor = spot.Distributor;
                    existedSpot.ContractLength = spot.ContractLength;
                    existedSpot.CustomNote = spot.CustomNote;
                }
                else
                {
                    this.Spots.Add(spot);
                    this.Spots.Sort((x, y) => x.Time.CompareTo(y.Time));
                }
            }
            this.DataNotSaved = true;
        }

        public void AddSpot(Spot spot)
        {
            Spot existedSpot = this.Spots.Where(x => x.Time.Year.Equals(spot.Time.Year) && x.Time.Month.Equals(spot.Time.Month) && x.Time.Day.Equals(spot.Time.Day) && x.Time.Hour.Equals(spot.Time.Hour) && x.Time.Minute.Equals(spot.Time.Minute)).FirstOrDefault();
            if (existedSpot != null)
            {
                existedSpot.Program = spot.Program;
                existedSpot.ProgramLink = spot.ProgramLink;
                existedSpot.Episode = spot.Episode;
                existedSpot.Type = spot.Type;
                existedSpot.FCC = spot.FCC;
                existedSpot.MovieTitle = spot.MovieTitle;
                existedSpot.Distributor = spot.Distributor;
                existedSpot.ContractLength = spot.ContractLength;
                existedSpot.CustomNote = spot.CustomNote;
            }
            else
            {
                this.Spots.Add(spot);
                this.Spots.Sort((x, y) => x.Time.CompareTo(y.Time));
            }
            this.DataNotSaved = true;
        }
    }
}
