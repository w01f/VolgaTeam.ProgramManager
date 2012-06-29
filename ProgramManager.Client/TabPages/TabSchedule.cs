﻿using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager.Client.TabPages
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class TabSchedule : UserControl
    {
        private bool _allowToSave = false;

        public bool DataNotSaved { get; set; }

        public TabSchedule()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            FormMain.Instance.SetClickEventHandler(this);

            repositoryItemTextEditProgram.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            repositoryItemTextEditProgram.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            repositoryItemTextEditProgram.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            repositoryItemTextEdit.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            repositoryItemTextEdit.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            repositoryItemTextEdit.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
        }

        #region Common Methods
        public bool AllowToLeaveControl
        {
            get
            {
                bool result = false;
                gridViewPrograms.CloseEditor();
                if (this.DataNotSaved)
                {
                    SavePage();
                    result = true;
                }
                else
                    result = true;
                return result;
            }
        }

        private void LoadStation()
        {
            BusinessClasses.StationManager.Instance.LoadStation(FormMain.Instance.comboBoxEditScheduleStation.EditValue != null ? FormMain.Instance.comboBoxEditScheduleStation.EditValue.ToString() : string.Empty);
            if (BusinessClasses.StationManager.Instance.SelectedStation != null)
            {
                FormMain.Instance.labelItemScheduleSationLogo.Image = BusinessClasses.StationManager.Instance.SelectedStation.Logo;
                FormMain.Instance.ribbonBarScheduleStation.RecalcLayout();
                FormMain.Instance.ribbonPanelSchedule.PerformLayout();
            }
        }

        private void LoadDay()
        {
            if (this.DataNotSaved)
                SavePage();
            BusinessClasses.StationManager.Instance.LoadDay(FormMain.Instance.dateEditScheduleDay.DateTime);
            _allowToSave = false;
            if (BusinessClasses.StationManager.Instance.SelectedDay != null)
                gridControlPrograms.DataSource = new BindingList<CoreObjects.Spot>(BusinessClasses.StationManager.Instance.SelectedDay.Spots);
            else
                gridControlPrograms.DataSource = null;
            _allowToSave = true;
        }

        public void LoadPage()
        {
            _allowToSave = false;

            FormMain.Instance.ribbonPanelSchedule.Enabled = true;
            FormMain.Instance.comboBoxEditScheduleStation.Properties.Items.Clear();
            FormMain.Instance.comboBoxEditScheduleStation.Properties.Items.AddRange(BusinessClasses.StationManager.Instance.GetStationList());
            if (FormMain.Instance.comboBoxEditScheduleStation.Properties.Items.Contains(ConfigurationClasses.SettingsManager.Instance.SelectedStation))
                FormMain.Instance.comboBoxEditScheduleStation.SelectedIndex = FormMain.Instance.comboBoxEditScheduleStation.Properties.Items.IndexOf(ConfigurationClasses.SettingsManager.Instance.SelectedStation);
            else if (FormMain.Instance.comboBoxEditScheduleStation.Properties.Items.Count > 0)
                FormMain.Instance.comboBoxEditScheduleStation.SelectedIndex = 0;
            else
                FormMain.Instance.ribbonPanelSchedule.Enabled = false;

            if (FormMain.Instance.dateEditScheduleDay.DateTime == DateTime.MinValue)
            {
                DateTime nowDate = DateTime.Now;
                FormMain.Instance.dateEditScheduleDay.DateTime = new DateTime(nowDate.Year, nowDate.Month, nowDate.Day);
            }

            FormMain.Instance.buttonItemScheduleInfo.Checked = ConfigurationClasses.SettingsManager.Instance.ShowInfo;
            gridViewPrograms.OptionsView.ShowPreview = ConfigurationClasses.SettingsManager.Instance.ShowInfo;

            switch (ConfigurationClasses.SettingsManager.Instance.BrowseType)
            {
                case ConfigurationClasses.BrowseType.Day:
                    buttonItemScheduleBrowseType_Click(FormMain.Instance.buttonItemScheduleBrowseDay, null);
                    break;
                case ConfigurationClasses.BrowseType.Week:
                    buttonItemScheduleBrowseType_Click(FormMain.Instance.buttonItemScheduleBrowseWeek, null);
                    break;
                case ConfigurationClasses.BrowseType.Month:
                    buttonItemScheduleBrowseType_Click(FormMain.Instance.buttonItemScheduleBrowseMonth, null);
                    break;
            }

            repositoryItemComboBoxType.Items.Clear();
            repositoryItemComboBoxType.Items.AddRange(BusinessClasses.ListManager.Instance.Type);
            repositoryItemComboBoxFCC.Items.Clear();
            repositoryItemComboBoxFCC.Items.AddRange(BusinessClasses.ListManager.Instance.FCC);

            _allowToSave = true;

            LoadStation();

            LoadDay();
        }

        public void SavePage()
        {
            BusinessClasses.StationManager.Instance.SaveDay();
        }
        #endregion

        #region Navigation Event Handlers
        public void dateEditScheduleDay_EditValueChanged(object sender, EventArgs e)
        {
            if (_allowToSave)
                LoadDay();
        }

        public void comboBoxEditScheduleStation_EditValueChanged(object sender, EventArgs e)
        {
            if (_allowToSave)
            {
                LoadStation();
                LoadDay();
            }
        }

        #region Browse Event Handlers
        public void buttonItemScheduleBrowseType_Click(object sender, EventArgs e)
        {
            DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;
            if (button != null && !button.Checked)
            {
                FormMain.Instance.buttonItemScheduleBrowseDay.Checked = false;
                FormMain.Instance.buttonItemScheduleBrowseWeek.Checked = false;
                FormMain.Instance.buttonItemScheduleBrowseMonth.Checked = false;
                button.Checked = true;
            }
        }

        public void buttonItemScheduleBrowseType_CheckedChanged(object sender, EventArgs e)
        {
            if (_allowToSave)
            {
                if (FormMain.Instance.buttonItemScheduleBrowseDay.Checked)
                    ConfigurationClasses.SettingsManager.Instance.BrowseType = ConfigurationClasses.BrowseType.Day;
                else if (FormMain.Instance.buttonItemScheduleBrowseWeek.Checked)
                    ConfigurationClasses.SettingsManager.Instance.BrowseType = ConfigurationClasses.BrowseType.Week;
                else if (FormMain.Instance.buttonItemScheduleBrowseMonth.Checked)
                    ConfigurationClasses.SettingsManager.Instance.BrowseType = ConfigurationClasses.BrowseType.Month;
                ConfigurationClasses.SettingsManager.Instance.SaveApplicationSettings();
            }
        }

        public void buttonItemScheduleBrowseButton_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = FormMain.Instance.dateEditScheduleDay.DateTime;

            DevComponents.DotNetBar.ButtonItem button = sender as DevComponents.DotNetBar.ButtonItem;

            int directionFactor = 0;
            if (button == FormMain.Instance.buttonItemScheduleBrowseForward)
                directionFactor = 1;
            else if (button == FormMain.Instance.buttonItemScheduleBrowseBackward)
                directionFactor = -1;

            switch (ConfigurationClasses.SettingsManager.Instance.BrowseType)
            {
                case ConfigurationClasses.BrowseType.Day:
                    selectedDate = selectedDate.AddDays(1 * directionFactor);
                    break;
                case ConfigurationClasses.BrowseType.Week:
                    selectedDate = selectedDate.AddDays(7 * directionFactor);
                    break;
                case ConfigurationClasses.BrowseType.Month:
                    selectedDate = selectedDate.AddMonths(1 * directionFactor);
                    break;
            }

            FormMain.Instance.dateEditScheduleDay.DateTime = selectedDate;
        }
        #endregion
        #endregion

        #region Ribbon Buttons Clicks
        public void buttonItemScheduleAddProgram_Click(object sender, EventArgs e)
        {
            if (BusinessClasses.StationManager.Instance.SelectedStation != null)
            {
                using (ToolForms.FormEditProgram form = new ToolForms.FormEditProgram(null))
                {
                    form.Text = string.Format(form.Text, "Add");
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        BusinessClasses.StationManager.Instance.SelectedStation.AddProgram(form.Program);
                        LoadDay();
                        this.DataNotSaved = true;
                    }
                }
            }
            gridControlPrograms.Focus();
        }

        public void buttonItemScheduleManagePrograms_Click(object sender, EventArgs e)
        {
            if (BusinessClasses.StationManager.Instance.SelectedStation != null)
            {
                using (ToolForms.FormManagePrograms form = new ToolForms.FormManagePrograms())
                {
                    form.ShowDialog();
                    LoadDay();
                    this.DataNotSaved = true;
                }
            }
            gridControlPrograms.Focus();
        }

        public void buttonItemScheduleInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (_allowToSave)
            {
                ConfigurationClasses.SettingsManager.Instance.ShowInfo = FormMain.Instance.buttonItemScheduleInfo.Checked;
                ConfigurationClasses.SettingsManager.Instance.SaveApplicationSettings();

                gridViewPrograms.OptionsView.ShowPreview = ConfigurationClasses.SettingsManager.Instance.ShowInfo;
            }
        }
        #endregion

        #region Grid Event Handlers
        private void gridViewPrograms_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (_allowToSave)
                this.DataNotSaved = true;
        }

        private void gridViewPrograms_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            int[] selectedRowHandles = view.GetSelectedRows();
            if (view != null && !selectedRowHandles.Contains(e.RowHandle) && e.CellValue == null)
                e.Appearance.ForeColor = Color.Gray;
        }

        private void gridViewPrograms_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                CoreObjects.Spot spot = BusinessClasses.StationManager.Instance.SelectedDay.Spots[gridViewPrograms.GetDataSourceRowIndex(e.RowHandle)];
                using (ToolForms.FormEditSpot form = new ToolForms.FormEditSpot(spot))
                {
                    DialogResult result = form.ShowDialog();
                    if (result == DialogResult.Retry)
                    {
                        CoreObjects.Program program = new CoreObjects.Program();
                        program.Name = spot.Program;
                        program.Type = spot.Type;
                        program.FCC = spot.FCC;
                        program.MovieTitle = spot.MovieTitle;
                        program.Distributor = spot.Distributor;
                        program.ContractLength = spot.ContractLength;
                        program.CustomNote = spot.CustomNote;

                        program.Date = spot.Date;
                        program.StartTime = spot.Time;
                        program.EndTime = program.StartTime.AddMinutes(30);
                        program.RecureEveryWeek = 1;
                        switch (program.Date.DayOfWeek)
                        {
                            case DayOfWeek.Monday:
                                program.RecureOnMonday = true;
                                break;
                            case DayOfWeek.Tuesday:
                                program.RecureOnTuesday = true;
                                break;
                            case DayOfWeek.Wednesday:
                                program.RecureOnWednesday = true;
                                break;
                            case DayOfWeek.Thursday:
                                program.RecureOnThursday = true;
                                break;
                            case DayOfWeek.Friday:
                                program.RecureOnFriday = true;
                                break;
                            case DayOfWeek.Saturday:
                                program.RecureOnSaturday = true;
                                break;
                            case DayOfWeek.Sunday:
                                program.RecureOnSunday = true;
                                break;
                        }
                        program.NoEndRecurence = true;

                        using (ToolForms.FormEditProgram formEditProgram = new ToolForms.FormEditProgram(program))
                        {
                            formEditProgram.Text = string.Format(form.Text, "Add");
                            if (formEditProgram.ShowDialog() == DialogResult.OK)
                            {
                                BusinessClasses.StationManager.Instance.SelectedStation.AddProgram(formEditProgram.Program);
                                LoadDay();
                                this.DataNotSaved = true;
                            }
                        }
                    }
                    else if(result == DialogResult.OK)
                    {
                        gridViewPrograms.RefreshData();
                        this.DataNotSaved = true;
                    }
                }
            }
        }
        #endregion
    }
}