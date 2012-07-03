using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager.Client.Controllers
{
    public class StationManager
    {
        private static StationManager _instance = null;

        private List<CoreObjects.Station> _stations = new List<CoreObjects.Station>();

        public CoreObjects.Station SelectedStation { get; private set; }
        public CoreObjects.Day SelectedDay { get; private set; }

        public event EventHandler<EventArgs> StationChanged;

        public bool StationsLoaded
        {
            get
            {
                return _stations.Count > 0;
            }
        }

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

        private void LoadStations()
        {
            _stations.Clear();
            if (Directory.Exists(ConfigurationClasses.SettingsManager.Instance.StationsRootPath))
            {
                DirectoryInfo rootFolder = new DirectoryInfo(ConfigurationClasses.SettingsManager.Instance.StationsRootPath);
                foreach (DirectoryInfo stationFolder in rootFolder.GetDirectories())
                {
                    CoreObjects.Station station = new CoreObjects.Station(stationFolder.Name);

                    if (!ConfigurationClasses.SettingsManager.Instance.AlwaysCancelDownload)
                    {
                        CoreObjects.StationInformation stationInfo = ServiceManager.GetStationInfo(station.Name);
                        if (stationInfo != null)
                            station.NeedToUpdate = station.LastLoaded < stationInfo.LastModified;
                    }

                    _stations.Add(station);
                }
            }
        }

        private void DownloadStations(string[] selectedStations)
        {
            foreach (string stationName in selectedStations)
            {
                if (selectedStations.Contains(stationName))
                {
                    CoreObjects.Station station = ServiceManager.DownloadStation(stationName);
                    if (station != null)
                    {
                        station.SaveProgramActivities();
                        station.SaveProgramNames();
                        station.SavePrograms();
                        station.SaveLogo();

                        station.LastLoaded = DateTime.Now;
                        station.SaveStationMetaData();

                        CoreObjects.Station existedStation = _stations.Where(x => x.Name.Equals(station.Name)).FirstOrDefault();
                        if (existedStation != null)
                            _stations.Remove(existedStation);

                        _stations.Add(station);
                    }
                }
            }
        }

        public void LoadData(bool forceRemote = false)
        {
            using (ToolForms.FormProgress form = new ToolForms.FormProgress())
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(delegate()
                {
                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                    {
                        form.laProgress.Text = "Loading Programs...";
                        form.TopMost = true;
                        form.Show();
                        Application.DoEvents();
                    });

                    foreach (CoreObjects.Station station in _stations)
                        station.ReleaseResources();
                    _stations.Clear();
                    ListManager.Instance.FCC.Clear();
                    ListManager.Instance.Type.Clear();

                    if (forceRemote)
                    {
                        AppManager.Instance.DeleteFolder(new DirectoryInfo(ConfigurationClasses.SettingsManager.Instance.StationsRootPath));
                        if (!Directory.Exists(ConfigurationClasses.SettingsManager.Instance.StationsRootPath))
                            Directory.CreateDirectory(ConfigurationClasses.SettingsManager.Instance.StationsRootPath);
                    }
                    else
                    {
                        LoadStations();
                        ListManager.Instance.LoadLists();
                    }

                    if (ListManager.Instance.FCC.Count == 0 || ListManager.Instance.Type.Count == 0)
                        ListManager.Instance.LoadRemoteLists();

                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                    {
                        form.Hide();
                        Application.DoEvents();
                    });
                    if (!this.StationsLoaded)
                    {
                        FormMain.Instance.Invoke((MethodInvoker)delegate()
                        {
                            form.laProgress.Text = "Connecting to the server...";
                            form.TopMost = true;
                            form.Show();
                            Application.DoEvents();
                        });

                        string[] availableStations = ServiceManager.GetStationsList();
                        string[] selectedStations = new string[] { };

                        FormMain.Instance.Invoke((MethodInvoker)delegate()
                        {
                            form.Hide();
                            Application.DoEvents();
                        });

                        if (availableStations.Length > 0)
                        {
                            FormMain.Instance.Invoke((MethodInvoker)delegate()
                            {
                                using (ToolForms.FormSelectStations selectForm = new ToolForms.FormSelectStations())
                                {
                                    selectForm.AvailableStations.AddRange(availableStations);
                                    selectForm.ActionName = "Download";
                                    if (selectForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                    {
                                        selectedStations = selectForm.SelectedStations;
                                    }
                                }

                                form.laProgress.Text = "Downloading Selected Stations...";
                                form.TopMost = true;
                                form.Show();
                                Application.DoEvents();
                            });

                            DownloadStations(selectedStations);

                            FormMain.Instance.Invoke((MethodInvoker)delegate()
                            {
                                form.Hide();
                                Application.DoEvents();
                            });
                        }
                        else
                        {
                            FormMain.Instance.Invoke((MethodInvoker)delegate()
                            {
                                AppManager.Instance.ShowWarning("Server is unavailable");
                                Application.DoEvents();
                            });
                        }
                    }
                    else if (!forceRemote)
                    {
                        List<string> stationsForUpdate = new List<string>();
                        stationsForUpdate.AddRange(_stations.Where(x => x.NeedToUpdate).Select(x => x.Name));
                        if (stationsForUpdate.Count > 0)
                        {
                            if (ConfigurationClasses.SettingsManager.Instance.AlwaysDownload)
                            {
                                FormMain.Instance.Invoke((MethodInvoker)delegate()
                                {
                                    form.laProgress.Text = "Downloading Stations...";
                                    form.TopMost = true;
                                    form.Show();
                                    Application.DoEvents();
                                });

                                DownloadStations(stationsForUpdate.ToArray());

                                FormMain.Instance.Invoke((MethodInvoker)delegate()
                                {
                                    form.Hide();
                                    Application.DoEvents();
                                });
                            }
                            else if (!ConfigurationClasses.SettingsManager.Instance.AlwaysCancelDownload)
                            {
                                DialogResult questionResult = DialogResult.Cancel;
                                FormMain.Instance.Invoke((MethodInvoker)delegate()
                                {
                                    using (ToolForms.FormDownloadWarning downloadwarning = new ToolForms.FormDownloadWarning())
                                    {
                                        questionResult = downloadwarning.ShowDialog();
                                    }
                                });

                                if (questionResult == DialogResult.OK)
                                {
                                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                                    {
                                        form.laProgress.Text = "Downloading Stations...";
                                        form.TopMost = true;
                                        form.Show();
                                        Application.DoEvents();
                                    });

                                    DownloadStations(stationsForUpdate.ToArray());

                                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                                    {
                                        form.Hide();
                                        Application.DoEvents();
                                    });
                                }
                            }
                        }
                    }
                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                    {
                        FormMain.Instance.TabSchedule.LoadPage();
                        FormMain.Instance.TabSearch.LoadPage();
                    });
                }));
                thread.Start();

                while (thread.IsAlive)
                    Application.DoEvents();

                form.Close();
            }
        }

        public void UploadData()
        {
            using (ToolForms.FormProgress form = new ToolForms.FormProgress())
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(delegate()
                {
                    List<string> selectedStations = new List<string>();

                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                    {
                        using (ToolForms.FormSelectStations selectForm = new ToolForms.FormSelectStations())
                        {
                            selectForm.AvailableStations.AddRange(GetStationList());
                            selectForm.ActionName = "Upload";
                            selectForm.DefaultSelectedStation = this.SelectedStation.Name;
                            if (selectForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                selectedStations.AddRange(selectForm.SelectedStations);
                        }
                        Application.DoEvents();
                    });

                    bool uploadSuccessfully = selectedStations.Count > 0;
                    bool somethingDownloaded = false;
                    foreach (string stationName in selectedStations)
                    {
                        CoreObjects.Station station = _stations.Where(x => x.Name.Equals(stationName)).FirstOrDefault();
                        if (station != null)
                        {
                            FormMain.Instance.Invoke((MethodInvoker)delegate()
                            {
                                form.laProgress.Text = "Getting station information...";
                                form.TopMost = true;
                                form.Show();
                                Application.DoEvents();
                            });


                            CoreObjects.StationInformation stationInformation = ServiceManager.GetStationInfo(station.Name);

                            FormMain.Instance.Invoke((MethodInvoker)delegate()
                            {
                                form.Hide();
                                Application.DoEvents();
                            });

                            DialogResult result = DialogResult.OK;
                            if (stationInformation != null)
                            {
                                if (stationInformation.LastModified > station.LastLoaded)
                                {
                                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                                    {
                                        using (ToolForms.FormUploadWarning warningForm = new ToolForms.FormUploadWarning())
                                        {
                                            result = warningForm.ShowDialog();
                                        }
                                        Application.DoEvents();
                                    });
                                }
                            }
                            if (result == DialogResult.OK)
                            {
                                FormMain.Instance.Invoke((MethodInvoker)delegate()
                                {
                                    form.laProgress.Text = "Uploading station...";
                                    form.TopMost = true;
                                    form.Show();
                                    Application.DoEvents();
                                });

                                uploadSuccessfully &= ServiceManager.UploadStation(station);

                                FormMain.Instance.Invoke((MethodInvoker)delegate()
                                {
                                    form.Hide();
                                    Application.DoEvents();
                                });
                            }
                            else if (result == DialogResult.Cancel)
                            {
                                FormMain.Instance.Invoke((MethodInvoker)delegate()
                                {
                                    form.laProgress.Text = "Downloading station...";
                                    form.TopMost = true;
                                    form.Show();
                                    Application.DoEvents();
                                });

                                DownloadStations(new string[] { stationName });

                                somethingDownloaded = true;

                                FormMain.Instance.Invoke((MethodInvoker)delegate()
                                {
                                    form.Hide();
                                    Application.DoEvents();
                                });
                            }
                        }
                    }
                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                    {
                        if (somethingDownloaded)
                            LoadStation(null, this.SelectedStation.Name);

                        Application.DoEvents();

                        if (uploadSuccessfully)
                        {
                            AppManager.Instance.ShowInformation("Operation completed successfully");
                        }
                        else
                            AppManager.Instance.ShowWarning("Operation was not complited");
                    });
                }));
                thread.Start();

                while (thread.IsAlive)
                    Application.DoEvents();

                form.Close();
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

        public void ReportWeekSchedule(string stationName, CoreObjects.Week[] weeks, bool convertToPDF, bool landscape)
        {
            using (ToolForms.FormProgress form = new ToolForms.FormProgress())
            {
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(delegate()
                {
                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                    {
                        form.laProgress.Text = "Generating output...";
                        form.TopMost = true;
                        form.Show();
                        Application.DoEvents();
                    });

                    CoreObjects.Station station = _stations.Where(x => x.Name.Equals(stationName)).FirstOrDefault();
                    if (station != null)
                    {
                        InteropClasses.ExcelHelper excelHelper = new InteropClasses.ExcelHelper();

                        if (!Directory.Exists(ConfigurationClasses.SettingsManager.Instance.OutputCache))
                            Directory.CreateDirectory(ConfigurationClasses.SettingsManager.Instance.OutputCache);

                        string destinationPath = Path.Combine(ConfigurationClasses.SettingsManager.Instance.OutputCache, string.Format("{0}.{1}", new string[] { DateTime.Now.ToString("MMddyy-hhmmtt"), convertToPDF ? "pdf" : "xls" }));

                        List<CoreObjects.Day[]> daysByWeeks = new List<CoreObjects.Day[]>();
                        foreach (CoreObjects.Week week in weeks)
                            daysByWeeks.Add(station.GetDays(week.DateStart, week.DateEnd));

                        excelHelper.ReportWeekSchedule(daysByWeeks.ToArray(), destinationPath, convertToPDF, landscape);

                        if (File.Exists(destinationPath))
                            Process.Start(destinationPath);
                    }

                    FormMain.Instance.Invoke((MethodInvoker)delegate()
                    {
                        form.Hide();
                        Application.DoEvents();
                    });

                }));
                thread.Start();

                while (thread.IsAlive)
                    Application.DoEvents();

                form.Close();
            }
        }
    }
}
