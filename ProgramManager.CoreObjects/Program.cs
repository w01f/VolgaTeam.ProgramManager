using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;

namespace ProgramManager.CoreObjects
{
    [DataContract]
    public class Program
    {
        [DataMember]
        public Guid Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime Date { get; set; }
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string FCC { get; set; }
        [DataMember]
        public string HouseNumber { get; set; }
        [DataMember]
        public string MovieTitle { get; set; }
        [DataMember]
        public string Distributor { get; set; }
        [DataMember]
        public string ContractLength { get; set; }
        [DataMember]
        public string CustomNote { get; set; }
        [DataMember]
        public DateTime StartTime { get; set; }
        [DataMember]
        public DateTime EndTime { get; set; }

        [DataMember]
        public int RecureEveryWeek { get; set; }
        [DataMember]
        public bool RecureOnMonday { get; set; }
        [DataMember]
        public bool RecureOnTuesday { get; set; }
        [DataMember]
        public bool RecureOnWednesday { get; set; }
        [DataMember]
        public bool RecureOnThursday { get; set; }
        [DataMember]
        public bool RecureOnFriday { get; set; }
        [DataMember]
        public bool RecureOnSaturday { get; set; }
        [DataMember]
        public bool RecureOnSunday { get; set; }

        [DataMember]
        public bool NoEndRecurence { get; set; }

        [DataMember]
        public bool LimitedByRecurenceNumber { get; set; }
        [DataMember]
        public int RecurenceNumberLimit { get; set; }

        [DataMember]
        public bool LimitedByEndDate { get; set; }
        [DataMember]
        public DateTime EndDate { get; set; }

        #region Calculated Programs
        public string Duration
        {
            get
            {
                TimeSpan span = this.EndTime.Subtract(this.StartTime);
                return (span.Hours > 0 ? string.Format("{0} Hours ", span.Hours) : string.Empty) + (span.Minutes > 0 ? string.Format("{0} Minutes ", span.Minutes) : string.Empty);
            }
        }

        public string DetailedInfo
        {
            get
            {
                StringBuilder result = new StringBuilder();

                List<string> line = new List<string>();
                if (!string.IsNullOrEmpty(this.MovieTitle))
                    line.Add(this.MovieTitle);
                if (!string.IsNullOrEmpty(this.Distributor))
                    line.Add(this.Distributor);
                if (!string.IsNullOrEmpty(this.ContractLength))
                    line.Add(this.ContractLength);
                if (!string.IsNullOrEmpty(this.CustomNote))
                    line.Add(this.CustomNote);
                if (line.Count > 0)
                    result.AppendLine(string.Join(" | ", line.ToArray()));

                line.Clear();
                List<string> recureDays = new List<string>();
                if (this.RecureOnMonday)
                    recureDays.Add("Mo");
                if (this.RecureOnTuesday)
                    recureDays.Add("Tu");
                if (this.RecureOnWednesday)
                    recureDays.Add("We");
                if (this.RecureOnThursday)
                    recureDays.Add("Th");
                if (this.RecureOnFriday)
                    recureDays.Add("Fr");
                if (this.RecureOnSaturday)
                    recureDays.Add("Sa");
                if (this.RecureOnSunday)
                    recureDays.Add("Su");
                line.Add(string.Format("Recure every {0} week {1}", new string[] { this.RecureEveryWeek.ToString(), (recureDays.Count > 0 ? ("on" + string.Join(", ", recureDays.ToArray())) : string.Empty) }));

                if (this.NoEndRecurence)
                    line.Add("No end date");
                else if (this.LimitedByRecurenceNumber)
                    line.Add(string.Format("End after {0} occurences", this.RecurenceNumberLimit.ToString()));
                else if (this.LimitedByEndDate)
                    line.Add(string.Format("End by {0}", this.EndDate.ToString("ddd, MM/dd/yy")));

                if (line.Count > 0)
                    result.AppendLine(string.Join(", ", line.ToArray()));

                return result.ToString();
            }
        }
        #endregion

        public Program()
        {
            this.Id = Guid.NewGuid();
        }

        public Program Clone()
        {
            Program clone = new Program();
            clone.Id = this.Id;
            clone.Name = this.Name;
            clone.Date = this.Date;
            clone.Type = this.Type;
            clone.FCC = this.FCC;
            clone.HouseNumber = this.HouseNumber;
            clone.MovieTitle = this.MovieTitle;
            clone.Distributor = this.Distributor;
            clone.ContractLength = this.ContractLength;
            clone.CustomNote = this.CustomNote;
            clone.StartTime = this.StartTime;
            clone.EndTime = this.EndTime;

            clone.RecureEveryWeek = this.RecureEveryWeek;
            clone.RecureOnMonday = this.RecureOnMonday;
            clone.RecureOnTuesday = this.RecureOnTuesday;
            clone.RecureOnWednesday = this.RecureOnWednesday;
            clone.RecureOnThursday = this.RecureOnThursday;
            clone.RecureOnFriday = this.RecureOnFriday;
            clone.RecureOnSaturday = this.RecureOnSaturday;
            clone.RecureOnSunday = this.RecureOnSunday;

            clone.NoEndRecurence = this.NoEndRecurence;

            clone.LimitedByRecurenceNumber = this.LimitedByRecurenceNumber;
            clone.RecurenceNumberLimit = this.RecurenceNumberLimit;

            clone.LimitedByEndDate = this.LimitedByEndDate;
            clone.EndDate = this.EndDate;
            return clone;
        }

