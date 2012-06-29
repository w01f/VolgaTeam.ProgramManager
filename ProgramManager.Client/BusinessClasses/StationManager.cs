using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ProgramManager.Client.BusinessClasses
{
    public class StationManager
    {
        private static StationManager _instance = null;

        private List<CoreObjects.Station> _stations = new List<CoreObjects.Station>();

        public CoreObjects.Station SelectedStation { get; private set; }
        public CoreObjects.Day SelectedDay { get; private set; }

        public event EventHandler<EventArgs> StationChanged;

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
        }

        public void LoadStations()
        {
            _stations.Clear();
            if (Directory.Exists(ConfigurationClasses.SettingsManager.Instance.StationsRootPath))
            {
                DirectoryInfo rootFolder = new DirectoryInfo(ConfigurationClasses.SettingsManager.Instance.StationsRootPath);
                foreach (DirectoryInfo stationFolder in rootFolder.GetDirectories())
                {
                    CoreObjects.Station station = new CoreObjects.Station(stationFolder);
                    _stations.Add(station);
                    System.Windows.Forms.Application.DoEvents();
                }
            }
        }

        public string[] GetStationList()
        {
            return _stations.Select(x => x.Name).ToArray();
        }

        public string[] GetProgramList()
        {
            if (this.SelectedStation != null)
                return this.SelectedStation.ProgramNames.ToArray();
            else
                return new string[] { };
        }

        public void LoadStation(object sender, string selectedStationName)
        {
            this.SelectedStation = _stations.Where(x => x.Name.Equals(selectedStationName)).FirstOrDefault();
            if (this.SelectedStation != null)
            {
                ConfigurationClasses.SettingsManager.Instance.SelectedStation = this.SelectedStation.Name;
                ConfigurationClasses.SettingsManager.Instance.SaveApplicationSettings();
                if (this.StationChanged != null)
                    this.StationChanged(sender, new EventArgs());
            }
        }

        public void LoadDay(DateTime day)
        {
            if (this.SelectedStation != null)
                this.SelectedDay = this.SelectedStation.GetDay(day);
        }

        public void SaveDay()
        {
            if (this.SelectedDay != null)
                this.SelectedDay.Save();
        }

    }
}
