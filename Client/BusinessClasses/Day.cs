﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ProgramManager.BusinessClasses
{
    public class Day
    {
        private string _dataFilePath = string.Empty;
        private List<Spot> _spots = new List<Spot>();

        public Station Station { get; private set; }
        public DateTime Date { get; private set; }

        public bool DataNotSaved { get; set; }

        public Day(Station station, DateTime date)
        {
            this.Station = station;
            this.Date = date;

            _dataFilePath = Path.Combine(this.Station.RootFolder.FullName, string.Format(@"{0}\{1}.xml", new string[] { this.Date.Year.ToString(), this.Date.ToString("MMddyy") }));
            if (!Directory.Exists(Path.GetDirectoryName(_dataFilePath)))
                Directory.CreateDirectory(Path.GetDirectoryName(_dataFilePath));

            Load();
        }

        private void InitDay()
        {
            _spots.Clear();
            DateTime spotTime = new DateTime(this.Date.Year, this.Date.Month, this.Date.Day, 5, 0, 0);
            do
            {
                Spot spot = new Spot(this, spotTime);
                foreach (Program program in this.Station.RecurentedPrograms)
                    if (program.ContainsGivenTime(spot.Time))
                    {
                        spot.Program = program.Name;
                        spot.Type = program.Type;
                        spot.FCC = program.FCC;
                    }
                _spots.Add(spot);
                spotTime = spotTime.AddMinutes(30);
            }
            while (!(spotTime.Hour == 5 && spotTime.Minute == 0));
        }

        private void Load()
        {
            _spots.Clear();
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
                            _spots.Add(spot);
                        }
                    }
                }
                if (_spots.Count == 0)
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
            _spots.Sort((x, y) => x.Time.CompareTo(y.Time));
            this.DataNotSaved = false;
        }

        public void Save()
        {
            StringBuilder xml = new StringBuilder();

            xml.AppendLine(@"<Programs>");
            foreach (Spot spot in _spots)
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

        public Spot[] GetSpots()
        {
            return _spots.ToArray();
        }

        public void AddSpotRange(Spot[] spots)
        {
            foreach (Spot spot in spots)
            {
                Spot existedSpot = _spots.Where(x => x.Time.Equals(spot.Time)).FirstOrDefault();
                if (existedSpot != null)
                {
                    existedSpot.Program = spot.Program;
                    existedSpot.Episode = spot.Episode;
                    existedSpot.Type = spot.Type;
                    existedSpot.FCC = spot.FCC;
                }
                else
                {
                    _spots.Add(spot);
                    _spots.Sort((x, y) => x.Time.CompareTo(y.Time));
                }
            }
            this.DataNotSaved = true;
        }

        public void AddSpot(Spot spot)
        {
            Spot existedSpot = _spots.Where(x => x.Time.Year.Equals(spot.Time.Year) && x.Time.Month.Equals(spot.Time.Month) && x.Time.Day.Equals(spot.Time.Day) && x.Time.Hour.Equals(spot.Time.Hour) && x.Time.Minute.Equals(spot.Time.Minute)).FirstOrDefault();
            if (existedSpot != null)
            {
                existedSpot.Program = spot.Program;
                existedSpot.Episode = spot.Episode;
                existedSpot.Type = spot.Type;
                existedSpot.FCC = spot.FCC;
            }
            else
            {
                _spots.Add(spot);
                _spots.Sort((x, y) => x.Time.CompareTo(y.Time));
            }
            this.DataNotSaved = true;
        }
    }
}
