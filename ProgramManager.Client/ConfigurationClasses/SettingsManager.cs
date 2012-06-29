using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ProgramManager.Client.ConfigurationClasses
{
    public enum BrowseType
    {
        Day = 0,
        Week,
        Month
    }

    class SettingsManager
    {
        private static SettingsManager _instance = new SettingsManager();

        #region Path Section
        public string ApplicationRootsPath { get; private set; }
        private string _applicationSettingsFile = string.Empty;
        private string _manifestFile = string.Empty;
        public string IconFilePath { get; private set; }
        public string StationsRootPath { get; private set; }
        #endregion

        #region Local Settings
        public string ApplicationName { get; set; }
        public string SelectedStation { get; set; }
        public BrowseType BrowseType { get; set; }
        public bool ShowInfo { get; set; }
        #endregion

        public static SettingsManager Instance
        {
            get
            {
                return _instance;
            }
        }

        private SettingsManager()
        {
            #region Path Section
            this.ApplicationRootsPath = Path.GetDirectoryName(typeof(SettingsManager).Assembly.Location);
            _applicationSettingsFile = Path.Combine(this.ApplicationRootsPath, "LocalSettings.xml");
            _manifestFile = Path.Combine(this.ApplicationRootsPath, "manifest.xml");
            this.StationsRootPath = Path.Combine(this.ApplicationRootsPath, "Stations");
            this.IconFilePath = Path.Combine(this.ApplicationRootsPath, "icon.ico");
            #endregion

            this.ApplicationName = "Program Manager";

            this.ShowInfo = true;

            LoadApplicationSettings();
            LoadManifest();
        }

        private void LoadApplicationSettings()
        {
            int tempInt;
            bool tempBool;
            this.SelectedStation = string.Empty;

            string xmlFilePath = _applicationSettingsFile;
            if (File.Exists(xmlFilePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(xmlFilePath);

                XmlNode node = document.SelectSingleNode(@"/LocalSettings/SelectedStation");
                if (node != null)
                {
                    this.SelectedStation = node.InnerText;
                }

                node = document.SelectSingleNode(@"/LocalSettings/ShowInfo");
                if (node != null)
                {
                    if (bool.TryParse(node.InnerText, out tempBool))
                        this.ShowInfo = tempBool;
                }

                node = document.SelectSingleNode(@"/LocalSettings/BrowseType");
                if (node != null)
                {
                    if (int.TryParse(node.InnerText, out tempInt))
                        this.BrowseType = (BrowseType)tempInt;
                }
            }
        }

        public void SaveApplicationSettings()
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<LocalSettings>");
            xml.AppendLine(@"<SelectedStation>" + this.SelectedStation.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</SelectedStation>");
            xml.AppendLine(@"<ShowInfo>" + this.ShowInfo.ToString() + @"</ShowInfo>");
            xml.AppendLine(@"<BrowseType>" + ((int)this.BrowseType).ToString() + @"</BrowseType>");
            xml.AppendLine(@"</LocalSettings>");

            using (StreamWriter sw = new StreamWriter(_applicationSettingsFile, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
            }
        }

        private void LoadManifest()
        {
            string xmlFilePath = _manifestFile;
            if (File.Exists(xmlFilePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(xmlFilePath);

                XmlNode node = document.SelectSingleNode(@"/Manifest/Title");
                if (node != null)
                {
                    this.ApplicationName = node.InnerText;
                }

                node = document.SelectSingleNode(@"/Manifest/Icon");
                if (node != null)
                {
                    this.IconFilePath = Path.Combine(this.ApplicationRootsPath, node.InnerText);
                }
            }
        }
    }
}
