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
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPageSchedule = new DevExpress.XtraTab.XtraTabPage();
            this.pnSchedule = new System.Windows.Forms.Panel();
            this.xtraTabPageTextSettings = new DevExpress.XtraTab.XtraTabPage();
            this.pnTextSettings = new System.Windows.Forms.Panel();
            this.groupBoxSpecialFont = new System.Windows.Forms.GroupBox();
            this.timeEditSundayPrimeTimeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.timeEditSundayPrimeTimeStart = new DevExpress.XtraEditors.TimeEdit();
            this.laSundayPrimeTime = new System.Windows.Forms.Label();
            this.timeEditWeekPrimeTimeEnd = new DevExpress.XtraEditors.TimeEdit();
            this.timeEditWeekPrimeTimeStart = new DevExpress.XtraEditors.TimeEdit();
            this.checkEditPrimeTimeSpecialFontSize = new DevExpress.XtraEditors.CheckEdit();
            this.laWeekPrimeTime = new System.Windows.Forms.Label();
            this.laBodyFont = new System.Windows.Forms.Label();
            this.comboBoxEditBodyFont = new DevExpress.XtraEditors.ComboBoxEdit();
            this.laFooterFont = new System.Windows.Forms.Label();
            this.comboBoxEditFooterFont = new DevExpress.XtraEditors.ComboBoxEdit();
            this.laHeaderFont = new System.Windows.Forms.Label();
            this.comboBoxEditHeaderFont = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeekStart.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditWeekStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditStation.Properties)).BeginInit();
            this.groupBoxSelectWeeks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewWeeks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).BeginInit();
            this.groupBoxOrientation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.xtraTabControl.SuspendLayout();
            this.xtraTabPageSchedule.SuspendLayout();
            this.pnSchedule.SuspendLayout();
            this.xtraTabPageTextSettings.SuspendLayout();
            this.pnTextSettings.SuspendLayout();
            this.groupBoxSpecialFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditSundayPrimeTimeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditSundayPrimeTimeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditWeekPrimeTimeEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditWeekPrimeTimeStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPrimeTimeSpecialFontSize.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBodyFont.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFooterFont.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHeaderFont.Properties)).BeginInit();
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
            this.simpleButtonDownload.Location = new System.Drawing.Point(349, 5);
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
            this.simpleButtonCancel.Location = new System.Drawing.Point(349, 54);
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
            this.laStationTitle.Location = new System.Drawing.Point(13, 10);
            this.laStationTitle.Name = "laStationTitle";
            this.laStationTitle.Size = new System.Drawing.Size(94, 16);
            this.laStationTitle.TabIndex = 8;
            this.laStationTitle.Text = "Select Station:";
            // 
            // comboBoxEditStation
            // 
            this.comboBoxEditStation.Location = new System.Drawing.Point(115, 7);
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
            this.groupBoxSelectWeeks.Location = new System.Drawing.Point(7, 41);
            this.groupBoxSelectWeeks.Name = "groupBoxSelectWeeks";
            this.groupBoxSelectWeeks.Size = new System.Drawing.Size(317, 261);
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
            this.gridControlWeeks.Size = new System.Drawing.Size(300, 170);
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
            this.simpleButtonAddWeek.Size = new System.Drawing.Size(119, 54);
            this.simpleButtonAddWeek.TabIndex = 8;
            this.simpleButtonAddWeek.Text = "Add";
            this.simpleButtonAddWeek.Click += new System.EventHandler(this.simpleButtonAddWeek_Click);
            // 
            // groupBoxOrientation
            // 
            this.groupBoxOrientation.Controls.Add(this.checkButtonPortrait);
            this.groupBoxOrientation.Controls.Add(this.checkButtonLandscape);
            this.groupBoxOrientation.Location = new System.Drawing.Point(7, 320);
            this.groupBoxOrientation.Name = "groupBoxOrientation";
            this.groupBoxOrientation.Size = new System.Drawing.Size(317, 69);
            this.groupBoxOrientation.TabIndex = 11;
            this.groupBoxOrientation.TabStop = false;
            this.groupBoxOrientation.Text = "Orientation";
            // 
            // checkButtonPortrait
            // 
            this.checkButtonPortrait.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkButtonPortrait.Appearance.Options.UseFont = true;
            this.checkButtonPortrait.GroupIndex = 1;
            this.checkButtonPortrait.Location = new System.Drawing.Point(200, 23);
            this.checkButtonPortrait.Name = "checkButtonPortrait";
            this.checkButtonPortrait.Size = new System.Drawing.Size(109, 33);
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
            this.checkButtonLandscape.Size = new System.Drawing.Size(109, 33);
            this.checkButtonLandscape.TabIndex = 0;
            this.checkButtonLandscape.Text = "Landscape";
            // 
            // xtraTabControl
            // 
            this.xtraTabControl.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xtraTabControl.Appearance.Options.UseFont = true;
            this.xtraTabControl.AppearancePage.Header.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.Header.Options.UseFont = true;
            this.xtraTabControl.AppearancePage.HeaderActive.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.xtraTabControl.AppearancePage.HeaderActive.Options.UseFont = true;
            this.xtraTabControl.AppearancePage.HeaderDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xtraTabControl.AppearancePage.HeaderDisabled.Options.UseFont = true;
            this.xtraTabControl.AppearancePage.HeaderHotTracked.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xtraTabControl.AppearancePage.HeaderHotTracked.Options.UseFont = true;
            this.xtraTabControl.AppearancePage.PageClient.Font = new System.Drawing.Font("Arial", 9.75F);
            this.xtraTabControl.AppearancePage.PageClient.Options.UseFont = true;
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.xtraTabControl.Location = new System.Drawing.Point(2, 2);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.SelectedTabPage = this.xtraTabPageSchedule;
            this.xtraTabControl.Size = new System.Drawing.Size(341, 431);
            this.xtraTabControl.TabIndex = 12;
            this.xtraTabControl.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPageSchedule,
            this.xtraTabPageTextSettings});
            // 
            // xtraTabPageSchedule
            // 
            this.xtraTabPageSchedule.Controls.Add(this.pnSchedule);
            this.xtraTabPageSchedule.Name = "xtraTabPageSchedule";
            this.xtraTabPageSchedule.Size = new System.Drawing.Size(333, 399);
            this.xtraTabPageSchedule.Text = "Schedule";
            // 
            // pnSchedule
            // 
            this.pnSchedule.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.pnSchedule.Controls.Add(this.laStationTitle);
            this.pnSchedule.Controls.Add(this.groupBoxOrientation);
            this.pnSchedule.Controls.Add(this.comboBoxEditStation);
            this.pnSchedule.Controls.Add(this.groupBoxSelectWeeks);
            this.pnSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSchedule.Location = new System.Drawing.Point(0, 0);
            this.pnSchedule.Name = "pnSchedule";
            this.pnSchedule.Size = new System.Drawing.Size(333, 399);
            this.pnSchedule.TabIndex = 1;
            // 
            // xtraTabPageTextSettings
            // 
            this.xtraTabPageTextSettings.Controls.Add(this.pnTextSettings);
            this.xtraTabPageTextSettings.Name = "xtraTabPageTextSettings";
            this.xtraTabPageTextSettings.Size = new System.Drawing.Size(333, 399);
            this.xtraTabPageTextSettings.Text = "Text Settings";
            // 
            // pnTextSettings
            // 
            this.pnTextSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.pnTextSettings.Controls.Add(this.groupBoxSpecialFont);
            this.pnTextSettings.Controls.Add(this.laBodyFont);
            this.pnTextSettings.Controls.Add(this.comboBoxEditBodyFont);
            this.pnTextSettings.Controls.Add(this.laFooterFont);
            this.pnTextSettings.Controls.Add(this.comboBoxEditFooterFont);
            this.pnTextSettings.Controls.Add(this.laHeaderFont);
            this.pnTextSettings.Controls.Add(this.comboBoxEditHeaderFont);
            this.pnTextSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTextSettings.Location = new System.Drawing.Point(0, 0);
            this.pnTextSettings.Name = "pnTextSettings";
            this.pnTextSettings.Size = new System.Drawing.Size(333, 399);
            this.pnTextSettings.TabIndex = 0;
            // 
            // groupBoxSpecialFont
            // 
            this.groupBoxSpecialFont.Controls.Add(this.timeEditSundayPrimeTimeEnd);
            this.groupBoxSpecialFont.Controls.Add(this.timeEditSundayPrimeTimeStart);
            this.groupBoxSpecialFont.Controls.Add(this.laSundayPrimeTime);
            this.groupBoxSpecialFont.Controls.Add(this.timeEditWeekPrimeTimeEnd);
            this.groupBoxSpecialFont.Controls.Add(this.timeEditWeekPrimeTimeStart);
            this.groupBoxSpecialFont.Controls.Add(this.checkEditPrimeTimeSpecialFontSize);
            this.groupBoxSpecialFont.Controls.Add(this.laWeekPrimeTime);
            this.groupBoxSpecialFont.Location = new System.Drawing.Point(6, 137);
            this.groupBoxSpecialFont.Name = "groupBoxSpecialFont";
            this.groupBoxSpecialFont.Size = new System.Drawing.Size(318, 109);
            this.groupBoxSpecialFont.TabIndex = 8;
            this.groupBoxSpecialFont.TabStop = false;
            // 
            // timeEditSundayPrimeTimeEnd
            // 
            this.timeEditSundayPrimeTimeEnd.EditValue = new System.DateTime(2012, 6, 11, 0, 0, 0, 0);
            this.timeEditSundayPrimeTimeEnd.Enabled = false;
            this.timeEditSundayPrimeTimeEnd.Location = new System.Drawing.Point(230, 71);
            this.timeEditSundayPrimeTimeEnd.Name = "timeEditSundayPrimeTimeEnd";
            this.timeEditSundayPrimeTimeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEditSundayPrimeTimeEnd.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeEditSundayPrimeTimeEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditSundayPrimeTimeEnd.Properties.EditFormat.FormatString = "hh:mm tt";
            this.timeEditSundayPrimeTimeEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditSundayPrimeTimeEnd.Properties.EditValueChangedDelay = 10000;
            this.timeEditSundayPrimeTimeEnd.Properties.Mask.EditMask = "hh:mm tt";
            this.timeEditSundayPrimeTimeEnd.Size = new System.Drawing.Size(82, 22);
            this.timeEditSundayPrimeTimeEnd.StyleController = this.styleController;
            this.timeEditSundayPrimeTimeEnd.TabIndex = 20;
            // 
            // timeEditSundayPrimeTimeStart
            // 
            this.timeEditSundayPrimeTimeStart.EditValue = new System.DateTime(2012, 6, 11, 0, 0, 0, 0);
            this.timeEditSundayPrimeTimeStart.Enabled = false;
            this.timeEditSundayPrimeTimeStart.Location = new System.Drawing.Point(137, 71);
            this.timeEditSundayPrimeTimeStart.Name = "timeEditSundayPrimeTimeStart";
            this.timeEditSundayPrimeTimeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEditSundayPrimeTimeStart.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeEditSundayPrimeTimeStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditSundayPrimeTimeStart.Properties.EditFormat.FormatString = "hh:mm tt";
            this.timeEditSundayPrimeTimeStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditSundayPrimeTimeStart.Properties.EditValueChangedDelay = 10000;
            this.timeEditSundayPrimeTimeStart.Properties.Mask.EditMask = "hh:mm tt";
            this.timeEditSundayPrimeTimeStart.Size = new System.Drawing.Size(82, 22);
            this.timeEditSundayPrimeTimeStart.StyleController = this.styleController;
            this.timeEditSundayPrimeTimeStart.TabIndex = 19;
            // 
            // laSundayPrimeTime
            // 
            this.laSundayPrimeTime.AutoSize = true;
            this.laSundayPrimeTime.Enabled = false;
            this.laSundayPrimeTime.Location = new System.Drawing.Point(74, 74);
            this.laSundayPrimeTime.Name = "laSundayPrimeTime";
            this.laSundayPrimeTime.Size = new System.Drawing.Size(56, 16);
            this.laSundayPrimeTime.TabIndex = 18;
            this.laSundayPrimeTime.Text = "Sunday:";
            // 
            // timeEditWeekPrimeTimeEnd
            // 
            this.timeEditWeekPrimeTimeEnd.EditValue = new System.DateTime(2012, 6, 11, 0, 0, 0, 0);
            this.timeEditWeekPrimeTimeEnd.Enabled = false;
            this.timeEditWeekPrimeTimeEnd.Location = new System.Drawing.Point(230, 43);
            this.timeEditWeekPrimeTimeEnd.Name = "timeEditWeekPrimeTimeEnd";
            this.timeEditWeekPrimeTimeEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEditWeekPrimeTimeEnd.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeEditWeekPrimeTimeEnd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditWeekPrimeTimeEnd.Properties.EditFormat.FormatString = "hh:mm tt";
            this.timeEditWeekPrimeTimeEnd.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditWeekPrimeTimeEnd.Properties.EditValueChangedDelay = 10000;
            this.timeEditWeekPrimeTimeEnd.Properties.Mask.EditMask = "hh:mm tt";
            this.timeEditWeekPrimeTimeEnd.Size = new System.Drawing.Size(82, 22);
            this.timeEditWeekPrimeTimeEnd.StyleController = this.styleController;
            this.timeEditWeekPrimeTimeEnd.TabIndex = 17;
            // 
            // timeEditWeekPrimeTimeStart
            // 
            this.timeEditWeekPrimeTimeStart.EditValue = new System.DateTime(2012, 6, 11, 0, 0, 0, 0);
            this.timeEditWeekPrimeTimeStart.Enabled = false;
            this.timeEditWeekPrimeTimeStart.Location = new System.Drawing.Point(137, 43);
            this.timeEditWeekPrimeTimeStart.Name = "timeEditWeekPrimeTimeStart";
            this.timeEditWeekPrimeTimeStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.timeEditWeekPrimeTimeStart.Properties.DisplayFormat.FormatString = "hh:mm tt";
            this.timeEditWeekPrimeTimeStart.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditWeekPrimeTimeStart.Properties.EditFormat.FormatString = "hh:mm tt";
            this.timeEditWeekPrimeTimeStart.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.timeEditWeekPrimeTimeStart.Properties.EditValueChangedDelay = 10000;
            this.timeEditWeekPrimeTimeStart.Properties.Mask.EditMask = "hh:mm tt";
            this.timeEditWeekPrimeTimeStart.Size = new System.Drawing.Size(82, 22);
            this.timeEditWeekPrimeTimeStart.StyleController = this.styleController;
            this.timeEditWeekPrimeTimeStart.TabIndex = 16;
            // 
            // checkEditPrimeTimeSpecialFontSize
            // 
            this.checkEditPrimeTimeSpecialFontSize.Location = new System.Drawing.Point(7, 12);
            this.checkEditPrimeTimeSpecialFontSize.Name = "checkEditPrimeTimeSpecialFontSize";
            this.checkEditPrimeTimeSpecialFontSize.Properties.AutoWidth = true;
            this.checkEditPrimeTimeSpecialFontSize.Properties.Caption = "Use Size 8 FONT for Prime Time";
            this.checkEditPrimeTimeSpecialFontSize.Size = new System.Drawing.Size(212, 21);
            this.checkEditPrimeTimeSpecialFontSize.StyleController = this.styleController;
            this.checkEditPrimeTimeSpecialFontSize.TabIndex = 6;
            this.checkEditPrimeTimeSpecialFontSize.CheckedChanged += new System.EventHandler(this.checkEditSpecialFontSize_CheckedChanged);
            // 
            // laWeekPrimeTime
            // 
            this.laWeekPrimeTime.AutoSize = true;
            this.laWeekPrimeTime.Enabled = false;
            this.laWeekPrimeTime.Location = new System.Drawing.Point(17, 46);
            this.laWeekPrimeTime.Name = "laWeekPrimeTime";
            this.laWeekPrimeTime.Size = new System.Drawing.Size(114, 16);
            this.laWeekPrimeTime.TabIndex = 7;
            this.laWeekPrimeTime.Text = "Monday-Saturday:";
            // 
            // laBodyFont
            // 
            this.laBodyFont.AutoSize = true;
            this.laBodyFont.Location = new System.Drawing.Point(3, 104);
            this.laBodyFont.Name = "laBodyFont";
            this.laBodyFont.Size = new System.Drawing.Size(72, 16);
            this.laBodyFont.TabIndex = 5;
            this.laBodyFont.Text = "Body Font:";
            // 
            // comboBoxEditBodyFont
            // 
            this.comboBoxEditBodyFont.Location = new System.Drawing.Point(111, 101);
            this.comboBoxEditBodyFont.Name = "comboBoxEditBodyFont";
            this.comboBoxEditBodyFont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditBodyFont.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditBodyFont.Size = new System.Drawing.Size(207, 22);
            this.comboBoxEditBodyFont.StyleController = this.styleController;
            this.comboBoxEditBodyFont.TabIndex = 4;
            this.comboBoxEditBodyFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditBodyFont_SelectedIndexChanged);
            // 
            // laFooterFont
            // 
            this.laFooterFont.AutoSize = true;
            this.laFooterFont.Location = new System.Drawing.Point(3, 59);
            this.laFooterFont.Name = "laFooterFont";
            this.laFooterFont.Size = new System.Drawing.Size(79, 16);
            this.laFooterFont.TabIndex = 3;
            this.laFooterFont.Text = "Footer Font:";
            // 
            // comboBoxEditFooterFont
            // 
            this.comboBoxEditFooterFont.Location = new System.Drawing.Point(111, 56);
            this.comboBoxEditFooterFont.Name = "comboBoxEditFooterFont";
            this.comboBoxEditFooterFont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditFooterFont.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditFooterFont.Size = new System.Drawing.Size(207, 22);
            this.comboBoxEditFooterFont.StyleController = this.styleController;
            this.comboBoxEditFooterFont.TabIndex = 2;
            this.comboBoxEditFooterFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditFooterFont_SelectedIndexChanged);
            // 
            // laHeaderFont
            // 
            this.laHeaderFont.AutoSize = true;
            this.laHeaderFont.Location = new System.Drawing.Point(3, 15);
            this.laHeaderFont.Name = "laHeaderFont";
            this.laHeaderFont.Size = new System.Drawing.Size(83, 16);
            this.laHeaderFont.TabIndex = 1;
            this.laHeaderFont.Text = "Header Font:";
            // 
            // comboBoxEditHeaderFont
            // 
            this.comboBoxEditHeaderFont.Location = new System.Drawing.Point(111, 12);
            this.comboBoxEditHeaderFont.Name = "comboBoxEditHeaderFont";
            this.comboBoxEditHeaderFont.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditHeaderFont.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditHeaderFont.Size = new System.Drawing.Size(207, 22);
            this.comboBoxEditHeaderFont.StyleController = this.styleController;
            this.comboBoxEditHeaderFont.TabIndex = 0;
            this.comboBoxEditHeaderFont.SelectedIndexChanged += new System.EventHandler(this.comboBoxEditHeaderFont_SelectedIndexChanged);
            // 
            // FormOutputParameters
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(455, 435);
            this.Controls.Add(this.xtraTabControl);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormOutputParameters_FormClosed);
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
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.xtraTabControl.ResumeLayout(false);
            this.xtraTabPageSchedule.ResumeLayout(false);
            this.pnSchedule.ResumeLayout(false);
            this.pnSchedule.PerformLayout();
            this.xtraTabPageTextSettings.ResumeLayout(false);
            this.pnTextSettings.ResumeLayout(false);
            this.pnTextSettings.PerformLayout();
            this.groupBoxSpecialFont.ResumeLayout(false);
            this.groupBoxSpecialFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditSundayPrimeTimeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditSundayPrimeTimeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditWeekPrimeTimeEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeEditWeekPrimeTimeStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkEditPrimeTimeSpecialFontSize.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditBodyFont.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditFooterFont.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditHeaderFont.Properties)).EndInit();
            this.ResumeLayout(false);

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
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageSchedule;
        private System.Windows.Forms.Panel pnSchedule;
        private DevExpress.XtraTab.XtraTabPage xtraTabPageTextSettings;
        private System.Windows.Forms.Panel pnTextSettings;
        private System.Windows.Forms.GroupBox groupBoxSpecialFont;
        private DevExpress.XtraEditors.CheckEdit checkEditPrimeTimeSpecialFontSize;
        private System.Windows.Forms.Label laWeekPrimeTime;
        private System.Windows.Forms.Label laBodyFont;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditBodyFont;
        private System.Windows.Forms.Label laFooterFont;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditFooterFont;
        private System.Windows.Forms.Label laHeaderFont;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEditHeaderFont;
        private DevExpress.XtraEditors.TimeEdit timeEditSundayPrimeTimeEnd;
        private DevExpress.XtraEditors.TimeEdit timeEditSundayPrimeTimeStart;
        private System.Windows.Forms.Label laSundayPrimeTime;
        private DevExpress.XtraEditors.TimeEdit timeEditWeekPrimeTimeEnd;
        private DevExpress.XtraEditors.TimeEdit timeEditWeekPrimeTimeStart;
    }
}