using System;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProgramManager.CoreObjects
{
    public class ApplicationLog
    {
        private string _logFilePath = string.Empty;

        public List<LogRecord> Records { get; private set; }

        public ApplicationLog(string logFilePath)
        {
            _logFilePath = logFilePath;
            this.Records = new List<LogRecord>();
            Load();
        }

        private void Load()
        {
            this.Records.Clear();
            if (File.Exists(_logFilePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(_logFilePath);

                XmlNode node = document.SelectSingleNode(@"/ApplicationLog");
                if (node != null)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name.Equals("Record"))
                        {
                            LogRecord record = new LogRecord();
                            record.Deserialize(childNode);
                            this.Records.Add(record);
                        }
                    }
                }
            }
        }

        public void Save()
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine(@"<ApplicationLog>");

            DateTime borderDate = DateTime.Now.AddDays(-7);
            foreach (LogRecord record in this.Records.Where(x => x.TimeStamp > borderDate))
                xml.AppendLine(@"<Record>" + record.Serialize() + @"</Record>");
            xml.AppendLine(@"</ApplicationLog>");

            using (StreamWriter sw = new StreamWriter(_logFilePath, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
                sw.Close();
            }
        }
    }

    public class LogRecord
    {
        public DateTime TimeStamp { get; set; }
        public string Message { get; set; }
        public string StackTrace { get; set; }

        public LogRecord()
        {
            this.TimeStamp = DateTime.Now;
        }

        public LogRecord(string Message)
            : this()
        {
            this.Message = Message;
        }

        public LogRecord(System.Exception ex)
            : this(ex.Message)
        {
            this.StackTrace = ex.StackTrace;
        }

        public override string ToString()
        {
            return this.Message + this.StackTrace;
        }

        public string Serialize()
        {
            StringBuilder result = new StringBuilder();

            result.AppendLine(@"<TimeStamp>" + this.TimeStamp.ToString() + @"</TimeStamp>");
            if (!string.IsNullOrEmpty(this.Message))
                result.AppendLine(@"<Message>" + this.Message.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</Message>");
            if (!string.IsNullOrEmpty(this.StackTrace))
                result.AppendLine(@"<StackTrace>" + this.StackTrace.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</StackTrace>");
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
                            this.TimeStamp = tempDate;
                        break;
                    case "Message":
                        this.Message = childNode.InnerText;
                        break;
                    case "StackTrace":
                        this.StackTrace = childNode.InnerText;
                        break;
                }
            }
        }
    }
}
