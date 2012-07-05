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
        public string DataRootsPath { get; private set; }
        private string _applicationSettingsFile = string.Empty;
        private string _manifestFile = string.Empty;
        public string LogFilePath { get; private set; }
        public string IconFilePath { get; private set; }
        public string StationsRootPath { get; private set; }
        public string OutputRootPath { get; private set; }
        public string OutputCache { get; private set; }
        #endregion

        #region Local Settings
        public string ServerName { get; set; }
        public string ApplicationName { get; set; }
        public string SelectedStation { get; set; }
        public BrowseType BrowseType { get; set; }
        public bool ShowInfo { get; set; }
        public bool OfflineMode { get; set; }
        public bool AlwaysDownload { get; set; }
        public bool AlwaysCancelDownload { get; set; }
        public OutputSettings OutputSettings { get; private set; }
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
            this.ApplicationRootsPath = Path.GetDirectoryName(typeof(SettingsManager).Assembly.Location);
            this.DataRootsPath = this.ApplicationRootsPath;
            _applicationSettingsFile = Path.Combine(this.ApplicationRootsPath, "LocalSettings.xml");
            _manifestFile = Path.Combine(this.ApplicationRootsPath, "manifest.xml");
            this.LogFilePath = Path.Combine(this.ApplicationRootsPath, "ApplicatonLog.xml");
            this.IconFilePath = Path.Combine(this.ApplicationRootsPath, "icon.ico");
            this.OutputCache = Path.Combine(this.ApplicationRootsPath, "Output Cache");

            this.OfflineMode = true;
            this.ServerName = "127.0.0.1";
            this.ApplicationName = "Program Manager";
            this.ShowInfo = true;
            this.OutputSettings = new ConfigurationClasses.OutputSettings();

            LoadApplicationSettings();
            LoadManifest();

            this.StationsRootPath = Path.Combine(this.DataRootsPath, "Stations");
            this.OutputRootPath = Path.Combine(this.DataRootsPath, "Output Templates");
            if (!Directory.Exists(this.StationsRootPath))
                Directory.CreateDirectory(this.StationsRootPath);

            CoreObjects.ConfigurationClasses.SettingsManager.Instance.StationsRootPath = this.StationsRootPath;
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

                node = document.SelectSingleNode(@"/LocalSettings/AlwaysDownload");
                if (node != null)
                {
                    if (bool.TryParse(node.InnerText, out tempBool))
                        this.AlwaysDownload = tempBool;
                }

                node = document.SelectSingleNode(@"/LocalSettings/AlwaysCancelDownload");
                if (node != null)
                {
                    if (bool.TryParse(node.InnerText, out tempBool))
                        this.AlwaysCancelDownload = tempBool;
                }

                node = document.SelectSingleNode(@"/LocalSettings/OutputSettings");
                if (node != null)
                {
                    this.OutputSettings.Deserialize(node);
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
            xml.AppendLine(@"<AlwaysDownload>" + this.AlwaysDownload.ToString() + @"</AlwaysDownload>");
            xml.AppendLine(@"<AlwaysCancelDownload>" + this.AlwaysCancelDownload.ToString() + @"</AlwaysCancelDownload>");
            xml.AppendLine(@"<OutputSettings>" + this.OutputSettings.Serialize() + @"</OutputSettings>");
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

                XmlNode node = document.SelectSingleNode(@"/Manifest/ServerName");
                if (node != null)
                {
                    this.ServerName = node.InnerText;
                }

                node = document.SelectSingleNode(@"/Manifest/DataLocation");
                if (node != null)
                {
                    this.DataRootsPath = node.InnerText;
                }

                node = document.SelectSingleNode(@"/Manifest/Title");
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
