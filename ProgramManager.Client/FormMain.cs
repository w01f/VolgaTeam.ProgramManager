using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProgramManager.Client
{
    public partial class FormMain : Form
    {
        private static FormMain _instance = null;

        private Control _currentControl = null;

        #region Tab Pages
        public TabPages.TabSchedule TabSchedule { get; set; }
        public TabPages.TabSearch TabSearch { get; set; }
        #endregion

        private FormMain()
        {
            InitializeComponent();
        }

        public static FormMain Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new FormMain();
                return _instance;
            }
        }

        public void SetClickEventHandler(Control control)
        {
            foreach (Control childControl in control.Controls)
                SetClickEventHandler(childControl);
            if (control.GetType() != typeof(DevExpress.XtraEditors.TextBoxMaskBox) && control.GetType() != typeof(DevExpress.XtraEditors.TextEdit) && control.GetType() != typeof(DevExpress.XtraEditors.MemoEdit) && control.GetType() != typeof(DevExpress.XtraEditors.ComboBoxEdit) && control.GetType() != typeof(DevExpress.XtraEditors.LookUpEdit) && control.GetType() != typeof(DevExpress.XtraEditors.DateEdit) && control.GetType() != typeof(DevExpress.XtraEditors.CheckedListBoxControl) && control.GetType() != typeof(DevExpress.XtraEditors.SpinEdit) && control.GetType() != typeof(DevExpress.XtraEditors.CheckEdit) && control.GetType() != typeof(DevExpress.XtraEditors.TimeEdit))
                control.Click += new EventHandler(ControlClick);
        }

        private void ControlClick(object sender, EventArgs e)
        {
            Control control = sender as Control;
            if (control != null && control.Parent != null)
                control.Parent.Focus();
        }

        private bool AllowToLeaveCurrentControl()
        {
            bool result = false;
            if ((_currentControl == this.TabSchedule))
            {
                if (this.TabSchedule.AllowToLeaveControl)
                    result = true;
            }
            else if ((_currentControl == this.TabSearch))
            {
                if (this.TabSearch.AllowToLeaveControl)
                    result = true;
            }
            else
                result = true;
            return result;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            ribbonTabItemOutput.Enabled = false;
            ribbonTabItemSettings.Enabled = false;

            #region Tab Pages Initialization
            this.TabSchedule = new TabPages.TabSchedule();
            comboBoxEditScheduleStation.EditValueChanged += new EventHandler(this.TabSchedule.comboBoxEditScheduleStation_EditValueChanged);
            dateEditScheduleDay.EditValueChanged += new EventHandler(this.TabSchedule.dateEditScheduleDay_EditValueChanged);
            buttonItemScheduleAddProgram.Click += new EventHandler(this.TabSchedule.buttonItemScheduleAddProgram_Click);
            buttonItemScheduleManagePrograms.Click += new EventHandler(this.TabSchedule.buttonItemScheduleManagePrograms_Click);
            buttonItemScheduleInfo.CheckedChanged += new EventHandler(this.TabSchedule.buttonItemScheduleInfo_CheckedChanged);
            buttonItemScheduleBrowseDay.Click += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseType_Click);
            buttonItemScheduleBrowseWeek.Click += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseType_Click);
            buttonItemScheduleBrowseMonth.Click += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseType_Click);
            buttonItemScheduleBrowseDay.CheckedChanged += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseType_CheckedChanged);
            buttonItemScheduleBrowseWeek.CheckedChanged += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseType_CheckedChanged);
            buttonItemScheduleBrowseMonth.CheckedChanged += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseType_CheckedChanged);
            buttonItemScheduleBrowseForward.Click += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseButton_Click);
            buttonItemScheduleBrowseBackward.Click += new EventHandler(this.TabSchedule.buttonItemScheduleBrowseButton_Click);

            this.TabSearch = new TabPages.TabSearch();
            comboBoxEditSearchStation.EditValueChanged += new EventHandler(this.TabSearch.comboBoxEditSearchStation_EditValueChanged);
            comboBoxEditSearchPrograms.EditValueChanged += new EventHandler(this.TabSearch.comboBoxEditSearchPrograms_EditValueChanged);
            buttonItemSearchRun.Click += new EventHandler(this.TabSearch.buttonItemSearchRun_Click);
            #endregion

            ribbonControl.SelectedRibbonTabChanged += new EventHandler(ribbonControl_SelectedRibbonTabChanged);

            this.SetClickEventHandler(ribbonControl);
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            if (File.Exists(ConfigurationClasses.SettingsManager.Instance.IconFilePath))
                this.Icon = new Icon(ConfigurationClasses.SettingsManager.Instance.IconFilePath);
            this.Text = ConfigurationClasses.SettingsManager.Instance.ApplicationName;

            using (ToolForms.FormProgress form = new ToolForms.FormProgress())
            {
                form.laProgress.Text = "Loading Programs...";
                form.TopMost = true;
                ribbonControl.Enabled = false;
                System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(delegate()
                {
                    BusinessClasses.StationManager.Instance.LoadStations();
                    this.Invoke((MethodInvoker)delegate()
                    {
                        this.TabSchedule.LoadPage();
                        this.TabSearch.LoadPage();
                        ribbonControl_SelectedRibbonTabChanged(null, null);
                    });
                }));
                form.Show();
                Application.DoEvents();
                thread.Start();
                while (thread.IsAlive)
                    Application.DoEvents();
                ribbonControl.Enabled = true;
                form.Close();
            }
            //AppManager.Instance.ActivatePowerPoint();
            //AppManager.Instance.ActivateMiniBar();
            //AppManager.Instance.ActivateMainForm();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool result = true;
            if (_currentControl == this.TabSchedule)
                result = this.TabSchedule.AllowToLeaveControl;
        }

        private void ribbonControl_SelectedRibbonTabChanged(object sender, EventArgs e)
        {
            if (ribbonControl.SelectedRibbonTabItem == ribbonTabItemSchedule)
            {
                if (AllowToLeaveCurrentControl())
                    _currentControl = this.TabSchedule;
            }
            else if (ribbonControl.SelectedRibbonTabItem == ribbonTabItemSearch)
            {
                if (AllowToLeaveCurrentControl())
                    _currentControl = this.TabSearch;
            }
            else
            {
                _currentControl = pnEmpty;
            }
            if (!pnMain.Controls.Contains(_currentControl))
                pnMain.Controls.Add(_currentControl);
            _currentControl.BringToFront();
        }

        private void labelItemLogo_Click(object sender, EventArgs e)
        {
            ribbonTabItemSchedule.Select();
        }

        private void buttonItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Select All in Editor Handlers
        private bool enter = false;
        private bool needSelect = false;

        public void Editor_Enter(object sender, EventArgs e)
        {
            enter = true;
            BeginInvoke(new MethodInvoker(ResetEnterFlag));
        }

        public void Editor_MouseUp(object sender, MouseEventArgs e)
        {
            if (needSelect)
            {
                (sender as DevExpress.XtraEditors.BaseEdit).SelectAll();
            }
        }

        public void Editor_MouseDown(object sender, MouseEventArgs e)
        {
            needSelect = enter;
        }

        private void ResetEnterFlag()
        {
            enter = false;
        }
        #endregion
    }
}
