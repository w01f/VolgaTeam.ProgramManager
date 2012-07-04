using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProgramManager.Client.TabPages
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class TabSearch : UserControl
    {
        private CoreObjects.ProgramActivity[] _searchResult;
        private bool _allowToSave = false;

        public TabSearch()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            Controllers.StationManager.Instance.StationChanged += new EventHandler<EventArgs>((sender, e) =>
            {
                if (sender != this)
                {
                    _allowToSave = false;
                    FormMain.Instance.comboBoxEditSearchStation.EditValue = Controllers.StationManager.Instance.SelectedStation.Name;
                    FormMain.Instance.labelItemSearchStationLogo.Image = Controllers.StationManager.Instance.SelectedStation.Logo;
                    FormMain.Instance.ribbonBarSearchStation.RecalcLayout();
                    FormMain.Instance.ribbonPanelSearch.PerformLayout();
                    _allowToSave = true;
                }
            });

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
                return true;
            }
        }

        private void LoadStation()
        {
            Controllers.StationManager.Instance.LoadStation(this, FormMain.Instance.comboBoxEditSearchStation.EditValue != null ? FormMain.Instance.comboBoxEditSearchStation.EditValue.ToString() : string.Empty);
            if (Controllers.StationManager.Instance.SelectedStation != null)
            {
                FormMain.Instance.labelItemSearchStationLogo.Image = Controllers.StationManager.Instance.SelectedStation.Logo;
                FormMain.Instance.ribbonBarSearchStation.RecalcLayout();
                FormMain.Instance.ribbonPanelSearch.PerformLayout();
            }
        }

        private void LoadProgramsList()
        {
            FormMain.Instance.comboBoxEditSearchPrograms.Properties.Items.Clear();
            FormMain.Instance.comboBoxEditSearchPrograms.Properties.Items.AddRange(Controllers.StationManager.Instance.GetProgramList());
        }

        public void LoadPage()
        {
            _allowToSave = false;

            FormMain.Instance.ribbonPanelSearch.Enabled = true;
            FormMain.Instance.comboBoxEditSearchStation.Properties.Items.Clear();
            FormMain.Instance.comboBoxEditSearchStation.Properties.Items.AddRange(Controllers.StationManager.Instance.GetStationList());
            if (FormMain.Instance.comboBoxEditSearchStation.Properties.Items.Contains(ConfigurationClasses.SettingsManager.Instance.SelectedStation))
                FormMain.Instance.comboBoxEditSearchStation.SelectedIndex = FormMain.Instance.comboBoxEditSearchStation.Properties.Items.IndexOf(ConfigurationClasses.SettingsManager.Instance.SelectedStation);
            else if (FormMain.Instance.comboBoxEditSearchStation.Properties.Items.Count > 0)
                FormMain.Instance.comboBoxEditSearchStation.SelectedIndex = 0;
            else
                FormMain.Instance.ribbonPanelSearch.Enabled = false;

            gridViewPrograms.OptionsView.ShowPreview = false;

            repositoryItemComboBoxType.Items.Clear();
            repositoryItemComboBoxType.Items.AddRange(Controllers.ListManager.Instance.Type);
            repositoryItemComboBoxFCC.Items.Clear();
            repositoryItemComboBoxFCC.Items.AddRange(Controllers.ListManager.Instance.FCC);

            _allowToSave = true;

            ClearSearchParameters();

            LoadStation();

            LoadProgramsList();
        }

        private void ClearSearchParameters()
        {
            FormMain.Instance.comboBoxEditSearchPrograms.EditValue = null;
            FormMain.Instance.dateEditSearchDateStart.DateTime = DateTime.Now;
            FormMain.Instance.dateEditSearchDateEnd.DateTime = FormMain.Instance.dateEditSearchDateStart.DateTime;
            FormMain.Instance.buttonItemSearchRun.Enabled = true;
            FormMain.Instance.ribbonBarSearchOutput.Enabled = false;
            gridControlPrograms.DataSource = null;
        }
        #endregion

        #region Navigation Event Handlers
        public void comboBoxEditSearchStation_EditValueChanged(object sender, EventArgs e)
        {
            if (_allowToSave)
            {
                ClearSearchParameters();
                LoadStation();
                LoadProgramsList();
            }
        }
        #endregion

        #region Ribbon Buttons Clicks
        public void buttonItemSearchRun_Click(object sender, EventArgs e)
        {
            if (Controllers.StationManager.Instance.SelectedStation != null)
            {
                using (ToolForms.FormProgress form = new ToolForms.FormProgress())
                {
                    form.laProgress.Text = "Searching Programs...";
                    form.TopMost = true;
                    System.Threading.Thread thread = new System.Threading.Thread(new System.Threading.ThreadStart(delegate()
                    {
                        _searchResult = Controllers.StationManager.Instance.SelectedStation.Search(FormMain.Instance.dateEditSearchDateStart.DateTime, FormMain.Instance.dateEditSearchDateEnd.DateTime, FormMain.Instance.comboBoxEditSearchPrograms.EditValue != null ? FormMain.Instance.comboBoxEditSearchPrograms.EditValue.ToString() : null);
                        this.Invoke((MethodInvoker)delegate()
                        {
                            gridControlPrograms.DataSource = new BindingList<CoreObjects.ProgramActivity>(_searchResult);
                            FormMain.Instance.ribbonBarSearchOutput.Enabled = _searchResult.Length > 0;
                        });
                    }));
                    form.Show();
                    Application.DoEvents();
                    thread.Start();
                    while (thread.IsAlive)
                        Application.DoEvents();
                    form.Close();
                }
            }
        }

        public void buttonItemSearchOutputExcel_Click(object sender, EventArgs e)
        {
            Controllers.StationManager.Instance.ReportActivityList(_searchResult, false);
        }

        public void buttonItemSearchOutputPDF_Click(object sender, EventArgs e)
        {
            Controllers.StationManager.Instance.ReportActivityList(_searchResult, true);
        }
        #endregion
    }
}
