using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ProgramManager.Client.ToolForms
{
    public partial class FormManagePrograms : Form
    {
        public FormManagePrograms()
        {
            InitializeComponent();
        }

        private void EditProgram(CoreObjects.Program program)
        {
            CoreObjects.Program updatedProgram = program.Clone();
            using (ToolForms.FormEditProgram form = new FormEditProgram(updatedProgram))
            {
                form.Text = string.Format(form.Text, "Edit");
                if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    updatedProgram = form.Program;
                    int programIndex = Controllers.StationManager.Instance.SelectedStation.Programs.IndexOf(program);
                    Controllers.StationManager.Instance.SelectedStation.DeleteProgram(program, true);
                    Controllers.StationManager.Instance.SelectedStation.AddProgram(updatedProgram, programIndex);
                }
            }
        }

        private void FormManagePrograms_Load(object sender, EventArgs e)
        {
            gridControlPrograms.DataSource = new BindingList<CoreObjects.Program>(Controllers.StationManager.Instance.SelectedStation.Programs);
        }

        private void gridViewPrograms_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                EditProgram(Controllers.StationManager.Instance.SelectedStation.Programs[gridViewPrograms.GetDataSourceRowIndex(e.RowHandle)]);
            }
        }

        private void repositoryItemButtonEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            CoreObjects.Program program = Controllers.StationManager.Instance.SelectedStation.Programs[gridViewPrograms.GetDataSourceRowIndex(gridViewPrograms.FocusedRowHandle)];
            if (e.Button.Index == 0)
            {
                EditProgram(program);
            }
            else if (e.Button.Index == 1)
            {
                if (Controllers.AppManager.Instance.ShowWarningQuestion("Do you want to delete selected program?") == System.Windows.Forms.DialogResult.Yes)
                    Controllers.StationManager.Instance.SelectedStation.DeleteProgram(program, Controllers.AppManager.Instance.ShowWarningQuestion("Do you want to clean time-blocks used by the program?") == System.Windows.Forms.DialogResult.Yes);
            }
            gridViewPrograms.RefreshData();
        }
    }
}
