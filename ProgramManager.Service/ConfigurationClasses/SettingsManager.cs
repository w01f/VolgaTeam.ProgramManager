using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ProgramManager.Service.ConfigurationClasses
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
            string xmlFilePath = _applicationSettingsFile;
            if (File.Exists(xmlFilePath))
            {
                XmlDocument document = new XmlDocument();

                document.Load(xmlFilePath);

                //XmlNode node = document.SelectSingleNode(@"/LocalSettings/SelectedStation");
                //if (node != null)
                //{
                //    this.SelectedStation = node.InnerText;
                //}

                //node = document.SelectSingleNode(@"/LocalSettings/ShowInfo");
                //if (node != null)
                //{
                //    if (bool.TryParse(node.InnerText, out tempBool))
                //        this.ShowInfo = tempBool;
                //}
            }
        }

        public void SaveApplicationSettings()
        {
            StringBuilder xml = new StringBuilder();
            xml.AppendLine("<LocalSettings>");
            //xml.AppendLine(@"<SelectedStation>" + this.SelectedStation.Replace(@"&", "&#38;").Replace("\"", "&quot;") + @"</SelectedStation>");
            //xml.AppendLine(@"<ShowInfo>" + this.ShowInfo.ToString() + @"</ShowInfo>");
            xml.AppendLine(@"</LocalSettings>");

            using (StreamWriter sw = new StreamWriter(_applicationSettingsFile, false))
            {
                sw.Write(xml.ToString());
                sw.Flush();
            }
        }
    }
}
