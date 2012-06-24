using System;
using System.Windows.Forms;

namespace ProgramManager.ToolForms
{
    public partial class FormAddProgram : Form
    {
        private bool _aloowToSave = false;

        public BusinessClasses.Program Program
        {
            get
            {
                BusinessClasses.Program program = new BusinessClasses.Program();
                program.Name = textEditName.EditValue != null ? textEditName.EditValue.ToString() : string.Empty;
                program.Date = dateEditDate.DateTime;
                program.Type = textEditType.EditValue != null ? textEditType.EditValue.ToString() : string.Empty;
                program.FCC = textEditFCC.EditValue != null ? textEditFCC.EditValue.ToString() : string.Empty;
                program.StartTime = timeEditStart.Time;
                while (program.StartTime.Minute != 0 && program.StartTime.Minute != 30)
                    program.StartTime = program.StartTime.AddMinutes(-1);
                while (program.StartTime.Second != 0)
                    program.StartTime = program.StartTime.AddSeconds(-1);
                program.EndTime = timeEditEnd.Time;
                while (program.EndTime.Minute != 0 && program.EndTime.Minute != 30)
                    program.EndTime = program.StartTime.AddMinutes(1);
                while (program.EndTime.Second != 0)
                    program.EndTime = program.EndTime.AddSeconds(-1);
                program.RecureEveryWeek = (int)spinEditWeeksNumber.Value;
                program.RecureOnMonday = checkEditMonday.Checked;
                program.RecureOnTuesday = checkEditTuesday.Checked;
                program.RecureOnWednesday = checkEditWednesday.Checked;
                program.RecureOnThursday = checkEditThursday.Checked;
                program.RecureOnFriday = checkEditFriday.Checked;
                program.RecureOnSaturday = checkEditSaturday.Checked;
                program.RecureOnSunday = checkEditSunday.Checked;
                program.NoEndRecurence = checkEditNoEnd.Checked;
                program.LimitedByRecurenceNumber = checkEditLimitedOccurence.Checked;
                program.RecurenceNumberLimit = (int)spinEditOccurenceNumber.Value;
                program.LimitedByEndDate = checkEditLimitedDate.Checked;
                program.EndDate = dateEditEndDate.DateTime;
                return program;
            }
        }

        public FormAddProgram()
        {
            InitializeComponent();

            textEditFCC.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditFCC.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditFCC.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            textEditName.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditName.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditName.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
            textEditType.MouseUp += new MouseEventHandler(FormMain.Instance.Editor_MouseUp);
            textEditType.MouseDown += new MouseEventHandler(FormMain.Instance.Editor_MouseDown);
            textEditType.Enter += new EventHandler(FormMain.Instance.Editor_Enter);
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
            _aloowToSave = false;
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
            _aloowToSave = true;
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
            if (newEndTime < timeEditStart.Time && _aloowToSave)
            {
                AppManager.Instance.ShowWarning("End time should later then start time");
                e.Cancel = true;
            }
        }

        private void dateEditEndDate_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            DateTime newEndDate = (DateTime)e.NewValue;
            if (newEndDate < dateEditDate.DateTime && _aloowToSave)
            {
                AppManager.Instance.ShowWarning("End date should later then start date");
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
    }
}
