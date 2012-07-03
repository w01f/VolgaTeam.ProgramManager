using System;
using System.Windows.Forms;

namespace ProgramManager.Client.ToolForms
{
    public partial class FormEditProgramActivity : Form
    {
        private CoreObjects.ProgramActivity _programActivity = null;

        public FormEditProgramActivity(CoreObjects.ProgramActivity programActivity)
        {
            InitializeComponent();

            _programActivity = programActivity;

            textEditMovieTitle.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditMovieTitle.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditMovieTitle.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            textEditName.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditName.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditName.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            textEditDistributor.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditDistributor.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditDistributor.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            textEditContractLength.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditContractLength.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditContractLength.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            textEditHouseNumber.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditHouseNumber.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditHouseNumber.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            textEditEpisode.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditEpisode.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditEpisode.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            memoEditCustomNote.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            memoEditCustomNote.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            memoEditCustomNote.Enter += new EventHandler(FormMain.Instance.Editor_Enter);

            FormMain.Instance.SetClickEventHandler(this);
        }

        private void FormEditProgramActivity_Load(object sender, EventArgs e)
        {
            comboBoxEditFCC.Properties.Items.Clear();
            comboBoxEditFCC.Properties.Items.AddRange(Controllers.ListManager.Instance.FCC);
            comboBoxEditType.Properties.Items.Clear();
            comboBoxEditType.Properties.Items.AddRange(Controllers.ListManager.Instance.Type);

            laProgramActivityHeader.Text = string.Format("{0}, {1}, {2}", new string[] { _programActivity.Date.ToString("ddd, MM/dd/yy"), _programActivity.Time.ToString("hh:mm tt"), _programActivity.Station });

            textEditName.EditValue = _programActivity.Program;
            comboBoxEditType.EditValue = _programActivity.Type;

            checkEditHouseNumber.Checked = !string.IsNullOrEmpty(_programActivity.HouseNumber);
            textEditHouseNumber.EditValue = _programActivity.HouseNumber;

            checkEditEpisode.Checked = !string.IsNullOrEmpty(_programActivity.Episode);
            textEditEpisode.EditValue = _programActivity.Episode;

            checkEditMovieTitle.Checked = !string.IsNullOrEmpty(_programActivity.MovieTitle);
            textEditMovieTitle.EditValue = _programActivity.MovieTitle;

            checkEditFCC.Checked = !string.IsNullOrEmpty(_programActivity.FCC);
            comboBoxEditFCC.EditValue = _programActivity.FCC;

            checkEditDistributor.Checked = !string.IsNullOrEmpty(_programActivity.Distributor);
            textEditDistributor.EditValue = _programActivity.Distributor;

            checkEditContractLength.Checked = !string.IsNullOrEmpty(_programActivity.ContractLength);
            textEditContractLength.EditValue = _programActivity.ContractLength;

            checkEditCustomNote.Checked = !string.IsNullOrEmpty(_programActivity.CustomNote);
            memoEditCustomNote.EditValue = _programActivity.CustomNote;
        }

        private void FormEditProgramActivity_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK || this.DialogResult == System.Windows.Forms.DialogResult.Retry)
            {
                _programActivity.Program = textEditName.EditValue != null ? textEditName.EditValue.ToString() : null;
                _programActivity.Type = comboBoxEditType.EditValue != null ? comboBoxEditType.EditValue.ToString() : null;
                _programActivity.HouseNumber = textEditHouseNumber.EditValue != null ? textEditHouseNumber.EditValue.ToString() : null;
                _programActivity.Episode = textEditEpisode.EditValue != null ? textEditEpisode.EditValue.ToString() : null;
                _programActivity.MovieTitle = textEditMovieTitle.EditValue != null ? textEditMovieTitle.EditValue.ToString() : null;
                _programActivity.FCC = comboBoxEditFCC.EditValue != null ? comboBoxEditFCC.EditValue.ToString() : null;
                _programActivity.Distributor = textEditDistributor.EditValue != null ? textEditDistributor.EditValue.ToString() : null;
                _programActivity.ContractLength = textEditContractLength.EditValue != null ? textEditContractLength.EditValue.ToString() : null;
                _programActivity.CustomNote = memoEditCustomNote.EditValue != null ? memoEditCustomNote.EditValue.ToString() : null;
            }
        }

        private void checkEditHouseNumber_CheckedChanged(object sender, EventArgs e)
        {
            textEditHouseNumber.Enabled = checkEditHouseNumber.Checked;
            textEditHouseNumber.EditValue = checkEditHouseNumber.Checked ? textEditHouseNumber.EditValue : null;
        }

        private void checkEditEpisode_CheckedChanged(object sender, EventArgs e)
        {
            textEditEpisode.Enabled = checkEditEpisode.Checked;
            textEditEpisode.EditValue = checkEditEpisode.Checked ? textEditEpisode.EditValue : null;
        }

        private void checkEditFCC_CheckedChanged(object sender, EventArgs e)
        {
            comboBoxEditFCC.Enabled = checkEditFCC.Checked;
            comboBoxEditFCC.EditValue = checkEditFCC.Checked ? comboBoxEditFCC.EditValue : null;
        }

        private void checkEditMovietitle_CheckedChanged(object sender, EventArgs e)
        {
            textEditMovieTitle.Enabled = checkEditMovieTitle.Checked;
            textEditMovieTitle.EditValue = checkEditMovieTitle.Checked ? textEditMovieTitle.EditValue : null;
        }

        private void checkEditDistributor_CheckedChanged(object sender, EventArgs e)
        {
            textEditDistributor.Enabled = checkEditDistributor.Checked;
            textEditDistributor.EditValue = checkEditDistributor.Checked ? textEditDistributor.EditValue : null;
        }

        private void checkEditContractLength_CheckedChanged(object sender, EventArgs e)
        {
            textEditContractLength.Enabled = checkEditContractLength.Checked;
            textEditContractLength.EditValue = checkEditContractLength.Checked ? textEditContractLength.EditValue : null;
        }

        private void checkEditCustomNote_CheckedChanged(object sender, EventArgs e)
        {
            memoEditCustomNote.Enabled = checkEditCustomNote.Checked;
            memoEditCustomNote.EditValue = checkEditCustomNote.Checked ? memoEditCustomNote.EditValue : null;
        }
    }
}