        public string Serialize()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(@"<Id>" + this.Id.ToString() + @"</Id>");
            if (!string.IsNullOrEmpty(this.Name))
                result.AppendLine(@"<Name>" + this.Name.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Name>");
            result.AppendLine(@"<Date>" + this.Date.ToString() + @"</Date>");
            if (!string.IsNullOrEmpty(this.Type))
                result.AppendLine(@"<Type>" + this.Type.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Type>");
            if (!string.IsNullOrEmpty(this.FCC))
                result.AppendLine(@"<FCC>" + this.FCC.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</FCC>");
            if (!string.IsNullOrEmpty(this.HouseNumber))
                result.AppendLine(@"<HouseNumber>" + this.HouseNumber.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</HouseNumber>");
            if (!string.IsNullOrEmpty(this.MovieTitle))
                result.AppendLine(@"<MovieTitle>" + this.MovieTitle.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</MovieTitle>");
            if (!string.IsNullOrEmpty(this.Distributor))
                result.AppendLine(@"<Distributor>" + this.Distributor.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Distributor>");
            if (!string.IsNullOrEmpty(this.ContractLength))
                result.AppendLine(@"<ContractLength>" + this.ContractLength.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</ContractLength>");
            if (!string.IsNullOrEmpty(this.CustomNote))
                result.AppendLine(@"<CustomNote>" + this.CustomNote.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</CustomNote>");
            result.AppendLine(@"<StartTime>" + this.StartTime.ToString() + @"</StartTime>");
            result.AppendLine(@"<EndTime>" + this.EndTime.ToString() + @"</EndTime>");

            result.AppendLine(@"<RecureEveryWeek>" + this.RecureEveryWeek.ToString() + @"</RecureEveryWeek>");
            result.AppendLine(@"<RecureOnMonday>" + this.RecureOnMonday.ToString() + @"</RecureOnMonday>");
            result.AppendLine(@"<RecureOnTuesday>" + this.RecureOnTuesday.ToString() + @"</RecureOnTuesday>");
            result.AppendLine(@"<RecureOnWednesday>" + this.RecureOnWednesday.ToString() + @"</RecureOnWednesday>");
            result.AppendLine(@"<RecureOnThursday>" + this.RecureOnThursday.ToString() + @"</RecureOnThursday>");
            result.AppendLine(@"<RecureOnFriday>" + this.RecureOnFriday.ToString() + @"</RecureOnFriday>");
            result.AppendLine(@"<RecureOnSaturday>" + this.RecureOnSaturday.ToString() + @"</RecureOnSaturday>");
            result.AppendLine(@"<RecureOnSunday>" + this.RecureOnSunday.ToString() + @"</RecureOnSunday>");

            result.AppendLine(@"<NoEndRecurence>" + this.NoEndRecurence.ToString() + @"</NoEndRecurence>");
            result.AppendLine(@"<LimitedByRecurenceNumber>" + this.LimitedByRecurenceNumber.ToString() + @"</LimitedByRecurenceNumber>");
            result.AppendLine(@"<RecurenceNumberLimit>" + this.RecurenceNumberLimit.ToString() + @"</RecurenceNumberLimit>");
            result.AppendLine(@"<LimitedByEndDate>" + this.LimitedByEndDate.ToString() + @"</LimitedByEndDate>");
            result.AppendLine(@"<EndDate>" + this.EndDate.ToString() + @"</EndDate>");

            return result.ToString();
        }

        public void Deserialize(XmlNode node)
        {
            bool tempBool;
            int tempInt;
            DateTime tempDate;
            Guid tempGuid;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                switch (childNode.Name)
                {
                    case "Id":
                        if (Guid.TryParse(childNode.InnerText, out tempGuid))
                            this.Id = tempGuid;
                        break;
                    case "Name":
                        this.Name = childNode.InnerText;
                        break;
                    case "Date":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.Date = tempDate;
                        break;
                    case "Type":
                        this.Type = childNode.InnerText;
                        break;
                    case "FCC":
                        this.FCC = childNode.InnerText;
                        break;
                    case "HouseNumber":
                        this.HouseNumber = childNode.InnerText;
                        break;
                    case "MovieTitle":
                        this.MovieTitle = childNode.InnerText;
                        break;
                    case "Distributor":
                        this.Distributor = childNode.InnerText;
                        break;
                    case "ContractLength":
                        this.ContractLength = childNode.InnerText;
                        break;
                    case "CustomNote":
                        this.CustomNote = childNode.InnerText;
                        break;
                    case "StartTime":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.StartTime = tempDate;
                        break;
                    case "EndTime":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.EndTime = tempDate;
                        break;
                    case "RecureEveryWeek":
                        if (int.TryParse(childNode.InnerText, out tempInt))
                            this.RecureEveryWeek = tempInt;
                        break;
                    case "RecureOnMonday":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.RecureOnMonday = tempBool;
                        break;
                    case "RecureOnTuesday":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.RecureOnTuesday = tempBool;
                        break;
                    case "RecureOnWednesday":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.RecureOnWednesday = tempBool;
                        break;
                    case "RecureOnThursday":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.RecureOnThursday = tempBool;
                        break;
                    case "RecureOnFriday":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.RecureOnFriday = tempBool;
                        break;
                    case "RecureOnSaturday":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.RecureOnSaturday = tempBool;
                        break;
                    case "RecureOnSunday":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.RecureOnSunday = tempBool;
                        break;
                    case "NoEndRecurence":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.NoEndRecurence = tempBool;
                        break;
                    case "LimitedByRecurenceNumber":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.LimitedByRecurenceNumber = tempBool;
                        break;
                    case "RecurenceNumberLimit":
                        if (int.TryParse(childNode.InnerText, out tempInt))
                            this.RecurenceNumberLimit = tempInt;
                        break;
                    case "LimitedByEndDate":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.LimitedByEndDate = tempBool;
                        break;
                    case "EndDate":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.EndDate = tempDate;
                        break;
                }
            }
        }

        public DateTime[] GetUsedTimes(DateTime endDate)
        {
            List<DateTime> result = new List<DateTime>();

            DateTime lastTime = DateTime.MinValue;
            if (this.NoEndRecurence)
                lastTime = new DateTime(endDate.Year, endDate.Month, endDate.Day, 5, 0, 0).AddDays(1);
            else if (this.LimitedByEndDate)
                lastTime = new DateTime(this.EndDate.Year, this.EndDate.Month, this.EndDate.Day, 5, 0, 0).AddDays(1);
            else if (this.LimitedByRecurenceNumber)
                lastTime = DateTime.MaxValue;


            int occurenceCount = 1;
            DateTime startTime = this.StartTime;
            DateTime programDate = this.Date;
            DateTime endTime = this.EndTime;
            int weeksCount = 1;
            do
            {
                bool stop = false;
                while (!stop)
                {
                    switch (programDate.DayOfWeek)
                    {
                        case DayOfWeek.Monday:
                            stop = this.RecureOnMonday;
                            break;
                        case DayOfWeek.Tuesday:
                            stop = this.RecureOnTuesday;
                            break;
                        case DayOfWeek.Wednesday:
                            stop = this.RecureOnWednesday;
                            break;
                        case DayOfWeek.Thursday:
                            stop = this.RecureOnThursday;
                            break;
                        case DayOfWeek.Friday:
                            stop = this.RecureOnFriday;
                            break;
                        case DayOfWeek.Saturday:
                            stop = this.RecureOnSaturday;
                            break;
                        case DayOfWeek.Sunday:
                            stop = this.RecureOnSunday;
                            break;
                    }
                    if (!stop)
                    {
                        startTime = startTime.AddDays(1);
                        endTime = endTime.AddDays(1);
                        programDate = programDate.AddDays(1);
                        if (programDate.DayOfWeek == DayOfWeek.Monday)
                            weeksCount++;
                        if (weeksCount > this.RecureEveryWeek || this.RecureEveryWeek == 0)
                            weeksCount = 1;
                    }
                }

                if (weeksCount == 1 || this.RecureEveryWeek == 0)
                {
                    DateTime programActivityTime = startTime;
                    while (programActivityTime < endTime)
                    {
                        result.Add(programActivityTime);
                        programActivityTime = programActivityTime.AddMinutes(30);
                    }
                    occurenceCount++;
                }

                startTime = startTime.AddDays(1);
                endTime = endTime.AddDays(1);
                programDate = programDate.AddDays(1);
                if (programDate.DayOfWeek == DayOfWeek.Monday)
                    weeksCount++;
                if (weeksCount > this.RecureEveryWeek || this.RecureEveryWeek == 0)
                    weeksCount = 1;
            }
            while (endTime <= lastTime && ((occurenceCount <= this.RecurenceNumberLimit) || !this.LimitedByRecurenceNumber));

            return result.ToArray();
        }

        public bool ContainsGivenTime(DateTime time)
        {
            return (new List<DateTime>(GetUsedTimes(time))).Where(x => x.Year.Equals(time.Year) && x.Month.Equals(time.Month) && x.Day.Equals(time.Day) && x.Hour.Equals(time.Hour) && x.Minute.Equals(time.Minute)).Count() > 0;
        }
    }
}
