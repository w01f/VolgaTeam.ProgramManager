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
        public List<CoreObjects.OutputFont> HeaderFonts { get; private set; }
        public List<CoreObjects.OutputFont> FooterFonts { get; private set; }
        public List<CoreObjects.OutputFont> BodyFonts { get; private set; }

        private ListManager()
        {
            this.FCC = new List<string>();
            this.Type = new List<string>();

            this.HeaderFonts = new List<CoreObjects.OutputFont>();
            this.HeaderFonts.Add(new CoreObjects.OutputFont("Arial", 12, true));
            this.HeaderFonts.Add(new CoreObjects.OutputFont("Verdana", 12, true));
            this.HeaderFonts.Add(new CoreObjects.OutputFont("Calibri", 12, true));
            this.HeaderFonts.Add(new CoreObjects.OutputFont("Trebuchet MS", 12, true));

            this.FooterFonts = new List<CoreObjects.OutputFont>();
            this.FooterFonts.Add(new CoreObjects.OutputFont("Arial", 11));
            this.FooterFonts.Add(new CoreObjects.OutputFont("Verdana", 11));
            this.FooterFonts.Add(new CoreObjects.OutputFont("Calibri", 11));
            this.FooterFonts.Add(new CoreObjects.OutputFont("Trebuchet MS", 11));

            this.BodyFonts = new List<CoreObjects.OutputFont>();
            this.BodyFonts.Add(new CoreObjects.OutputFont("Arial", 8));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Arial", 9));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Arial", 10));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Verdana", 8));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Calibri", 8));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Trebuchet MS", 8));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Verdana", 9));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Calibri", 9));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Trebuchet MS", 9));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Verdana", 10));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Calibri", 10));
            this.BodyFonts.Add(new CoreObjects.OutputFont("Trebuchet MS", 10));
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
