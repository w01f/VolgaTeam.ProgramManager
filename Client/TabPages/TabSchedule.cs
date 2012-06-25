using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager.TabPages
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class TabSchedule : UserControl
    {
        private bool _allowToSave = false;

        public BusinessClasses.Station SelectedStation { get; private set; }
        public BusinessClasses.Day SelectedDay { get; private set; }
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
            string selectedStationName = FormMain.Instance.comboBoxEditScheduleStation.EditValue != null ? FormMain.Instance.comboBoxEditScheduleStation.EditValue.ToString() : string.Empty;
            this.SelectedStation = BusinessClasses.StationManager.Instance.Stations.Where(x => x.Name.Equals(selectedStationName)).FirstOrDefault();
            if (this.SelectedStation != null)
            {
                ConfigurationClasses.SettingsManager.Instance.SelectedStation = this.SelectedStation.Name;
                ConfigurationClasses.SettingsManager.Instance.SaveApplicationSettings();

                FormMain.Instance.labelItemScheduleSationLogo.Image = this.SelectedStation.Logo;
                FormMain.Instance.ribbonBarScheduleStation.RecalcLayout();
                FormMain.Instance.ribbonPanelSchedule.PerformLayout();
            }
        }

        private void LoadDay()
        {
            if (this.DataNotSaved)
                SavePage();
            if (this.SelectedStation != null)
            {
                _allowToSave = false;
                this.SelectedDay = this.SelectedStation.GetDay(FormMain.Instance.dateEditScheduleDay.DateTime);
                gridControlPrograms.DataSource = new BindingList<BusinessClasses.Spot>(this.SelectedDay.Spots);
                _allowToSave = true;
            }
        }

        public void LoadPage()
        {
            _allowToSave = false;

            FormMain.Instance.ribbonPanelSchedule.Enabled = true;
            FormMain.Instance.comboBoxEditScheduleStation.Properties.Items.Clear();
            FormMain.Instance.comboBoxEditScheduleStation.Properties.Items.AddRange(BusinessClasses.StationManager.Instance.Stations.Select(x => x.Name).ToArray());
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
            if (this.SelectedDay != null)
                this.SelectedDay.Save();
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
            using (ToolForms.FormAddProgram form = new ToolForms.FormAddProgram())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    if (this.SelectedStation != null)
                        this.SelectedStation.AddProgram(form.Program);
                    LoadDay();
                    this.DataNotSaved = true;
                }
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
                BusinessClasses.Spot spot = this.SelectedDay.Spots[gridViewPrograms.GetDataSourceRowIndex(e.RowHandle)];
                using (ToolForms.FormEditSpot form = new ToolForms.FormEditSpot(spot))
                {
                    if (form.ShowDialog() == DialogResult.OK)
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
