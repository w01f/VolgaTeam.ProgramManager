using System;
using System.Windows.Forms;

namespace ProgramManager.Client.ToolForms
{
    public partial class FormEditProgram : Form
    {
        private CoreObjects.Program _program = null;
        private bool _allowToSave = false;

        public CoreObjects.Program Program
        {
            get
            {
                if (_program == null)
                    _program = new ProgramManager.CoreObjects.Program();

                _program.Name = textEditName.EditValue != null ? textEditName.EditValue.ToString() : string.Empty;
                _program.Date = dateEditDate.DateTime;
                _program.Type = comboBoxEditType.EditValue != null ? comboBoxEditType.EditValue.ToString() : string.Empty;
                _program.FCC = comboBoxEditFCC.EditValue != null ? comboBoxEditFCC.EditValue.ToString() : string.Empty;
                _program.MovieTitle = textEditMovieTitle.EditValue != null ? textEditMovieTitle.EditValue.ToString() : string.Empty;
                _program.Distributor = textEditDistributor.EditValue != null ? textEditDistributor.EditValue.ToString() : string.Empty;
                _program.ContractLength = textEditContractLength.EditValue != null ? textEditContractLength.EditValue.ToString() : string.Empty;
                _program.CustomNote = memoEditCustomNote.EditValue != null ? memoEditCustomNote.EditValue.ToString() : string.Empty;
                _program.StartTime = timeEditStart.Time;
                while (_program.StartTime.Minute != 0 && _program.StartTime.Minute != 30)
                    _program.StartTime = _program.StartTime.AddMinutes(-1);
                while (_program.StartTime.Second != 0)
                    _program.StartTime = _program.StartTime.AddSeconds(-1);
                _program.EndTime = timeEditEnd.Time;
                while (_program.EndTime.Minute != 0 && _program.EndTime.Minute != 30)
                    _program.EndTime = _program.EndTime.AddMinutes(1);
                while (_program.EndTime.Second != 0)
                    _program.EndTime = _program.EndTime.AddSeconds(-1);
                _program.RecureEveryWeek = (int)spinEditWeeksNumber.Value;
                _program.RecureOnMonday = checkEditMonday.Checked;
                _program.RecureOnTuesday = checkEditTuesday.Checked;
                _program.RecureOnWednesday = checkEditWednesday.Checked;
                _program.RecureOnThursday = checkEditThursday.Checked;
                _program.RecureOnFriday = checkEditFriday.Checked;
                _program.RecureOnSaturday = checkEditSaturday.Checked;
                _program.RecureOnSunday = checkEditSunday.Checked;
                _program.NoEndRecurence = checkEditNoEnd.Checked;
                _program.LimitedByRecurenceNumber = checkEditLimitedOccurence.Checked;
                _program.RecurenceNumberLimit = (int)spinEditOccurenceNumber.Value;
                _program.LimitedByEndDate = checkEditLimitedDate.Checked;
                _program.EndDate = dateEditEndDate.DateTime;

                return _program;
            }
        }

        public FormEditProgram(CoreObjects.Program program)
        {
            InitializeComponent();

            _program = program;

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
            memoEditCustomNote.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            memoEditCustomNote.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            memoEditCustomNote.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            timeEditStart.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            timeEditStart.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            timeEditStart.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            timeEditEnd.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            timeEditEnd.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            timeEditEnd.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            spinEditOccurenceNumber.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            spinEditOccurenceNumber.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            spinEditOccurenceNumber.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            spinEditWeeksNumber.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            spinEditWeeksNumber.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            spinEditWeeksNumber.Enter += new EventHandler(FormMain.Instance.Editor_Enter);

            FormMain.Instance.SetClickEventHandler(this);
        }

