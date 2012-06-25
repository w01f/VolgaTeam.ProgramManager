using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ProgramManager.ConfigurationClasses
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
        public string StationsRootPath { get; private set; }
        #endregion

        #region Local Settings
        public string SelectedStation { get; set; }
        public BrowseType BrowseType { get; set; }
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
            this.StationsRootPath = Path.Combine(this.ApplicationRootsPath, "Stations");
            #endregion

            LoadApplicationSettings();
        }

        private void LoadApplicationSettings()
        {
            int tempInt;
            this.SelectedStation = string.Empty;

            string settingsFilePath = _applicationSettingsFile;
            if (File.Exists(settingsFilePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(settingsFilePath);

                XmlNode node = document.SelectSingleNode(@"/LocalSettings/SelectedStation");
                if (node != null)
                {
                    this.SelectedStation = node.InnerText;
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
            xml.AppendLine(@"<BrowseType>" + ((int)this.BrowseType).ToString() + @"</BrowseType>");
            xml.AppendLine(@"</LocalSettings>");

            using (StreamWriter sw = new StreamWriter(_applicationSettingsFile, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
            }
        }
    }
}
