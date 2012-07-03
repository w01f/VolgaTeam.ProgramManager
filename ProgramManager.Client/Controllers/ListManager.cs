using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace ProgramManager.Client.Controllers
{
    public class ListManager
    {
        private const string SourceFileName = @"dropdowns.xml";

        private static ListManager _instance = new ListManager();

        public List<string> FCC { get; private set; }
        public List<string> Type { get; private set; }

        private ListManager()
        {
            this.FCC = new List<string>();
            this.Type = new List<string>();
        }

        public static ListManager Instance
        {
            get
            {
                return _instance;
            }
        }

        public void LoadLists()
        {
            this.FCC.Clear();
            this.Type.Clear();
            string listPath = Path.Combine(ConfigurationClasses.SettingsManager.Instance.StationsRootPath, SourceFileName);
            if (File.Exists(listPath))
            {
                XmlDocument document = new XmlDocument();
                document.Load(listPath);

                XmlNode node = document.SelectSingleNode(@"/dropdowns");
                if (node != null)
                {
                    foreach (XmlNode childeNode in node.ChildNodes)
                    {
                        switch (childeNode.Name)
                        {
                            case "EI":
                                foreach (XmlAttribute attribute in childeNode.Attributes)
                                {
                                    switch (attribute.Name)
                                    {
                                        case "Value":
                                            if (!string.IsNullOrEmpty(attribute.Value) && !this.FCC.Contains(attribute.Value))
                                                this.FCC.Add(attribute.Value);
                                            break;
                                    }
                                }
                                break;
                            case "Type":
                                foreach (XmlAttribute attribute in childeNode.Attributes)
                                    switch (attribute.Name)
                                    {
                                        case "Value":
                                            if (!string.IsNullOrEmpty(attribute.Value) && !this.Type.Contains(attribute.Value))
                                                this.Type.Add(attribute.Value);
                                            break;
                                    }
                                break;
                        }
                    }
                }
            }
        }

        public void LoadRemoteLists()
        {
            if (this.FCC.Count == 0)
                this.FCC.AddRange(ServiceManager.GetFCCList());
            if (this.Type.Count == 0)
                this.Type.AddRange(ServiceManager.GetTypeList());
            SaveLists();
        }

        public void SaveLists()
        {
            StringBuilder xml = new StringBuilder();

            xml.AppendLine(@"<dropdowns>");

            foreach (string fccValue in this.FCC)
                xml.AppendLine("<EI Value =\"" + fccValue.Replace(@"&", "&#38;").Replace("\"", "&quot;") + "\"/>");

            foreach (string typeValue in this.Type)
                xml.AppendLine("<Type Value =\"" + typeValue.Replace(@"&", "&#38;").Replace("\"", "&quot;") + "\"/>");


            xml.AppendLine(@"</dropdowns>");

            string listPath = Path.Combine(ConfigurationClasses.SettingsManager.Instance.StationsRootPath, SourceFileName);
            using (StreamWriter sw = new StreamWriter(listPath, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
                sw.Close();
            }
        }
    }
}