        private void FormAddProgram_Load(object sender, EventArgs e)
        {
            _allowToSave = false;
            comboBoxEditFCC.Properties.Items.Clear();
            comboBoxEditFCC.Properties.Items.AddRange(Controllers.ListManager.Instance.FCC);
            comboBoxEditType.Properties.Items.Clear();
            comboBoxEditType.Properties.Items.AddRange(Controllers.ListManager.Instance.Type);

            if (_program != null)
            {
                textEditName.EditValue = _program.Name;
                dateEditDate.DateTime = _program.Date;
                comboBoxEditType.EditValue = !string.IsNullOrEmpty(_program.Type) ? _program.Type : null;

                checkEditFCC.Checked = !string.IsNullOrEmpty(_program.FCC);
                comboBoxEditFCC.EditValue = !string.IsNullOrEmpty(_program.FCC) ? _program.FCC : null;

                checkEditMovieTitle.Checked = !string.IsNullOrEmpty(_program.MovieTitle);
                textEditMovieTitle.EditValue = !string.IsNullOrEmpty(_program.MovieTitle) ? _program.MovieTitle : null;

                checkEditDistributor.Checked = !string.IsNullOrEmpty(_program.Distributor);
                textEditDistributor.EditValue = !string.IsNullOrEmpty(_program.Distributor) ? _program.Distributor : null;

                checkEditContractLength.Checked = !string.IsNullOrEmpty(_program.ContractLength);
                textEditContractLength.EditValue = !string.IsNullOrEmpty(_program.ContractLength) ? _program.ContractLength : null;

                checkEditCustomNote.Checked = !string.IsNullOrEmpty(_program.CustomNote);
                memoEditCustomNote.EditValue = !string.IsNullOrEmpty(_program.CustomNote) ? _program.CustomNote : null;

                timeEditStart.Time = _program.StartTime;
                timeEditEnd.Time = _program.EndTime;

                spinEditWeeksNumber.Value = _program.RecureEveryWeek;

                checkEditMonday.Checked = _program.RecureOnMonday;
                checkEditTuesday.Checked = _program.RecureOnTuesday;
                checkEditWednesday.Checked = _program.RecureOnWednesday;
                checkEditThursday.Checked = _program.RecureOnThursday;
                checkEditFriday.Checked = _program.RecureOnFriday;
                checkEditSaturday.Checked = _program.RecureOnSaturday;
                checkEditSunday.Checked = _program.RecureOnSunday;

                if (_program.NoEndRecurence)
                {
                    checkEditNoEnd.Checked = true;
                    checkEditLimitedOccurence.Checked = false;
                    checkEditLimitedDate.Checked = false;
                }
                else if (_program.LimitedByRecurenceNumber)
                {
                    checkEditNoEnd.Checked = false;
                    checkEditLimitedOccurence.Checked = true;
                    spinEditOccurenceNumber.Value = _program.RecurenceNumberLimit;
                    checkEditLimitedDate.Checked = false;
                }
                else if (_program.LimitedByEndDate)
                {
                    checkEditNoEnd.Checked = false;
                    checkEditLimitedOccurence.Checked = false;
                    checkEditLimitedDate.Checked = true;
                    dateEditEndDate.DateTime = _program.EndDate;
                }
            }
            else
            {
                DateTime now = DateTime.Now;
                while (now.Minute != 0 && now.Minute != 30)
                    now = now.AddMinutes(1);
                while (now.Second != 0)
                    now = now.AddSeconds(-1);
                dateEditDate.DateTime = now;
                timeEditStart.Time = now;
                switch (now.DayOfWeek)
                {
                    case DayOfWeek.Monday:
                        checkEditMonday.Checked = true;
                        break;
                    case DayOfWeek.Tuesday:
                        checkEditTuesday.Checked = true;
                        break;
                    case DayOfWeek.Wednesday:
                        checkEditWednesday.Checked = true;
                        break;
                    case DayOfWeek.Thursday:
                        checkEditThursday.Checked = true;
                        break;
                    case DayOfWeek.Friday:
                        checkEditFriday.Checked = true;
                        break;
                    case DayOfWeek.Saturday:
                        checkEditSaturday.Checked = true;
                        break;
                    case DayOfWeek.Sunday:
                        checkEditSunday.Checked = true;
                        break;
                }
            }
            _allowToSave = true;
        }

        private void dateEditDate_EditValueChanged(object sender, EventArgs e)
        {
            timeEditStart.Time = new DateTime(dateEditDate.DateTime.Year, dateEditDate.DateTime.Month, dateEditDate.DateTime.Day, timeEditStart.Time.Hour, timeEditStart.Time.Minute, timeEditStart.Time.Second);
            timeEditEnd.Time = new DateTime(dateEditDate.DateTime.Year, dateEditDate.DateTime.Month, dateEditDate.DateTime.Day, timeEditEnd.Time.Hour, timeEditEnd.Time.Minute, timeEditEnd.Time.Second);
            laRecurenceStart.Text = string.Format("Start: {0}", dateEditDate.DateTime.ToString("MM/dd/yy"));
            if (dateEditEndDate.DateTime < dateEditDate.DateTime)
                dateEditEndDate.DateTime = dateEditDate.DateTime;
        }

        private void timeEditStart_EditValueChanged(object sender, EventArgs e)
        {
            DateTime endDate = timeEditStart.Time;
            if (endDate > timeEditEnd.Time)
                endDate = endDate.AddMinutes(30);
            while (endDate.Minute != 0 && endDate.Minute != 30)
                endDate = endDate.AddMinutes(1);
            timeEditEnd.Time = endDate;
            TimeSpan span = timeEditEnd.Time.Subtract(timeEditStart.Time);
            laDurationValue.Text = (span.Hours > 0 ? string.Format("{0} Hours ", span.Hours) : string.Empty) + (span.Minutes > 0 ? string.Format("{0} Minutes ", span.Minutes) : string.Empty);
        }

        private void timeEditEnd_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan span = timeEditEnd.Time.Subtract(timeEditStart.Time);
            laDurationValue.Text = (span.Hours > 0 ? string.Format("{0} Hours ", span.Hours) : string.Empty) + (span.Minutes > 0 ? string.Format("{0} Minutes ", span.Minutes) : string.Empty);
        }

        private void timeEditEnd_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime newEndTime = (DateTime)e.NewValue;
            if (newEndTime < timeEditStart.Time && _allowToSave)
            {
                Controllers.AppManager.Instance.ShowWarning("End time should later then start time");
                e.Cancel = true;
            }
        }

        private void dateEditEndDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime newEndDate = (DateTime)e.NewValue;
            if (newEndDate < dateEditDate.DateTime && _allowToSave)
            {
                Controllers.AppManager.Instance.ShowWarning("End date should later then start date");
                e.Cancel = true;
            }
        }

        private void checkEditLimitedOccurence_CheckedChanged(object sender, EventArgs e)
        {
            spinEditOccurenceNumber.Enabled = checkEditLimitedOccurence.Checked;
            laLimitedOccurence.Enabled = checkEditLimitedOccurence.Checked;
        }

        private void checkEditLimitedDate_CheckedChanged(object sender, EventArgs e)
        {
            dateEditEndDate.Enabled = checkEditLimitedDate.Checked;
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
