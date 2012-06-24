using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ProgramManager.BusinessClasses
{
    public class Program
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public string FCC { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int RecureEveryWeek { get; set; }
        public bool RecureOnMonday { get; set; }
        public bool RecureOnTuesday { get; set; }
        public bool RecureOnWednesday { get; set; }
        public bool RecureOnThursday { get; set; }
        public bool RecureOnFriday { get; set; }
        public bool RecureOnSaturday { get; set; }
        public bool RecureOnSunday { get; set; }

        public bool NoEndRecurence { get; set; }

        public bool LimitedByRecurenceNumber { get; set; }
        public int RecurenceNumberLimit { get; set; }

        public bool LimitedByEndDate { get; set; }
        public DateTime EndDate { get; set; }

        public Program()
        {
            this.Name = string.Empty;
            this.Type = string.Empty;
            this.FCC = string.Empty;
        }

        public string Serialize()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(@"<Name>" + this.Name.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Name>");
            result.AppendLine(@"<Date>" + this.Date.ToString() + @"</Date>");
            result.AppendLine(@"<Type>" + this.Type.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Type>");
            result.AppendLine(@"<FCC>" + this.FCC.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</FCC>");
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

            foreach (XmlNode childNode in node.ChildNodes)
            {
                switch (childNode.Name)
                {
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
                lastTime = new DateTime(endDate.Year, endDate.Month, endDate.Day, this.EndTime.Hour, this.EndTime.Minute, this.EndTime.Second);
            else if (this.LimitedByEndDate)
                lastTime = new DateTime(this.EndDate.Year, this.EndDate.Month, this.EndDate.Day, this.EndTime.Hour, this.EndTime.Minute, this.EndTime.Second);
            else if (this.LimitedByRecurenceNumber)
                lastTime = DateTime.MaxValue;


            int occurenceCount = 1;
            DateTime startTime = this.StartTime;
            DateTime endTime = this.EndTime;
            int weeksCount = 1;
            do
            {
                bool stop = false;
                while (!stop)
                {
                    switch (startTime.DayOfWeek)
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
                        if (startTime.DayOfWeek == DayOfWeek.Monday)
                            weeksCount++;
                        if (weeksCount > this.RecureEveryWeek || this.RecureEveryWeek == 0)
                            weeksCount = 1;
                    }
                }
                endTime = new DateTime(startTime.Year, startTime.Month, startTime.Day, endTime.Hour, endTime.Minute, endTime.Second);

                if (weeksCount == 1 || this.RecureEveryWeek == 0)
                {
                    DateTime spotTime = startTime;
                    while (spotTime <= endTime)
                    {
                        result.Add(spotTime);
                        spotTime = spotTime.AddMinutes(30);
                    }
                    occurenceCount++;
                }
               
                startTime = startTime.AddDays(1);
                if (startTime.DayOfWeek == DayOfWeek.Monday)
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
