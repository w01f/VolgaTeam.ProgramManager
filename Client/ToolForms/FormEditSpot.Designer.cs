namespace ProgramManager.ToolForms
{
    partial class FormEditSpot
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
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
            this.laName = new System.Windows.Forms.Label();
            this.textEditName = new DevExpress.XtraEditors.TextEdit();
            this.laType = new System.Windows.Forms.Label();
            this.simpleButtonOK = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.pnMain = new System.Windows.Forms.Panel();
            this.textEditEpisode = new DevExpress.XtraEditors.TextEdit();
            this.checkEditEpisode = new DevExpress.XtraEditors.CheckEdit();
            this.textEditHouseNumber = new DevExpress.XtraEditors.TextEdit();
            this.checkEditHouseNumber = new DevExpress.XtraEditors.CheckEdit();
            this.laSpotHeader = new System.Windows.Forms.Label();
            this.memoEditCustomNote = new DevExpress.XtraEditors.MemoEdit();
            this.checkEditCustomNote = new DevExpress.XtraEditors.CheckEdit();
            this.textEditContractLength = new DevExpress.XtraEditors.TextEdit();
            this.checkEditContractLength = new DevExpress.XtraEditors.CheckEdit();
            this.textEditDistributor = new DevExpress.XtraEditors.TextEdit();
            this.checkEditDistributor = new DevExpress.XtraEditors.CheckEdit();
            this.textEditMovieTitle = new DevExpress.XtraEditors.TextEdit();
            this.checkEditMovieTitle = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditFCC = new DevExpress.XtraEditors.ComboBoxEdit();
            this.checkEditFCC = new DevExpress.XtraEditors.CheckEdit();
            this.comboBoxEditType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).BeginInit();
            this.pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEpisode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditEpisode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHouseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHouseNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditCustomNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCustomNote.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContractLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditContractLength.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistributor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDistributor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMovieTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMovieTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditFCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Lilian";
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
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
            // laName
            // 
            this.laName.AutoSize = true;
            this.laName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laName.Location = new System.Drawing.Point(9, 44);
            this.laName.Name = "laName";
            this.laName.Size = new System.Drawing.Size(108, 16);
            this.laName.TabIndex = 4;
            this.laName.Text = "Program Name:";
            // 
            // textEditName
            // 
            this.textEditName.Location = new System.Drawing.Point(12, 63);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(577, 22);
            this.textEditName.StyleController = this.styleController;
            this.textEditName.TabIndex = 1;
            // 
            // laType
            // 
            this.laType.AutoSize = true;
            this.laType.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laType.Location = new System.Drawing.Point(9, 97);
            this.laType.Name = "laType";
            this.laType.Size = new System.Drawing.Size(42, 16);
            this.laType.TabIndex = 2;
            this.laType.Text = "Type:";
            // 
            // simpleButtonOK
            // 
            this.simpleButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButtonOK.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonOK.Appearance.Options.UseFont = true;
            this.simpleButtonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonOK.Location = new System.Drawing.Point(184, 397);
            this.simpleButtonOK.Name = "simpleButtonOK";
            this.simpleButtonOK.Size = new System.Drawing.Size(98, 35);
            this.simpleButtonOK.StyleController = this.styleController;
            this.simpleButtonOK.TabIndex = 18;
            this.simpleButtonOK.Text = "OK";
            // 
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonCancel.Appearance.Options.UseFont = true;
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(322, 397);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(98, 35);
            this.simpleButtonCancel.StyleController = this.styleController;
            this.simpleButtonCancel.TabIndex = 19;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // pnMain
            // 
            this.pnMain.Controls.Add(this.textEditEpisode);
            this.pnMain.Controls.Add(this.checkEditEpisode);
            this.pnMain.Controls.Add(this.textEditHouseNumber);
            this.pnMain.Controls.Add(this.checkEditHouseNumber);
            this.pnMain.Controls.Add(this.laSpotHeader);
            this.pnMain.Controls.Add(this.memoEditCustomNote);
            this.pnMain.Controls.Add(this.checkEditCustomNote);
            this.pnMain.Controls.Add(this.textEditContractLength);
            this.pnMain.Controls.Add(this.checkEditContractLength);
            this.pnMain.Controls.Add(this.textEditDistributor);
            this.pnMain.Controls.Add(this.checkEditDistributor);
            this.pnMain.Controls.Add(this.textEditMovieTitle);
            this.pnMain.Controls.Add(this.checkEditMovieTitle);
            this.pnMain.Controls.Add(this.comboBoxEditFCC);
            this.pnMain.Controls.Add(this.checkEditFCC);
            this.pnMain.Controls.Add(this.comboBoxEditType);
            this.pnMain.Controls.Add(this.laName);
            this.pnMain.Controls.Add(this.textEditName);
            this.pnMain.Controls.Add(this.laType);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 0);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(604, 385);
            this.pnMain.TabIndex = 21;
            // 
            // textEditEpisode
            // 
            this.textEditEpisode.Enabled = false;
            this.textEditEpisode.Location = new System.Drawing.Point(366, 121);
            this.textEditEpisode.Name = "textEditEpisode";
            this.textEditEpisode.Size = new System.Drawing.Size(223, 22);
            this.textEditEpisode.StyleController = this.styleController;
            this.textEditEpisode.TabIndex = 7;
            // 
            // checkEditEpisode
            // 
            this.checkEditEpisode.Location = new System.Drawing.Point(364, 94);
            this.checkEditEpisode.Name = "checkEditEpisode";
            this.checkEditEpisode.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkEditEpisode.Properties.Appearance.Options.UseFont = true;
            this.checkEditEpisode.Properties.AutoWidth = true;
            this.checkEditEpisode.Properties.Caption = "Episode:";
            this.checkEditEpisode.Size = new System.Drawing.Size(76, 21);
            this.checkEditEpisode.TabIndex = 6;
            this.checkEditEpisode.CheckedChanged += new System.EventHandler(this.checkEditEpisode_CheckedChanged);
            // 
            // textEditHouseNumber
            // 
            this.textEditHouseNumber.Enabled = false;
            this.textEditHouseNumber.Location = new System.Drawing.Point(124, 121);
            this.textEditHouseNumber.Name = "textEditHouseNumber";
            this.textEditHouseNumber.Size = new System.Drawing.Size(223, 22);
            this.textEditHouseNumber.StyleController = this.styleController;
            this.textEditHouseNumber.TabIndex = 5;
            // 
            // checkEditHouseNumber
            // 
            this.checkEditHouseNumber.Location = new System.Drawing.Point(122, 94);
            this.checkEditHouseNumber.Name = "checkEditHouseNumber";
            this.checkEditHouseNumber.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkEditHouseNumber.Properties.Appearance.Options.UseFont = true;
            this.checkEditHouseNumber.Properties.AutoWidth = true;
            this.checkEditHouseNumber.Properties.Caption = "House #:";
            this.checkEditHouseNumber.Size = new System.Drawing.Size(76, 21);
            this.checkEditHouseNumber.TabIndex = 4;
            this.checkEditHouseNumber.CheckedChanged += new System.EventHandler(this.checkEditHouseNumber_CheckedChanged);
            // 
            // laSpotHeader
            // 
            this.laSpotHeader.AutoSize = true;
            this.laSpotHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laSpotHeader.Location = new System.Drawing.Point(11, 9);
            this.laSpotHeader.Name = "laSpotHeader";
            this.laSpotHeader.Size = new System.Drawing.Size(104, 19);
            this.laSpotHeader.TabIndex = 30;
            this.laSpotHeader.Text = "Spot Header";
            // 
            // memoEditCustomNote
            // 
            this.memoEditCustomNote.Enabled = false;
            this.memoEditCustomNote.Location = new System.Drawing.Point(40, 297);
            this.memoEditCustomNote.Name = "memoEditCustomNote";
            this.memoEditCustomNote.Properties.NullText = "Type Custom Notes Here...";
            this.memoEditCustomNote.Size = new System.Drawing.Size(552, 73);
            this.memoEditCustomNote.StyleController = this.styleController;
            this.memoEditCustomNote.TabIndex = 17;
            // 
            // checkEditCustomNote
            // 
            this.checkEditCustomNote.Location = new System.Drawing.Point(12, 292);
            this.checkEditCustomNote.Name = "checkEditCustomNote";
            this.checkEditCustomNote.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkEditCustomNote.Properties.Appearance.Options.UseFont = true;
            this.checkEditCustomNote.Properties.AutoWidth = true;
            this.checkEditCustomNote.Properties.Caption = "";
            this.checkEditCustomNote.Size = new System.Drawing.Size(22, 21);
            this.checkEditCustomNote.TabIndex = 16;
            this.checkEditCustomNote.CheckedChanged += new System.EventHandler(this.checkEditCustomNote_CheckedChanged);
            // 
            // textEditContractLength
            // 
            this.textEditContractLength.Enabled = false;
            this.textEditContractLength.Location = new System.Drawing.Point(365, 252);
            this.textEditContractLength.Name = "textEditContractLength";
            this.textEditContractLength.Size = new System.Drawing.Size(227, 22);
            this.textEditContractLength.StyleController = this.styleController;
            this.textEditContractLength.TabIndex = 15;
            // 
            // checkEditContractLength
            // 
            this.checkEditContractLength.Location = new System.Drawing.Point(363, 225);
            this.checkEditContractLength.Name = "checkEditContractLength";
            this.checkEditContractLength.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkEditContractLength.Properties.Appearance.Options.UseFont = true;
            this.checkEditContractLength.Properties.AutoWidth = true;
            this.checkEditContractLength.Properties.Caption = "Air Window/Contract Length:";
            this.checkEditContractLength.Size = new System.Drawing.Size(205, 21);
            this.checkEditContractLength.TabIndex = 14;
            this.checkEditContractLength.CheckedChanged += new System.EventHandler(this.checkEditContractLength_CheckedChanged);
            // 
            // textEditDistributor
            // 
            this.textEditDistributor.Enabled = false;
            this.textEditDistributor.Location = new System.Drawing.Point(14, 252);
            this.textEditDistributor.Name = "textEditDistributor";
            this.textEditDistributor.Size = new System.Drawing.Size(333, 22);
            this.textEditDistributor.StyleController = this.styleController;
            this.textEditDistributor.TabIndex = 13;
            // 
            // checkEditDistributor
            // 
            this.checkEditDistributor.Location = new System.Drawing.Point(12, 225);
            this.checkEditDistributor.Name = "checkEditDistributor";
            this.checkEditDistributor.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkEditDistributor.Properties.Appearance.Options.UseFont = true;
            this.checkEditDistributor.Properties.AutoWidth = true;
            this.checkEditDistributor.Properties.Caption = "Syndicator/Distributor:";
            this.checkEditDistributor.Size = new System.Drawing.Size(163, 21);
            this.checkEditDistributor.TabIndex = 12;
            this.checkEditDistributor.CheckedChanged += new System.EventHandler(this.checkEditDistributor_CheckedChanged);
            // 
            // textEditMovieTitle
            // 
            this.textEditMovieTitle.Enabled = false;
            this.textEditMovieTitle.Location = new System.Drawing.Point(12, 186);
            this.textEditMovieTitle.Name = "textEditMovieTitle";
            this.textEditMovieTitle.Size = new System.Drawing.Size(333, 22);
            this.textEditMovieTitle.StyleController = this.styleController;
            this.textEditMovieTitle.TabIndex = 9;
            // 
            // checkEditMovieTitle
            // 
            this.checkEditMovieTitle.Location = new System.Drawing.Point(10, 159);
            this.checkEditMovieTitle.Name = "checkEditMovieTitle";
            this.checkEditMovieTitle.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkEditMovieTitle.Properties.Appearance.Options.UseFont = true;
            this.checkEditMovieTitle.Properties.AutoWidth = true;
            this.checkEditMovieTitle.Properties.Caption = "Movie Title:";
            this.checkEditMovieTitle.Size = new System.Drawing.Size(96, 21);
            this.checkEditMovieTitle.TabIndex = 8;
            this.checkEditMovieTitle.CheckedChanged += new System.EventHandler(this.checkEditMovietitle_CheckedChanged);
            // 
            // comboBoxEditFCC
            // 
            this.comboBoxEditFCC.Enabled = false;
            this.comboBoxEditFCC.Location = new System.Drawing.Point(365, 186);
            this.comboBoxEditFCC.Name = "comboBoxEditFCC";
            this.comboBoxEditFCC.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditFCC.Properties.NullText = "Select...";
            this.comboBoxEditFCC.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditFCC.Size = new System.Drawing.Size(226, 22);
            this.comboBoxEditFCC.StyleController = this.styleController;
            this.comboBoxEditFCC.TabIndex = 11;
            // 
            // checkEditFCC
            // 
            this.checkEditFCC.Location = new System.Drawing.Point(364, 159);
            this.checkEditFCC.Name = "checkEditFCC";
            this.checkEditFCC.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkEditFCC.Properties.Appearance.Options.UseFont = true;
            this.checkEditFCC.Properties.AutoWidth = true;
            this.checkEditFCC.Properties.Caption = "E/I:";
            this.checkEditFCC.Size = new System.Drawing.Size(42, 21);
            this.checkEditFCC.TabIndex = 10;
            this.checkEditFCC.CheckedChanged += new System.EventHandler(this.checkEditFCC_CheckedChanged);
            // 
            // comboBoxEditType
            // 
            this.comboBoxEditType.Location = new System.Drawing.Point(12, 121);
            this.comboBoxEditType.Name = "comboBoxEditType";
            this.comboBoxEditType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditType.Properties.NullText = "Select...";
            this.comboBoxEditType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditType.Size = new System.Drawing.Size(86, 22);
            this.comboBoxEditType.StyleController = this.styleController;
            this.comboBoxEditType.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 385);
            this.panel1.TabIndex = 1;
            // 
            // FormEditSpot
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(604, 438);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonOK);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEditSpot";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEditSpot_FormClosed);
            this.Load += new System.EventHandler(this.FormEditSpot_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditName.Properties)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditEpisode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditEpisode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditHouseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditHouseNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEditCustomNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditCustomNote.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditContractLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditContractLength.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDistributor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditDistributor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditMovieTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditMovieTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditFCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditType.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevExpress.XtraEditors.StyleController styleController;
        private System.Windows.Forms.Label laName;
        private DevExpress.XtraEditors.TextEdit textEditName;
        private System.Windows.Forms.Label laType;
        private DevExpress.XtraEditors.SimpleButton simpleButtonOK;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditType;
        private DevExpress.XtraEditors.MemoEdit memoEditCustomNote;
        private DevExpress.XtraEditors.CheckEdit checkEditCustomNote;
        private DevExpress.XtraEditors.TextEdit textEditContractLength;
        private DevExpress.XtraEditors.CheckEdit checkEditContractLength;
        private DevExpress.XtraEditors.TextEdit textEditDistributor;
        private DevExpress.XtraEditors.CheckEdit checkEditDistributor;
        private DevExpress.XtraEditors.TextEdit textEditMovieTitle;
        private DevExpress.XtraEditors.CheckEdit checkEditMovieTitle;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditFCC;
        private DevExpress.XtraEditors.CheckEdit checkEditFCC;
        private DevExpress.XtraEditors.TextEdit textEditEpisode;
        private DevExpress.XtraEditors.CheckEdit checkEditEpisode;
        private DevExpress.XtraEditors.TextEdit textEditHouseNumber;
        private DevExpress.XtraEditors.CheckEdit checkEditHouseNumber;
        private System.Windows.Forms.Label laSpotHeader;
    }
}