using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace ProgramManager.BusinessClasses
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
            LoadLists();
        }

        public static ListManager Instance
        {
            get
            {
                return _instance;
            }
        }


        private void LoadLists()
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
    }
}
