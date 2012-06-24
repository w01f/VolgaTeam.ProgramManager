using System;
using System.Collections.Generic;
using System.IO;

namespace ProgramManager.BusinessClasses
{
    public class StationManager
    {
        private static StationManager _instance = null;

        public List<Station> Stations { get; private set; }

        public static StationManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new StationManager();
                return _instance;
            }
        }

        private StationManager()
        {
            this.Stations = new List<Station>();
        }

        public void LoadStations()
        {
            this.Stations.Clear();
            if (Directory.Exists(ConfigurationClasses.SettingsManager.Instance.StationsRootPath))
            {
                DirectoryInfo rootFolder = new DirectoryInfo(ConfigurationClasses.SettingsManager.Instance.StationsRootPath);
                foreach (DirectoryInfo stationFolder in rootFolder.GetDirectories())
                {
                    Station station = new Station(stationFolder);
                    this.Stations.Add(station);
                    System.Windows.Forms.Application.DoEvents();
                }
            }
        }
    }
}
