namespace ProgramManager.TabPages
{
    partial class TabSchedule
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

        #region Component Designer generated code

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
            this.gridControlPrograms = new DevExpress.XtraGrid.GridControl();
            this.gridViewPrograms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnDay = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditWeekDay = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditTime = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnProgram = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEditProgram = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnEpisode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnLastModified = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEditFullDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditWeekDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditWeekDay.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditTime.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditProgram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFullDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFullDate.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).BeginInit();
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
            // gridControlPrograms
            // 
            this.gridControlPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrograms.Location = new System.Drawing.Point(0, 0);
            this.gridControlPrograms.MainView = this.gridViewPrograms;
            this.gridControlPrograms.Name = "gridControlPrograms";
            this.gridControlPrograms.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEditDate,
            this.repositoryItemDateEditWeekDay,
            this.repositoryItemDateEditTime,
            this.repositoryItemDateEditFullDate,
            this.repositoryItemTextEditProgram,
            this.repositoryItemTextEdit});
            this.gridControlPrograms.Size = new System.Drawing.Size(714, 366);
            this.gridControlPrograms.TabIndex = 0;
            this.gridControlPrograms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrograms});
            // 
            // gridViewPrograms
            // 
            this.gridViewPrograms.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewPrograms.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewPrograms.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPrograms.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewPrograms.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridViewPrograms.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewPrograms.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewPrograms.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPrograms.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.Row.Options.UseFont = true;
            this.gridViewPrograms.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewPrograms.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewPrograms.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewPrograms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnDate,
            this.gridColumnDay,
            this.gridColumnTime,
            this.gridColumnStation,
            this.gridColumnProgram,
            this.gridColumnEpisode,
            this.gridColumnType,
            this.gridColumnFCC,
            this.gridColumnLastModified});
            this.gridViewPrograms.GridControl = this.gridControlPrograms;
            this.gridViewPrograms.Name = "gridViewPrograms";
            this.gridViewPrograms.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPrograms.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridViewPrograms.OptionsBehavior.AutoPopulateColumns = false;
            this.gridViewPrograms.OptionsCustomization.AllowFilter = false;
            this.gridViewPrograms.OptionsCustomization.AllowGroup = false;
            this.gridViewPrograms.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewPrograms.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrograms.OptionsView.ShowDetailButtons = false;
            this.gridViewPrograms.OptionsView.ShowGroupExpandCollapseButtons = false;
            this.gridViewPrograms.OptionsView.ShowGroupPanel = false;
            this.gridViewPrograms.OptionsView.ShowIndicator = false;
            this.gridViewPrograms.RowHeight = 30;
            this.gridViewPrograms.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gridViewPrograms_RowCellStyle);
            this.gridViewPrograms.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gridViewPrograms_CellValueChanged);
            // 
            // gridColumnDate
            // 
            this.gridColumnDate.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumnDate.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnDate.Caption = "Date";
            this.gridColumnDate.ColumnEdit = this.repositoryItemDateEditDate;
            this.gridColumnDate.FieldName = "Date";
            this.gridColumnDate.Name = "gridColumnDate";
            this.gridColumnDate.OptionsColumn.AllowEdit = false;
            this.gridColumnDate.OptionsColumn.ReadOnly = true;
            this.gridColumnDate.Visible = true;
            this.gridColumnDate.VisibleIndex = 0;
            this.gridColumnDate.Width = 119;
            // 
            // repositoryItemDateEditDate
            // 
            this.repositoryItemDateEditDate.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateEditDate.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemDateEditDate.Appearance.Options.UseFont = true;
            this.repositoryItemDateEditDate.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceDropDown.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceDropDownHeader.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceDropDownHeaderHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceDropDownHighlight.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceDropDownHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AppearanceWeekNumber.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditDate.AppearanceWeekNumber.Options.UseFont = true;
            this.repositoryItemDateEditDate.AppearanceWeekNumber.Options.UseTextOptions = true;
            this.repositoryItemDateEditDate.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditDate.AutoHeight = false;
            this.repositoryItemDateEditDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditDate.DisplayFormat.FormatString = "MM/dd/yy";
            this.repositoryItemDateEditDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.EditFormat.FormatString = "MM/dd/yy";
            this.repositoryItemDateEditDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditDate.Name = "repositoryItemDateEditDate";
            this.repositoryItemDateEditDate.ShowToday = false;
            this.repositoryItemDateEditDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEditDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumnDay
            // 
            this.gridColumnDay.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumnDay.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnDay.Caption = "Day";
            this.gridColumnDay.ColumnEdit = this.repositoryItemDateEditWeekDay;
            this.gridColumnDay.FieldName = "Date";
            this.gridColumnDay.Name = "gridColumnDay";
            this.gridColumnDay.OptionsColumn.AllowEdit = false;
            this.gridColumnDay.OptionsColumn.ReadOnly = true;
            this.gridColumnDay.Visible = true;
            this.gridColumnDay.VisibleIndex = 1;
            this.gridColumnDay.Width = 120;
            // 
            // repositoryItemDateEditWeekDay
            // 
            this.repositoryItemDateEditWeekDay.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateEditWeekDay.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemDateEditWeekDay.Appearance.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDown.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeader.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeaderHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHighlight.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AppearanceWeekNumber.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditWeekDay.AppearanceWeekNumber.Options.UseFont = true;
            this.repositoryItemDateEditWeekDay.AppearanceWeekNumber.Options.UseTextOptions = true;
            this.repositoryItemDateEditWeekDay.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditWeekDay.AutoHeight = false;
            this.repositoryItemDateEditWeekDay.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditWeekDay.DisplayFormat.FormatString = "ddd";
            this.repositoryItemDateEditWeekDay.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditWeekDay.EditFormat.FormatString = "ddd";
            this.repositoryItemDateEditWeekDay.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditWeekDay.Name = "repositoryItemDateEditWeekDay";
            this.repositoryItemDateEditWeekDay.ShowToday = false;
            this.repositoryItemDateEditWeekDay.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEditWeekDay.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumnTime
            // 
            this.gridColumnTime.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumnTime.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnTime.Caption = "Time";
            this.gridColumnTime.ColumnEdit = this.repositoryItemDateEditTime;
            this.gridColumnTime.FieldName = "Time";
            this.gridColumnTime.Name = "gridColumnTime";
            this.gridColumnTime.OptionsColumn.AllowEdit = false;
            this.gridColumnTime.OptionsColumn.ReadOnly = true;
            this.gridColumnTime.Visible = true;
            this.gridColumnTime.VisibleIndex = 2;
            this.gridColumnTime.Width = 105;
            // 
            // repositoryItemDateEditTime
            // 
            this.repositoryItemDateEditTime.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateEditTime.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemDateEditTime.Appearance.Options.UseFont = true;
            this.repositoryItemDateEditTime.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceDropDown.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceDropDownHeader.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceDropDownHeaderHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceDropDownHighlight.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceDropDownHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AppearanceWeekNumber.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditTime.AppearanceWeekNumber.Options.UseFont = true;
            this.repositoryItemDateEditTime.AppearanceWeekNumber.Options.UseTextOptions = true;
            this.repositoryItemDateEditTime.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditTime.AutoHeight = false;
            this.repositoryItemDateEditTime.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditTime.DisplayFormat.FormatString = "hh:mm tt";
            this.repositoryItemDateEditTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditTime.EditFormat.FormatString = "hh:mm tt";
            this.repositoryItemDateEditTime.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditTime.Name = "repositoryItemDateEditTime";
            this.repositoryItemDateEditTime.ShowToday = false;
            this.repositoryItemDateEditTime.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEditTime.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumnStation
            // 
            this.gridColumnStation.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumnStation.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnStation.Caption = "Station";
            this.gridColumnStation.FieldName = "Station";
            this.gridColumnStation.Name = "gridColumnStation";
            this.gridColumnStation.OptionsColumn.AllowEdit = false;
            this.gridColumnStation.OptionsColumn.ReadOnly = true;
            this.gridColumnStation.Visible = true;
            this.gridColumnStation.VisibleIndex = 3;
            this.gridColumnStation.Width = 90;
            // 
            // gridColumnProgram
            // 
            this.gridColumnProgram.AppearanceCell.Options.UseTextOptions = true;
            this.gridColumnProgram.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.gridColumnProgram.Caption = "Program";
            this.gridColumnProgram.ColumnEdit = this.repositoryItemTextEditProgram;
            this.gridColumnProgram.FieldName = "Program";
            this.gridColumnProgram.Name = "gridColumnProgram";
            this.gridColumnProgram.Visible = true;
            this.gridColumnProgram.VisibleIndex = 4;
            this.gridColumnProgram.Width = 272;
            // 
            // repositoryItemTextEditProgram
            // 
            this.repositoryItemTextEditProgram.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repositoryItemTextEditProgram.Appearance.Options.UseFont = true;
            this.repositoryItemTextEditProgram.Appearance.Options.UseTextOptions = true;
            this.repositoryItemTextEditProgram.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemTextEditProgram.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTextEditProgram.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemTextEditProgram.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemTextEditProgram.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemTextEditProgram.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTextEditProgram.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemTextEditProgram.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemTextEditProgram.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemTextEditProgram.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTextEditProgram.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemTextEditProgram.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemTextEditProgram.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.repositoryItemTextEditProgram.AutoHeight = false;
            this.repositoryItemTextEditProgram.Name = "repositoryItemTextEditProgram";
            this.repositoryItemTextEditProgram.NullText = "Type...";
            // 
            // gridColumnEpisode
            // 
            this.gridColumnEpisode.Caption = "Episode";
            this.gridColumnEpisode.ColumnEdit = this.repositoryItemTextEditProgram;
            this.gridColumnEpisode.FieldName = "Episode";
            this.gridColumnEpisode.Name = "gridColumnEpisode";
            this.gridColumnEpisode.Visible = true;
            this.gridColumnEpisode.VisibleIndex = 5;
            this.gridColumnEpisode.Width = 107;
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "Type";
            this.gridColumnType.ColumnEdit = this.repositoryItemTextEditProgram;
            this.gridColumnType.FieldName = "Type";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 6;
            this.gridColumnType.Width = 79;
            // 
            // gridColumnFCC
            // 
            this.gridColumnFCC.Caption = "FCC";
            this.gridColumnFCC.ColumnEdit = this.repositoryItemTextEditProgram;
            this.gridColumnFCC.FieldName = "FCC";
            this.gridColumnFCC.Name = "gridColumnFCC";
            this.gridColumnFCC.Visible = true;
            this.gridColumnFCC.VisibleIndex = 7;
            this.gridColumnFCC.Width = 77;
            // 
            // gridColumnLastModified
            // 
            this.gridColumnLastModified.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gridColumnLastModified.AppearanceCell.Options.UseBackColor = true;
            this.gridColumnLastModified.Caption = "Last Modified";
            this.gridColumnLastModified.ColumnEdit = this.repositoryItemDateEditFullDate;
            this.gridColumnLastModified.FieldName = "LastModified";
            this.gridColumnLastModified.Name = "gridColumnLastModified";
            this.gridColumnLastModified.OptionsColumn.AllowEdit = false;
            this.gridColumnLastModified.OptionsColumn.ReadOnly = true;
            this.gridColumnLastModified.Visible = true;
            this.gridColumnLastModified.VisibleIndex = 8;
            this.gridColumnLastModified.Width = 181;
            // 
            // repositoryItemDateEditFullDate
            // 
            this.repositoryItemDateEditFullDate.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateEditFullDate.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemDateEditFullDate.Appearance.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.Appearance.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceDisabled.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDown.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDown.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeader.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeader.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeaderHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHeaderHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceDropDownHighlight.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHighlight.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceDropDownHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceFocused.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceReadOnly.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AppearanceWeekNumber.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEditFullDate.AppearanceWeekNumber.Options.UseFont = true;
            this.repositoryItemDateEditFullDate.AppearanceWeekNumber.Options.UseTextOptions = true;
            this.repositoryItemDateEditFullDate.AppearanceWeekNumber.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.repositoryItemDateEditFullDate.AutoHeight = false;
            this.repositoryItemDateEditFullDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEditFullDate.DisplayFormat.FormatString = "MM/dd/yy hh:mm:ss tt";
            this.repositoryItemDateEditFullDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditFullDate.EditFormat.FormatString = "MM/dd/yy hh:mm:ss tt";
            this.repositoryItemDateEditFullDate.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEditFullDate.Name = "repositoryItemDateEditFullDate";
            this.repositoryItemDateEditFullDate.ShowToday = false;
            this.repositoryItemDateEditFullDate.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.repositoryItemDateEditFullDate.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // repositoryItemTextEdit
            // 
            this.repositoryItemTextEdit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemTextEdit.Appearance.Options.UseFont = true;
            this.repositoryItemTextEdit.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTextEdit.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemTextEdit.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTextEdit.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemTextEdit.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTextEdit.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemTextEdit.AutoHeight = false;
            this.repositoryItemTextEdit.Name = "repositoryItemTextEdit";
            this.repositoryItemTextEdit.NullText = "Type...";
            // 
            // TabSchedule
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.Controls.Add(this.gridControlPrograms);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "TabSchedule";
            this.Size = new System.Drawing.Size(714, 366);
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditWeekDay.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditWeekDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditTime.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEditProgram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFullDate.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEditFullDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevExpress.XtraEditors.StyleController styleController;
        private DevExpress.XtraGrid.GridControl gridControlPrograms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrograms;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStation;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnProgram;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEpisode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnLastModified;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditWeekDay;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditTime;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEditFullDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEditProgram;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit;
    }
}
