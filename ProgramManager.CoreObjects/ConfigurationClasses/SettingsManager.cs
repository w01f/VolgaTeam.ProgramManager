using System;
using System.IO;
using System.Text;
using System.Xml;

namespace ProgramManager.CoreObjects.ConfigurationClasses
{
    class SettingsManager
    {
        private static SettingsManager _instance = new SettingsManager();

        #region Path Section
        public string ApplicationRootsPath { get; private set; }
        public string StationsRootPath { get; private set; }
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
            this.StationsRootPath = Path.Combine(this.ApplicationRootsPath, "Stations");
            #endregion
        }
    }
}
