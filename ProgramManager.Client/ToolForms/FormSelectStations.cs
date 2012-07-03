using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ProgramManager.Client.ToolForms
{
    public partial class FormSelectStations : Form
    {
        public List<string> AvailableStations { get; private set; }
        public string DefaultSelectedStation { get; set; }
        public string ActionName { get; set; }

        public string[] SelectedStations
        {
            get
            {
                List<string> result = new List<string>();
                foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in checkedListBoxControlStations.Items)
                    if (item.CheckState == CheckState.Checked)
                        result.Add(item.Value.ToString());
                return result.ToArray();
            }
        }

        public FormSelectStations()
        {
            InitializeComponent();
            this.AvailableStations = new List<string>();
        }

        private void FormSelectStations_Load(object sender, EventArgs e)
        {
            laTitle.Text = string.Format(laTitle.Text, this.ActionName);
            simpleButtonOK.Text = string.Format(simpleButtonOK.Text, this.ActionName);

            foreach (string stationName in this.AvailableStations)
                checkedListBoxControlStations.Items.Add(stationName, stationName, string.IsNullOrEmpty(this.DefaultSelectedStation) || stationName.Equals(this.DefaultSelectedStation) ? CheckState.Checked : CheckState.Unchecked, true);
        }

        private void simpleButtonSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DevExpress.XtraEditors.Controls.CheckedListBoxItem item in checkedListBoxControlStations.Items)
                item.CheckState = CheckState.Checked;
        }
    }
}
