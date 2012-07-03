namespace ProgramManager.Client.ToolForms
{
    partial class FormDownloadWarning
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.laDescription = new System.Windows.Forms.Label();
            this.simpleButtonDownload = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
            this.checkEditDownloadAlways = new DevExpress.XtraEditors.CheckEdit();
            this.checkEditCancelAlways = new DevExpress.XtraEditors.CheckEdit();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDownloadAlways.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCancelAlways.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // laDescription
            // 
            this.laDescription.Location = new System.Drawing.Point(8, 11);
            this.laDescription.Name = "laDescription";
            this.laDescription.Size = new System.Drawing.Size(317, 89);
            this.laDescription.TabIndex = 0;
            this.laDescription.Text = "There are newer data on a server. \r\n\r\nDo you want to download the latest data and" +
    " discard possible local changes?";
            this.laDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simpleButtonDownload
            // 
            this.simpleButtonDownload.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonDownload.Appearance.Options.UseFont = true;
            this.simpleButtonDownload.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonDownload.Location = new System.Drawing.Point(8, 130);
            this.simpleButtonDownload.Name = "simpleButtonDownload";
            this.simpleButtonDownload.Size = new System.Drawing.Size(143, 39);
            this.simpleButtonDownload.TabIndex = 1;
            this.simpleButtonDownload.Text = "Download";
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Lilian";
            // 
            // styleController
            // 
            this.styleController.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.styleController.Appearance.Options.UseFont = true;
            this.styleController.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.styleController.AppearanceDisabled.Options.UseFont = true;
            this.styleController.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
            this.styleController.AppearanceDropDown.Options.UseFont = true;
            this.styleController.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.styleController.AppearanceDropDownHeader.Options.UseFont = true;
            this.styleController.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.styleController.AppearanceFocused.Options.UseFont = true;
            this.styleController.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.styleController.AppearanceReadOnly.Options.UseFont = true;
            // 
            // checkEditDownloadAlways
            // 
            this.checkEditDownloadAlways.Location = new System.Drawing.Point(6, 103);
            this.checkEditDownloadAlways.Name = "checkEditDownloadAlways";
            this.checkEditDownloadAlways.Properties.Caption = "Download always";
            this.checkEditDownloadAlways.Size = new System.Drawing.Size(145, 21);
            this.checkEditDownloadAlways.StyleController = this.styleController;
            this.checkEditDownloadAlways.TabIndex = 2;
            this.checkEditDownloadAlways.CheckedChanged += new System.EventHandler(this.checkEditDownloadAlways_CheckedChanged);
            // 
            // checkEditCancelAlways
            // 
            this.checkEditCancelAlways.Location = new System.Drawing.Point(180, 103);
            this.checkEditCancelAlways.Name = "checkEditCancelAlways";
            this.checkEditCancelAlways.Properties.Caption = "Cancel always";
            this.checkEditCancelAlways.Size = new System.Drawing.Size(145, 21);
            this.checkEditCancelAlways.StyleController = this.styleController;
            this.checkEditCancelAlways.TabIndex = 4;
            this.checkEditCancelAlways.CheckedChanged += new System.EventHandler(this.checkEditCancelAlways_CheckedChanged);
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonCancel.Appearance.Options.UseFont = true;
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(182, 130);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(143, 39);
            this.simpleButtonCancel.TabIndex = 3;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // FormDownloadWarning
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(334, 174);
            this.Controls.Add(this.checkEditCancelAlways);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.checkEditDownloadAlways);
            this.Controls.Add(this.simpleButtonDownload);
            this.Controls.Add(this.laDescription);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDownloadWarning";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Stations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDownloadWarning_FormClosed);
            this.Load += new System.EventHandler(this.FormDownloadWarning_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDownloadAlways.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCancelAlways.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private System.Windows.Forms.Label laDescription;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDownload;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.StyleController styleController;
        private DevExpress.XtraEditors.CheckEdit checkEditDownloadAlways;
        private DevExpress.XtraEditors.CheckEdit checkEditCancelAlways;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
    }
}