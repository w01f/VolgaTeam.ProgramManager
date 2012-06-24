using System.Windows.Forms;

namespace ProgramManager.ToolForms
{
    public partial class FormProgress : Form
    {
        public FormProgress()
        {
            InitializeComponent();
            if ((base.CreateGraphics()).DpiX > 96)
            {
                laProgress.Font = new System.Drawing.Font(laProgress.Font.FontFamily, laProgress.Font.Size - 2, laProgress.Font.Style);
            }
        }

        private void FormProgress_Shown(object sender, System.EventArgs e)
        {
            laProgress.Focus();
            circularProgress.IsRunning = true;
        }
    }
}