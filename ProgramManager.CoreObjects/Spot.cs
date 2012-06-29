using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace ProgramManager.CoreObjects
{
    [DataContract]
    public class Spot
    {
        [DataMember]
        private string _program = null;
        [DataMember]
        private string _episode = null;
        [DataMember]
        private string _type = null;
        [DataMember]
        private string _fcc = null;
        [DataMember]
        private string _houseNumber = null;
        [DataMember]
        private string _movieTitle = null;
        [DataMember]
        private string _distributor = null;
        [DataMember]
        private string _contractLength = null;
        [DataMember]
        private string _customNote = null;

        [DataMember]
        public Day Day { get; private set; }
        [DataMember]
        public DateTime Time { get; set; }
        [DataMember]
        public Guid ProgramLink { get; set; }

        [DataMember]
        public DateTime? LastModified { get; private set; }

        #region Spot properties
        public DateTime Date
        {
            get
            {
                return this.Day.Date;
            }
        }
        public string Program
        {
            get
            {
                return _program;
            }
            set
            {
                _program = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string Episode
        {
            get
            {
                return _episode;
            }
            set
            {
                _episode = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string FCC
        {
            get
            {
                return _fcc;
            }
            set
            {
                _fcc = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string HouseNumber
        {
            get
            {
                return _houseNumber;
            }
            set
            {
                _houseNumber = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string MovieTitle
        {
            get
            {
                return _movieTitle;
            }
            set
            {
                _movieTitle = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string Distributor
        {
            get
            {
                return _distributor;
            }
            set
            {
                _distributor = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string ContractLength
        {
            get
            {
                return _contractLength;
            }
            set
            {
                _contractLength = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }

        public string CustomNote
        {
            get
            {
                return _customNote;
            }
            set
            {
                _customNote = value;
                this.LastModified = DateTime.Now;
                this.Day.DataNotSaved = true;
            }
        }
        #endregion

        #region Calculated properties
        public string Station
        {
            get
            {
                return this.Day.Station.Name;
            }
        }

        public Spot NextSpot
        {
            get
            {
                int nextStepIndex = this.Day.Spots.IndexOf(this) + 1;
                if (nextStepIndex > 0 && nextStepIndex < this.Day.Spots.Count)
                    return this.Day.Spots[nextStepIndex];
                else
                    return null;
            }
        }

        public string DetailedInfoText
        {
            get
            {
                List<string> result = new List<string>();
                if (!string.IsNullOrEmpty(_movieTitle))
                    result.Add(_movieTitle);
                if (!string.IsNullOrEmpty(_distributor))
                    result.Add(_distributor);
                if (!string.IsNullOrEmpty(_contractLength))
                    result.Add(_contractLength);
                if (!string.IsNullOrEmpty(_customNote))
                    result.Add(_customNote);
                if (result.Count > 0)
                    return string.Join(" | ", result.ToArray());
                else
                    return null;
            }
        }

        public string DetailedInfo
        {
            get
            {
                if (!string.IsNullOrEmpty(this.DetailedInfoText))
                {
                    if (this.NextSpot != null && this.DetailedInfoText.Equals(this.NextSpot.DetailedInfoText))
                        return null;
                    else
                        return this.DetailedInfoText;
                }
                else
                    return null;
            }
        }
        #endregion

        public Spot(Day day)
        {
            this.Day = day;
            this.ProgramLink = Guid.Empty;
        }

        public Spot(Day day, DateTime time)
        {
            this.Day = day;
            this.Time = time;
            this.ProgramLink = Guid.Empty;
        }

        public string Serialize()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(@"<Time>" + this.Time.ToString() + @"</Time>");
            result.AppendLine(@"<ProgramLink>" + this.ProgramLink.ToString() + @"</ProgramLink>");
            if (!string.IsNullOrEmpty(_program))
                result.AppendLine(@"<Program>" + _program.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Program>");
            if (!string.IsNullOrEmpty(_episode))
                result.AppendLine(@"<Episode>" + _episode.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Episode>");
            if (!string.IsNullOrEmpty(_type))
                result.AppendLine(@"<Type>" + _type.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Type>");
            if (!string.IsNullOrEmpty(_fcc))
                result.AppendLine(@"<FCC>" + _fcc.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</FCC>");
            if (!string.IsNullOrEmpty(_houseNumber))
                result.AppendLine(@"<HouseNumber>" + _houseNumber.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</HouseNumber>");
            if (!string.IsNullOrEmpty(_movieTitle))
                result.AppendLine(@"<MovieTitle>" + _movieTitle.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</MovieTitle>");
            if (!string.IsNullOrEmpty(_distributor))
                result.AppendLine(@"<Distributor>" + _distributor.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Distributor>");
            if (!string.IsNullOrEmpty(_contractLength))
                result.AppendLine(@"<ContractLength>" + _contractLength.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</ContractLength>");
            if (!string.IsNullOrEmpty(_customNote))
                result.AppendLine(@"<CustomNote>" + _customNote.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</CustomNote>");
            result.AppendLine(@"<LastModified>" + (this.LastModified.HasValue ? this.LastModified.Value.ToString() : string.Empty) + @"</LastModified>");

            return result.ToString();
        }

        public void Deserialize(XmlNode node)
        {
            DateTime tempDate;
            Guid tempGuid;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                switch (childNode.Name)
                {
                    case "Time":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.Time = tempDate;
                        break;
                    case "ProgramLink":
                        if (Guid.TryParse(childNode.InnerText, out tempGuid))
                            this.ProgramLink = tempGuid;
                        break;
                    case "Program":
                        _program = childNode.InnerText;
                        break;
                    case "Episode":
                        _episode = childNode.InnerText;
                        break;
                    case "Type":
                        _type = childNode.InnerText;
                        break;
                    case "FCC":
                        _fcc = childNode.InnerText;
                        break;
                    case "HouseNumber":
                        _houseNumber = childNode.InnerText;
                        break;
                    case "MovieTitle":
                        _movieTitle = childNode.InnerText;
                        break;
                    case "Distributor":
                        _distributor = childNode.InnerText;
                        break;
                    case "ContractLength":
                        _contractLength = childNode.InnerText;
                        break;
                    case "CustomNote":
                        _customNote = childNode.InnerText;
                        break;
                    case "LastModified":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.LastModified = tempDate;
                        break;
                }
            }
        }

        public void Clear()
        {
            this.Program = null;
            this.ProgramLink = Guid.Empty;
            this.Episode = null;
            this.HouseNumber = null;
            this.Type = null;
            this.FCC = null;
            this.MovieTitle = null;
            this.Distributor = null;
            this.ContractLength = null;
            this.CustomNote = null;
        }
    }
}
