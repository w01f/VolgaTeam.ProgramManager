using System.Windows.Forms;

namespace ProgramManager.Client.ToolForms
{
    public partial class FormDownloadWarning : Form
    {
        public FormDownloadWarning()
        {
            InitializeComponent();
        }

        private void FormDownloadWarning_Load(object sender, System.EventArgs e)
        {
            checkEditDownloadAlways.Checked = ConfigurationClasses.SettingsManager.Instance.AlwaysDownload;
            checkEditCancelAlways.Checked = ConfigurationClasses.SettingsManager.Instance.AlwaysCancelDownload;
        }

        private void FormDownloadWarning_FormClosed(object sender, FormClosedEventArgs e)
        {
            ConfigurationClasses.SettingsManager.Instance.AlwaysDownload = checkEditDownloadAlways.Checked;
            ConfigurationClasses.SettingsManager.Instance.AlwaysCancelDownload = checkEditCancelAlways.Checked;
            ConfigurationClasses.SettingsManager.Instance.SaveApplicationSettings();
        }

        private void checkEditDownloadAlways_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkEditDownloadAlways.Checked)
                checkEditCancelAlways.Checked = !checkEditDownloadAlways.Checked;
            checkEditCancelAlways.Enabled = !checkEditDownloadAlways.Checked;
            simpleButtonCancel.Enabled = !checkEditDownloadAlways.Checked;
        }

        private void checkEditCancelAlways_CheckedChanged(object sender, System.EventArgs e)
        {
            if (checkEditCancelAlways.Checked)
                checkEditDownloadAlways.Checked = !checkEditCancelAlways.Checked;
            checkEditDownloadAlways.Enabled = !checkEditCancelAlways.Checked;
            simpleButtonDownload.Enabled = !checkEditCancelAlways.Checked;
        }
    }
}