namespace ProgramManager.Client.ToolForms
{
    partial class FormManagePrograms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagePrograms));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
            this.pnBottom = new System.Windows.Forms.Panel();
            this.simpleButtonClose = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlPrograms = new DevExpress.XtraGrid.GridControl();
            this.gridViewPrograms = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumnName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.gridColumnType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnFCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemDateEdit = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.gridColumnStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTimeEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.gridColumnEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnDuration = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumnButtons = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.gridColumnHouseNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pnTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
            this.pnBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrograms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).BeginInit();
            this.pnTop.SuspendLayout();
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
            // pnBottom
            // 
            this.pnBottom.Controls.Add(this.simpleButtonClose);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 356);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(798, 56);
            this.pnBottom.TabIndex = 32;
            // 
            // simpleButtonClose
            // 
            this.simpleButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButtonClose.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpleButtonClose.Appearance.Options.UseFont = true;
            this.simpleButtonClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.simpleButtonClose.Location = new System.Drawing.Point(686, 9);
            this.simpleButtonClose.Name = "simpleButtonClose";
            this.simpleButtonClose.Size = new System.Drawing.Size(98, 35);
            this.simpleButtonClose.StyleController = this.styleController;
            this.simpleButtonClose.TabIndex = 33;
            this.simpleButtonClose.Text = "Close";
            // 
            // gridControlPrograms
            // 
            this.gridControlPrograms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPrograms.Location = new System.Drawing.Point(0, 35);
            this.gridControlPrograms.MainView = this.gridViewPrograms;
            this.gridControlPrograms.Name = "gridControlPrograms";
            this.gridControlPrograms.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTextEdit,
            this.repositoryItemDateEdit,
            this.repositoryItemTimeEdit,
            this.repositoryItemButtonEdit});
            this.gridControlPrograms.Size = new System.Drawing.Size(798, 321);
            this.gridControlPrograms.TabIndex = 33;
            this.gridControlPrograms.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewPrograms});
            // 
            // gridViewPrograms
            // 
            this.gridViewPrograms.Appearance.EvenRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewPrograms.Appearance.FocusedCell.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewPrograms.Appearance.FocusedRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewPrograms.Appearance.HeaderPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.gridViewPrograms.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewPrograms.Appearance.OddRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.OddRow.Options.UseFont = true;
            this.gridViewPrograms.Appearance.Preview.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.Preview.Options.UseFont = true;
            this.gridViewPrograms.Appearance.Row.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.Row.Options.UseFont = true;
            this.gridViewPrograms.Appearance.SelectedRow.Font = new System.Drawing.Font("Arial", 9.75F);
            this.gridViewPrograms.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewPrograms.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumnName,
            this.gridColumnType,
            this.gridColumnFCC,
            this.gridColumnStartDate,
            this.gridColumnStartTime,
            this.gridColumnEndTime,
            this.gridColumnDuration,
            this.gridColumnButtons,
            this.gridColumnHouseNumber});
            this.gridViewPrograms.GridControl = this.gridControlPrograms;
            this.gridViewPrograms.Name = "gridViewPrograms";
            this.gridViewPrograms.OptionsCustomization.AllowFilter = false;
            this.gridViewPrograms.OptionsCustomization.AllowGroup = false;
            this.gridViewPrograms.OptionsCustomization.AllowQuickHideColumns = false;
            this.gridViewPrograms.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridViewPrograms.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gridViewPrograms.OptionsView.AutoCalcPreviewLineCount = true;
            this.gridViewPrograms.OptionsView.ColumnAutoWidth = false;
            this.gridViewPrograms.OptionsView.EnableAppearanceEvenRow = true;
            this.gridViewPrograms.OptionsView.EnableAppearanceOddRow = true;
            this.gridViewPrograms.OptionsView.ShowGroupPanel = false;
            this.gridViewPrograms.OptionsView.ShowIndicator = false;
            this.gridViewPrograms.OptionsView.ShowPreview = true;
            this.gridViewPrograms.PreviewFieldName = "DetailedInfo";
            this.gridViewPrograms.RowHeight = 35;
            this.gridViewPrograms.RowSeparatorHeight = 5;
            this.gridViewPrograms.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridViewPrograms_RowClick);
            // 
            // gridColumnName
            // 
            this.gridColumnName.Caption = "Name";
            this.gridColumnName.ColumnEdit = this.repositoryItemTextEdit;
            this.gridColumnName.FieldName = "Name";
            this.gridColumnName.Name = "gridColumnName";
            this.gridColumnName.OptionsColumn.AllowEdit = false;
            this.gridColumnName.OptionsColumn.ReadOnly = true;
            this.gridColumnName.Visible = true;
            this.gridColumnName.VisibleIndex = 0;
            this.gridColumnName.Width = 191;
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
            // 
            // gridColumnType
            // 
            this.gridColumnType.Caption = "Type";
            this.gridColumnType.ColumnEdit = this.repositoryItemTextEdit;
            this.gridColumnType.FieldName = "Type";
            this.gridColumnType.Name = "gridColumnType";
            this.gridColumnType.OptionsColumn.AllowEdit = false;
            this.gridColumnType.OptionsColumn.ReadOnly = true;
            this.gridColumnType.Visible = true;
            this.gridColumnType.VisibleIndex = 1;
            this.gridColumnType.Width = 55;
            // 
            // gridColumnFCC
            // 
            this.gridColumnFCC.Caption = "E/I";
            this.gridColumnFCC.ColumnEdit = this.repositoryItemTextEdit;
            this.gridColumnFCC.FieldName = "FCC";
            this.gridColumnFCC.Name = "gridColumnFCC";
            this.gridColumnFCC.OptionsColumn.AllowEdit = false;
            this.gridColumnFCC.OptionsColumn.ReadOnly = true;
            this.gridColumnFCC.Visible = true;
            this.gridColumnFCC.VisibleIndex = 2;
            this.gridColumnFCC.Width = 80;
            // 
            // gridColumnStartDate
            // 
            this.gridColumnStartDate.Caption = "Start Date";
            this.gridColumnStartDate.ColumnEdit = this.repositoryItemDateEdit;
            this.gridColumnStartDate.FieldName = "Date";
            this.gridColumnStartDate.Name = "gridColumnStartDate";
            this.gridColumnStartDate.OptionsColumn.AllowEdit = false;
            this.gridColumnStartDate.OptionsColumn.ReadOnly = true;
            this.gridColumnStartDate.Visible = true;
            this.gridColumnStartDate.VisibleIndex = 4;
            this.gridColumnStartDate.Width = 80;
            // 
            // repositoryItemDateEdit
            // 
            this.repositoryItemDateEdit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.Appearance.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceDropDown.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceDropDown.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceDropDownHeader.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceDropDownHeader.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceDropDownHighlight.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemDateEdit.AppearanceWeekNumber.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemDateEdit.AppearanceWeekNumber.Options.UseFont = true;
            this.repositoryItemDateEdit.AutoHeight = false;
            this.repositoryItemDateEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemDateEdit.DisplayFormat.FormatString = "MM/dd/yy";
            this.repositoryItemDateEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit.EditFormat.FormatString = "MM/dd/yy";
            this.repositoryItemDateEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemDateEdit.Name = "repositoryItemDateEdit";
            this.repositoryItemDateEdit.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            // 
            // gridColumnStartTime
            // 
            this.gridColumnStartTime.Caption = "Start Time";
            this.gridColumnStartTime.ColumnEdit = this.repositoryItemTimeEdit;
            this.gridColumnStartTime.FieldName = "StartTime";
            this.gridColumnStartTime.Name = "gridColumnStartTime";
            this.gridColumnStartTime.OptionsColumn.AllowEdit = false;
            this.gridColumnStartTime.OptionsColumn.ReadOnly = true;
            this.gridColumnStartTime.Visible = true;
            this.gridColumnStartTime.VisibleIndex = 5;
            this.gridColumnStartTime.Width = 79;
            // 
            // repositoryItemTimeEdit
            // 
            this.repositoryItemTimeEdit.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repositoryItemTimeEdit.Appearance.Options.UseFont = true;
            this.repositoryItemTimeEdit.AppearanceDisabled.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTimeEdit.AppearanceDisabled.Options.UseFont = true;
            this.repositoryItemTimeEdit.AppearanceFocused.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTimeEdit.AppearanceFocused.Options.UseFont = true;
            this.repositoryItemTimeEdit.AppearanceReadOnly.Font = new System.Drawing.Font("Arial", 9.75F);
            this.repositoryItemTimeEdit.AppearanceReadOnly.Options.UseFont = true;
            this.repositoryItemTimeEdit.AutoHeight = false;
            this.repositoryItemTimeEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit.DisplayFormat.FormatString = "hh:mm tt";
            this.repositoryItemTimeEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTimeEdit.EditFormat.FormatString = "hh:mm tt";
            this.repositoryItemTimeEdit.EditFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.repositoryItemTimeEdit.Mask.EditMask = "hh:mm tt";
            this.repositoryItemTimeEdit.Name = "repositoryItemTimeEdit";
            // 
            // gridColumnEndTime
            // 
            this.gridColumnEndTime.Caption = "End Time";
            this.gridColumnEndTime.ColumnEdit = this.repositoryItemTimeEdit;
            this.gridColumnEndTime.FieldName = "EndTime";
            this.gridColumnEndTime.Name = "gridColumnEndTime";
            this.gridColumnEndTime.OptionsColumn.AllowEdit = false;
            this.gridColumnEndTime.OptionsColumn.ReadOnly = true;
            this.gridColumnEndTime.Visible = true;
            this.gridColumnEndTime.VisibleIndex = 6;
            this.gridColumnEndTime.Width = 72;
            // 
            // gridColumnDuration
            // 
            this.gridColumnDuration.Caption = "Duration";
            this.gridColumnDuration.ColumnEdit = this.repositoryItemTextEdit;
            this.gridColumnDuration.FieldName = "Duration";
            this.gridColumnDuration.Name = "gridColumnDuration";
            this.gridColumnDuration.OptionsColumn.AllowEdit = false;
            this.gridColumnDuration.OptionsColumn.ReadOnly = true;
            this.gridColumnDuration.Visible = true;
            this.gridColumnDuration.VisibleIndex = 7;
            this.gridColumnDuration.Width = 83;
            // 
            // gridColumnButtons
            // 
            this.gridColumnButtons.ColumnEdit = this.repositoryItemButtonEdit;
            this.gridColumnButtons.Name = "gridColumnButtons";
            this.gridColumnButtons.OptionsColumn.AllowMove = false;
            this.gridColumnButtons.OptionsColumn.AllowSize = false;
            this.gridColumnButtons.OptionsColumn.FixedWidth = true;
            this.gridColumnButtons.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.gridColumnButtons.Visible = true;
            this.gridColumnButtons.VisibleIndex = 8;
            // 
            // repositoryItemButtonEdit
            // 
            this.repositoryItemButtonEdit.AutoHeight = false;
            this.repositoryItemButtonEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("repositoryItemButtonEdit.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.repositoryItemButtonEdit.Name = "repositoryItemButtonEdit";
            this.repositoryItemButtonEdit.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEdit_ButtonClick);
            // 
            // gridColumnHouseNumber
            // 
            this.gridColumnHouseNumber.Caption = "House #";
            this.gridColumnHouseNumber.ColumnEdit = this.repositoryItemTextEdit;
            this.gridColumnHouseNumber.FieldName = "HouseNumber";
            this.gridColumnHouseNumber.Name = "gridColumnHouseNumber";
            this.gridColumnHouseNumber.OptionsColumn.AllowEdit = false;
            this.gridColumnHouseNumber.OptionsColumn.ReadOnly = true;
            this.gridColumnHouseNumber.Visible = true;
            this.gridColumnHouseNumber.VisibleIndex = 3;
            this.gridColumnHouseNumber.Width = 79;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.label1);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(798, 35);
            this.pnTop.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Double-Click on a row  to edit program";
            // 
            // FormManagePrograms
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(798, 412);
            this.Controls.Add(this.gridControlPrograms);
            this.Controls.Add(this.pnTop);
            this.Controls.Add(this.pnBottom);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "FormManagePrograms";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Programs";
            this.Load += new System.EventHandler(this.FormManagePrograms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
            this.pnBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewPrograms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevExpress.XtraEditors.StyleController styleController;
        private System.Windows.Forms.Panel pnBottom;
        private DevExpress.XtraGrid.GridControl gridControlPrograms;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewPrograms;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnName;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnType;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnFCC;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnStartTime;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnEndTime;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnDuration;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnButtons;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit;
        private DevExpress.XtraEditors.SimpleButton simpleButtonClose;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumnHouseNumber;
    }
}