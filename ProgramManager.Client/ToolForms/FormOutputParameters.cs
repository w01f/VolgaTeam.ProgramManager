using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager.Client.ToolForms
{
    public partial class FormOutputParameters : Form
    {
        private List<CoreObjects.Week> _weeks = new List<CoreObjects.Week>();

        public string Station
        {
            get
            {
                return comboBoxEditStation.EditValue != null ? comboBoxEditStation.EditValue.ToString() : string.Empty;
            }
        }

        public CoreObjects.Week[] Weeks
        {
            get
            {
                return _weeks.ToArray();
            }
        }

        public bool Landscape
        {
            get
            {
                return checkButtonLandscape.Checked;
            }
        }

        public FormOutputParameters()
        {
            InitializeComponent();
        }

        private void FormOutputParameters_Load(object sender, System.EventArgs e)
        {
            comboBoxEditStation.Properties.Items.AddRange(Controllers.StationManager.Instance.GetStationList());
            comboBoxEditStation.EditValue = Controllers.StationManager.Instance.SelectedStation.Name;

            DateTime currentDate = Controllers.StationManager.Instance.SelectedDay.Date;
            while (currentDate.DayOfWeek != DayOfWeek.Monday)
                currentDate = currentDate.AddDays(-1);
            dateEditWeekStart.DateTime = currentDate;

            CoreObjects.Week week = new CoreObjects.Week();
            week.DateStart = dateEditWeekStart.DateTime;
            week.DateEnd = week.DateStart.AddDays(6);
            _weeks.Add(week);

            gridControlWeeks.DataSource = _weeks;
        }

        private void dateEditWeekStart_EditValueChanged(object sender, System.EventArgs e)
        {
            laWeekEnd.Text = string.Format("Sunday:   {0}", dateEditWeekStart.DateTime.AddDays(6).ToString("MM/dd/yy"));
        }

        private void dateEditWeekStart_DrawItem(object sender, DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventArgs e)
        {
            if (e.Date.DayOfWeek == DayOfWeek.Monday)
            {
                e.Style.ForeColor = Color.Black;
                e.Style.Font = new System.Drawing.Font(e.Style.Font.Name, e.Style.Font.Size, FontStyle.Bold);
            }
            else
            {
                e.Style.ForeColor = Color.Gray;
                if (e.Date == DateTime.Today)
                {
                    RectangleF rect = new RectangleF(e.Bounds.Location, e.Bounds.Size);
                    Color backColor = Color.White;
                    e.Graphics.FillRectangle(new SolidBrush(backColor), rect);
                    e.Graphics.DrawString(e.Date.Day.ToString(), e.Style.Font,
                        new SolidBrush(e.Style.ForeColor), rect, e.Style.GetStringFormat());
                    e.Handled = true;
                }
            }
        }

        private void dateEditWeekStart_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            if (e.Value != null)
            {
                DateTime temp = DateTime.MinValue;
                if (DateTime.TryParse(e.Value.ToString(), out temp))
                {
                    while (temp.DayOfWeek != DayOfWeek.Monday)
                        temp = temp.AddDays(-1);
                    e.Value = temp;
                }
            }
        }

        private void simpleButtonAddWeek_Click(object sender, EventArgs e)
        {
            CoreObjects.Week week = new CoreObjects.Week();
            week.DateStart = dateEditWeekStart.DateTime;
            week.DateEnd = week.DateStart.AddDays(6);
            if (_weeks.Where(x => x.DateStart.Year == week.DateStart.Year && x.DateStart.Month == week.DateStart.Month && x.DateStart.Day == week.DateStart.Day).Count() == 0)
                _weeks.Add(week);
            gridControlWeeks.RefreshDataSource();
        }

        private void repositoryItemButtonEdit_Click(object sender, EventArgs e)
        {
            _weeks.Remove(_weeks[gridViewWeeks.GetDataSourceRowIndex(gridViewWeeks.FocusedRowHandle)]);
            gridControlWeeks.RefreshDataSource();
        }
    }
}