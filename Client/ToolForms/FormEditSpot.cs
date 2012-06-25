using System;
using System.Windows.Forms;

namespace ProgramManager.ToolForms
{
    public partial class FormEditSpot : Form
    {
        private BusinessClasses.Spot _spot = null;

        public FormEditSpot(BusinessClasses.Spot spot)
        {
            InitializeComponent();

            _spot = spot;

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

        private void FormEditSpot_Load(object sender, EventArgs e)
        {
            comboBoxEditFCC.Properties.Items.Clear();
            comboBoxEditFCC.Properties.Items.AddRange(BusinessClasses.ListManager.Instance.FCC);
            comboBoxEditType.Properties.Items.Clear();
            comboBoxEditType.Properties.Items.AddRange(BusinessClasses.ListManager.Instance.Type);

            laSpotHeader.Text = string.Format("{0}, {1}, {2}", new string[] { _spot.Date.ToString("ddd, MM/dd/yy"), _spot.Time.ToString("hh:mm tt"), _spot.Station });

            textEditName.EditValue = _spot.Program;
            comboBoxEditType.EditValue = _spot.Type;

            checkEditHouseNumber.Checked = !string.IsNullOrEmpty(_spot.HouseNumber);
            textEditHouseNumber.EditValue = _spot.HouseNumber;

            checkEditEpisode.Checked = !string.IsNullOrEmpty(_spot.Episode);
            textEditEpisode.EditValue = _spot.Episode;

            checkEditMovieTitle.Checked = !string.IsNullOrEmpty(_spot.MovieTitle);
            textEditMovieTitle.EditValue = _spot.MovieTitle;

            checkEditFCC.Checked = !string.IsNullOrEmpty(_spot.FCC);
            comboBoxEditFCC.EditValue = _spot.FCC;

            checkEditDistributor.Checked = !string.IsNullOrEmpty(_spot.Distributor);
            textEditDistributor.EditValue = _spot.Distributor;

            checkEditContractLength.Checked = !string.IsNullOrEmpty(_spot.ContractLength);
            textEditContractLength.EditValue = _spot.ContractLength;

            checkEditCustomNote.Checked = !string.IsNullOrEmpty(_spot.CustomNote);
            memoEditCustomNote.EditValue = _spot.CustomNote;
        }

        private void FormEditSpot_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                _spot.Program = textEditName.EditValue != null ? textEditName.EditValue.ToString() : null;
                _spot.Type = comboBoxEditType.EditValue != null ? comboBoxEditType.EditValue.ToString() : null;
                _spot.HouseNumber = textEditHouseNumber.EditValue != null ? textEditHouseNumber.EditValue.ToString() : null;
                _spot.Episode = textEditEpisode.EditValue != null ? textEditEpisode.EditValue.ToString() : null;
                _spot.MovieTitle = textEditMovieTitle.EditValue != null ? textEditMovieTitle.EditValue.ToString() : null;
                _spot.FCC = comboBoxEditFCC.EditValue != null ? comboBoxEditFCC.EditValue.ToString() : null;
                _spot.Distributor = textEditDistributor.EditValue != null ? textEditDistributor.EditValue.ToString() : null;
                _spot.ContractLength = textEditContractLength.EditValue != null ? textEditContractLength.EditValue.ToString() : null;
                _spot.CustomNote = memoEditCustomNote.EditValue != null ? memoEditCustomNote.EditValue.ToString() : null;
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
