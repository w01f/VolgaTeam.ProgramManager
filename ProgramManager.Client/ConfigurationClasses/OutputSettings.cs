using System;
using System.Text;
using System.Xml;

namespace ProgramManager.Client.ConfigurationClasses
{
    public class OutputSettings
    {
        public CoreObjects.OutputFont HeaderFont { get; set; }
        public CoreObjects.OutputFont FooterFont { get; set; }
        public CoreObjects.OutputFont BodyFont { get; set; }
        public bool UsePrimeTimeSpecialFontSize { get; set; }
        public int PrimeTimeSpecialFontSize { get; set; }
        public DateTime WeekPrimeTimeStart { get; set; }
        public DateTime WeekPrimeTimeEnd { get; set; }
        public DateTime SundayPrimeTimeStart { get; set; }
        public DateTime SundayPrimeTimeEnd { get; set; }
        public bool ShowHouseNumber { get; set; }

        public OutputSettings()
        {
            this.HeaderFont = new CoreObjects.OutputFont("Arial", 12, true);
            this.FooterFont = new CoreObjects.OutputFont("Arial", 11);
            this.BodyFont = new CoreObjects.OutputFont("Arial", 10);
            this.UsePrimeTimeSpecialFontSize = false;
            this.PrimeTimeSpecialFontSize = 8;
            this.WeekPrimeTimeStart = new DateTime(1, 1, 1, 20, 0, 0);
            this.WeekPrimeTimeEnd = new DateTime(1, 1, 1, 23, 0, 0);
            this.SundayPrimeTimeStart = new DateTime(1, 1, 1, 20, 0, 0);
            this.SundayPrimeTimeEnd = new DateTime(1, 1, 1, 23, 0, 0);
            this.ShowHouseNumber = false;
        }

        public string Serialize()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(@"<HeaderFont>" + this.HeaderFont.Serialize() + @"</HeaderFont>");
            result.AppendLine(@"<FooterFont>" + this.FooterFont.Serialize() + @"</FooterFont>");
            result.AppendLine(@"<BodyFont>" + this.BodyFont.Serialize() + @"</BodyFont>");
            result.AppendLine(@"<UsePrimeTimeSpecialFontSize>" + this.UsePrimeTimeSpecialFontSize.ToString() + @"</UsePrimeTimeSpecialFontSize>");
            result.AppendLine(@"<PrimeTimeSpecialFontSize>" + this.PrimeTimeSpecialFontSize.ToString() + @"</PrimeTimeSpecialFontSize>");
            result.AppendLine(@"<WeekPrimeTimeStart>" + this.WeekPrimeTimeStart.ToString() + @"</WeekPrimeTimeStart>");
            result.AppendLine(@"<WeekPrimeTimeEnd>" + this.WeekPrimeTimeEnd.ToString() + @"</WeekPrimeTimeEnd>");
            result.AppendLine(@"<SundayPrimeTimeStart>" + this.SundayPrimeTimeStart.ToString() + @"</SundayPrimeTimeStart>");
            result.AppendLine(@"<SundayPrimeTimeEnd>" + this.SundayPrimeTimeEnd.ToString() + @"</SundayPrimeTimeEnd>");
            result.AppendLine(@"<ShowHouseNumber>" + this.ShowHouseNumber.ToString() + @"</ShowHouseNumber>");
            return result.ToString();
        }

        public void Deserialize(XmlNode node)
        {
            int tempInt;
            bool tempBool;
            DateTime tempDate;

            foreach (XmlNode childNode in node.ChildNodes)
            {
                switch (childNode.Name)
                {
                    case "HeaderFont":
                        this.HeaderFont.Deserialize(childNode);
                        break;
                    case "FooterFont":
                        this.FooterFont.Deserialize(childNode);
                        break;
                    case "BodyFont":
                        this.BodyFont.Deserialize(childNode);
                        break;
                    case "UsePrimeTimeSpecialFontSize":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.UsePrimeTimeSpecialFontSize = tempBool;
                        break;
                    case "PrimeTimeSpecialFontSize":
                        if (int.TryParse(childNode.InnerText, out tempInt))
                            this.PrimeTimeSpecialFontSize = tempInt;
                        break;
                    case "WeekPrimeTimeStart":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.WeekPrimeTimeStart = tempDate;
                        break;
                    case "WeekPrimeTimeEnd":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.WeekPrimeTimeEnd = tempDate;
                        break;
                    case "SundayPrimeTimeStart":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.SundayPrimeTimeStart = tempDate;
                        break;
                    case "SundayPrimeTimeEnd":
                        if (DateTime.TryParse(childNode.InnerText, out tempDate))
                            this.SundayPrimeTimeEnd = tempDate;
                        break;
                    case "ShowHouseNumber":
                        if (bool.TryParse(childNode.InnerText, out tempBool))
                            this.ShowHouseNumber = tempBool;
                        break;
                }
            }
        }
    }
}
