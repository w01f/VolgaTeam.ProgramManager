using System;
using System.Text;
using System.Xml;

namespace ProgramManager.BusinessClasses
{
    public class Spot
    {
        private string _program = null;
        private string _episode = null;
        private string _type = null;
        private string _fcc = null;

        public Day Day { get; private set; }
        public DateTime Time { get; private set; }
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
        #endregion

        #region Calculated properties
        public string Station
        {
            get
            {
                return this.Day.Station.Name;
            }
        }
        #endregion

        public Spot(Day day)
        {
            this.Day = day;
        }

        public Spot(Day day, DateTime time)
        {
            this.Day = day;
            this.Time = time;
        }

        public string Serialize()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(@"<Time>" + this.Time.ToString() + @"</Time>");
            if (!string.IsNullOrEmpty(_program))
                result.AppendLine(@"<Program>" + _program.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Program>");
            if (!string.IsNullOrEmpty(_episode))
                result.AppendLine(@"<Episode>" + _episode.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Episode>");
            if (!string.IsNullOrEmpty(_type))
                result.AppendLine(@"<Type>" + _type.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Type>");
            if (!string.IsNullOrEmpty(_fcc))
                result.AppendLine(@"<FCC>" + _fcc.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</FCC>");
            result.AppendLine(@"<LastModified>" + (this.LastModified.HasValue ? this.LastModified.Value.ToString() : string.Empty) + @"</LastModified>");

            return result.ToString();
        }

        public void Deserialize(XmlNode node)
        {
            DateTime tempDate;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                switch (childNode.Name)
                {
                    case "Time":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.Time = tempDate;
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
                    case "LastModified":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.LastModified = tempDate;
                        break;
                }
            }
        }
    }
}
