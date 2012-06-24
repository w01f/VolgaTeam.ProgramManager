using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ProgramManager.ConfigurationClasses
{
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
            }
        }

        public void SaveApplicationSettings()
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<LocalSettings>");
            xml.AppendLine(@"<SelectedStation>" + this.SelectedStation.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</SelectedStation>");
            xml.AppendLine(@"</LocalSettings>");

            using (StreamWriter sw = new StreamWriter(_applicationSettingsFile, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
            }
        }
    }
}
