namespace ProgramManager.Client.ToolForms
{
    partial class FormOutputParameters
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOutputParameters));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.simpleButtonDownload = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
            this.simpleButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.laWeekStart = new System.Windows.Forms.Label();
            this.dateEditWeekStart = new DevExpress.XtraEditors.DateEdit();
            this.laWeekEnd = new System.Windows.Forms.Label();
            this.laStationTitle = new System.Windows.Forms.Label();
            this.comboBoxEditStation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBoxSelectWeeks = new System.Windows.Forms.GroupBox();
            this.gridControlWeeks = new DevExpress.XtraGrid.GridControl();
            this.gridViewWeeks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnWeek = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.simpleButtonAddWeek = new DevExpress.XtraEditors.SimpleButton();
            this.groupBoxOrientation = new System.Windows.Forms.GroupBox();
            this.checkButtonPortrait = new DevExpress.XtraEditors.CheckButton();
            this.checkButtonLandscape = new DevExpress.XtraEditors.CheckButton();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeekStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeekStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStation.Properties)).BeginInit();
            this.groupBoxSelectWeeks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).BeginInit();
            this.groupBoxOrientation.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // simpleButtonDownload
            // 
            this.simpleButtonDownload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonDownload.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonDownload.Appearance.Options.UseFont = true;
            this.simpleButtonDownload.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonDownload.Location = new System.Drawing.Point(268, 5);
            this.simpleButtonDownload.Name = "simpleButtonDownload";
            this.simpleButtonDownload.Size = new System.Drawing.Size(101, 33);
            this.simpleButtonDownload.TabIndex = 1;
            this.simpleButtonDownload.Text = "Output";
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
            // simpleButtonCancel
            // 
            this.simpleButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonCancel.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonCancel.Appearance.Options.UseFont = true;
            this.simpleButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.simpleButtonCancel.Location = new System.Drawing.Point(268, 54);
            this.simpleButtonCancel.Name = "simpleButtonCancel";
            this.simpleButtonCancel.Size = new System.Drawing.Size(101, 33);
            this.simpleButtonCancel.TabIndex = 3;
            this.simpleButtonCancel.Text = "Cancel";
            // 
            // laWeekStart
            // 
            this.laWeekStart.AutoSize = true;
            this.laWeekStart.Location = new System.Drawing.Point(6, 29);
            this.laWeekStart.Name = "laWeekStart";
            this.laWeekStart.Size = new System.Drawing.Size(58, 16);
            this.laWeekStart.TabIndex = 5;
            this.laWeekStart.Text = "Monday:";
            // 
            // dateEditWeekStart
            // 
            this.dateEditWeekStart.EditValue = null;
            this.dateEditWeekStart.Location = new System.Drawing.Point(70, 26);
            this.dateEditWeekStart.Name = "dateEditWeekStart";
            this.dateEditWeekStart.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditWeekStart.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEditWeekStart.Properties.Appearance.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceDropDownHighlight.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceFocused.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.dateEditWeekStart.Properties.AppearanceWeekNumber.Font = new System.Drawing.Font("Arial", 9.75F);
            this.dateEditWeekStart.Properties.AppearanceWeekNumber.Options.UseFont = true;
            this.dateEditWeekStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("dateEditWeekStart.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.dateEditWeekStart.Properties.DisplayFormat.FormatString = "MM/dd/yy";
            this.dateEditWeekStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditWeekStart.Properties.EditFormat.FormatString = "MM/dd/yy";
            this.dateEditWeekStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditWeekStart.Properties.HideSelection = false;
            this.dateEditWeekStart.Properties.ShowToday = false;
            this.dateEditWeekStart.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditWeekStart.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditWeekStart.Size = new System.Drawing.Size(114, 22);
            this.dateEditWeekStart.StyleController = this.styleController;
            this.dateEditWeekStart.TabIndex = 6;
            this.dateEditWeekStart.DrawItem += new DevExpress.XtraEditors.Calendar.CustomDrawDayNumberCellEventHandler(this.dateEditWeekStart_DrawItem);
            this.dateEditWeekStart.CloseUp += new DevExpress.XtraEditors.Controls.CloseUpEventHandler(this.dateEditWeekStart_CloseUp);
            this.dateEditWeekStart.EditValueChanged += new System.EventHandler(this.dateEditWeekStart_EditValueChanged);
            // 
            // laWeekEnd
            // 
            this.laWeekEnd.AutoSize = true;
            this.laWeekEnd.Location = new System.Drawing.Point(6, 63);
            this.laWeekEnd.Name = "laWeekEnd";
            this.laWeekEnd.Size = new System.Drawing.Size(56, 16);
            this.laWeekEnd.TabIndex = 7;
            this.laWeekEnd.Text = "Sunday:";
            // 
            // laStationTitle
            // 
            this.laStationTitle.AutoSize = true;
            this.laStationTitle.Location = new System.Drawing.Point(11, 8);
            this.laStationTitle.Name = "laStationTitle";
            this.laStationTitle.Size = new System.Drawing.Size(94, 16);
            this.laStationTitle.TabIndex = 8;
            this.laStationTitle.Text = "Select Station:";
            // 
            // comboBoxEditStation
            // 
            this.comboBoxEditStation.Location = new System.Drawing.Point(113, 5);
            this.comboBoxEditStation.Name = "comboBoxEditStation";
            this.comboBoxEditStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditStation.Properties.NullText = "Select...";
            this.comboBoxEditStation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditStation.Size = new System.Drawing.Size(119, 22);
            this.comboBoxEditStation.StyleController = this.styleController;
            this.comboBoxEditStation.TabIndex = 9;
            // 
            // groupBoxSelectWeeks
            // 
            this.groupBoxSelectWeeks.Controls.Add(this.gridControlWeeks);
            this.groupBoxSelectWeeks.Controls.Add(this.simpleButtonAddWeek);
            this.groupBoxSelectWeeks.Controls.Add(this.laWeekStart);
            this.groupBoxSelectWeeks.Controls.Add(this.dateEditWeekStart);
            this.groupBoxSelectWeeks.Controls.Add(this.laWeekEnd);
            this.groupBoxSelectWeeks.Location = new System.Drawing.Point(5, 39);
            this.groupBoxSelectWeeks.Name = "groupBoxSelectWeeks";
            this.groupBoxSelectWeeks.Size = new System.Drawing.Size(253, 261);
            this.groupBoxSelectWeeks.TabIndex = 10;
            this.groupBoxSelectWeeks.TabStop = false;
            this.groupBoxSelectWeeks.Text = "Select Weeks:";
            // 
            // gridControlWeeks
            // 
            this.gridControlWeeks.AllowDrop = true;
            this.gridControlWeeks.Location = new System.Drawing.Point(9, 85);
            this.gridControlWeeks.MainView = this.gridViewWeeks;
            this.gridControlWeeks.Name = "gridControlWeeks";
            this.gridControlWeeks.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit});
            this.gridControlWeeks.Size = new System.Drawing.Size(236, 170);
            this.gridControlWeeks.TabIndex = 9;
            this.gridControlWeeks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewWeeks});
            // 
            // gridViewWeeks
            // 
            this.gridViewWeeks.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewWeeks.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewWeeks.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gridViewWeeks.Appearance.Row.Options.UseFont = true;
            this.gridViewWeeks.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewWeeks.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewWeeks.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnWeek});
            this.gridViewWeeks.GridControl = this.gridControlWeeks;
            this.gridViewWeeks.Name = "gridViewWeeks";
            this.gridViewWeeks.OptionsCustomization.AllowColumnMoving = false;
            this.gridViewWeeks.OptionsCustomization.AllowColumnResizing = false;
            this.gridViewWeeks.OptionsCustomization.AllowFilter = false;
            this.gridViewWeeks.OptionsCustomization.AllowGroup = false;
            this.gridViewWeeks.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewWeeks.OptionsCustomization.AllowSort = false;
            this.gridViewWeeks.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewWeeks.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gridViewWeeks.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewWeeks.OptionsView.RowAutoHeight = true;
            this.gridViewWeeks.OptionsView.ShowColumnHeaders = false;
            this.gridViewWeeks.OptionsView.ShowDetailButtons = false;
            this.gridViewWeeks.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewWeeks.OptionsView.ShowGroupPanel = false;
            this.gridViewWeeks.OptionsView.ShowIndicator = false;
            // 
            // gridColumnWeek
            // 
            this.gridColumnWeek.Caption = "gridColumnWeek";
            this.gridColumnWeek.ColumnEdit = this.repositoryItemButtonEdit;
            this.gridColumnWeek.FieldName = "Caption";
            this.gridColumnWeek.Name = "gridColumnWeek";
            this.gridColumnWeek.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumnWeek.Visible = true;
            this.gridColumnWeek.VisibleIndex = 0;
            // 
            // repositoryItemButtonEdit
            // 
            this.repositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit";
            this.repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemButtonEdit.Click += new System.EventHandler(this.repositoryItemButtonEdit_Click);
            // 
            // simpleButtonAddWeek
            // 
            this.simpleButtonAddWeek.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonAddWeek.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonAddWeek.Appearance.Options.UseFont = true;
            this.simpleButtonAddWeek.Image = global::ProgramManager.Client.Properties.Resources.AddWeek;
            this.simpleButtonAddWeek.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButtonAddWeek.Location = new System.Drawing.Point(190, 25);
            this.simpleButtonAddWeek.Name = "simpleButtonAddWeek";
            this.simpleButtonAddWeek.Size = new System.Drawing.Size(55, 54);
            this.simpleButtonAddWeek.TabIndex = 8;
            this.simpleButtonAddWeek.Text = "Add";
            this.simpleButtonAddWeek.Click += new System.EventHandler(this.simpleButtonAddWeek_Click);
            // 
            // groupBoxOrientation
            // 
            this.groupBoxOrientation.Controls.Add(this.checkButtonPortrait);
            this.groupBoxOrientation.Controls.Add(this.checkButtonLandscape);
            this.groupBoxOrientation.Location = new System.Drawing.Point(5, 318);
            this.groupBoxOrientation.Name = "groupBoxOrientation";
            this.groupBoxOrientation.Size = new System.Drawing.Size(253, 69);
            this.groupBoxOrientation.TabIndex = 11;
            this.groupBoxOrientation.TabStop = false;
            this.groupBoxOrientation.Text = "Orientation";
            // 
            // checkButtonPortrait
            // 
            this.checkButtonPortrait.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkButtonPortrait.Appearance.Options.UseFont = true;
            this.checkButtonPortrait.GroupIndex = 1;
            this.checkButtonPortrait.Location = new System.Drawing.Point(162, 23);
            this.checkButtonPortrait.Name = "checkButtonPortrait";
            this.checkButtonPortrait.Size = new System.Drawing.Size(83, 33);
            this.checkButtonPortrait.TabIndex = 1;
            this.checkButtonPortrait.TabStop = false;
            this.checkButtonPortrait.Text = "Portrait";
            // 
            // checkButtonLandscape
            // 
            this.checkButtonLandscape.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkButtonLandscape.Appearance.Options.UseFont = true;
            this.checkButtonLandscape.Checked = true;
            this.checkButtonLandscape.GroupIndex = 1;
            this.checkButtonLandscape.Location = new System.Drawing.Point(9, 23);
            this.checkButtonLandscape.Name = "checkButtonLandscape";
            this.checkButtonLandscape.Size = new System.Drawing.Size(83, 33);
            this.checkButtonLandscape.TabIndex = 0;
            this.checkButtonLandscape.Text = "Landscape";
            // 
            // FormOutputParameters
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(374, 399);
            this.Controls.Add(this.groupBoxOrientation);
            this.Controls.Add(this.groupBoxSelectWeeks);
            this.Controls.Add(this.comboBoxEditStation);
            this.Controls.Add(this.laStationTitle);
            this.Controls.Add(this.simpleButtonCancel);
            this.Controls.Add(this.simpleButtonDownload);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOutputParameters";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Output";
            this.Load += new System.EventHandler(this.FormOutputParameters_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeekStart.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeekStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStation.Properties)).EndInit();
            this.groupBoxSelectWeeks.ResumeLayout(false);
            this.groupBoxSelectWeeks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWeeks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).EndInit();
            this.groupBoxOrientation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevExpress.XtraEditors.SimpleButton simpleButtonDownload;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevExpress.XtraEditors.StyleController styleController;
        private DevExpress.XtraEditors.SimpleButton simpleButtonCancel;
        private System.Windows.Forms.Label laWeekStart;
        public DevExpress.XtraEditors.DateEdit dateEditWeekStart;
        private System.Windows.Forms.Label laWeekEnd;
        private System.Windows.Forms.Label laStationTitle;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditStation;
        private System.Windows.Forms.GroupBox groupBoxSelectWeeks;
        private DevExpress.XtraEditors.SimpleButton simpleButtonAddWeek;
        private DevExpress.XtraGrid.GridControl gridControlWeeks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewWeeks;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnWeek;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private System.Windows.Forms.GroupBox groupBoxOrientation;
        private DevExpress.XtraEditors.CheckButton checkButtonPortrait;
        private DevExpress.XtraEditors.CheckButton checkButtonLandscape;
    }
}