using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;

namespace ProgramManager.Service
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class StationService : IStationsService
    {
        private List<CoreObjects.Station> _stations = new List<CoreObjects.Station>();

        public StationService()
        {
            LoadStations();
        }

        private void LoadStations(bool forse = false)
        {
            if (_stations.Count == 0 || forse)
            {
                _stations.Clear();
                if (Directory.Exists(ConfigurationClasses.SettingsManager.Instance.StationsRootPath))
                {
                    DirectoryInfo rootFolder = new DirectoryInfo(ConfigurationClasses.SettingsManager.Instance.StationsRootPath);
                    foreach (DirectoryInfo stationFolder in rootFolder.GetDirectories())
                    {
                        CoreObjects.Station station = new CoreObjects.Station(stationFolder);
                        station.LoadExistedDays(DateTime.MinValue, DateTime.MaxValue);
                        _stations.Add(station);
                    }
                }
            }
        }

        #region IStationsService Members
        public string[] GetStationList()
        {
            return _stations.Select(x => x.Name).ToArray();
        }
        public string[] GetFCCList()
        {
            return ListManager.Instance.FCC.ToArray();
        }
        public string[] GetTypeList()
        {
            return ListManager.Instance.Type.ToArray();
        }

        public CoreObjects.StationInformation GetStationInfo(string stationName)
        {
            CoreObjects.Station station = _stations.Where(x => x.Name.Equals(stationName)).FirstOrDefault();
            if (station != null)
                return station.GetStationInfo();
            else
                return null;
        }

        public void UploadStation(CoreObjects.Station station)
        {
            LoadStations();
            CoreObjects.Station existedStation = _stations.Where(x => x.Name.Equals(station.Name)).FirstOrDefault();
            if (existedStation != null)
                _stations.Remove(existedStation);
            station.SaveProgramActivities();
            station.SavePrograms();
            station.SaveProgramNames();
            station.SaveLogo();
            LoadStations(true);
        }

        public CoreObjects.Station DownloadStation(string stationName)
        {
            return _stations.Where(x => x.Name.Equals(stationName)).FirstOrDefault();
        }
        #endregion
    }
}
