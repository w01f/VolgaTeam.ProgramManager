﻿namespace ProgramManager
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ribbonControl = new DevComponents.DotNetBar.RibbonControl();
            this.ribbonPanelSchedule = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonBarScheduleExit = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBarScheduleAddProgram = new DevComponents.DotNetBar.RibbonBar();
            this.ribbonBarScheduleStation = new DevComponents.DotNetBar.RibbonBar();
            this.comboBoxEditScheduleStation = new DevExpress.XtraEditors.ComboBoxEdit();
            this.styleController = new DevExpress.XtraEditors.StyleController(this.components);
            this.dateEditScheduleDay = new DevExpress.XtraEditors.DateEdit();
            this.itemContainerScheduleStation = new DevComponents.DotNetBar.ItemContainer();
            this.controlContainerItem1 = new DevComponents.DotNetBar.ControlContainerItem();
            this.controlContainerItem2 = new DevComponents.DotNetBar.ControlContainerItem();
            this.ribbonPanelOutput = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonPanelSettings = new DevComponents.DotNetBar.RibbonPanel();
            this.ribbonTabItemSchedule = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemOutput = new DevComponents.DotNetBar.RibbonTabItem();
            this.ribbonTabItemSettings = new DevComponents.DotNetBar.RibbonTabItem();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnEmpty = new System.Windows.Forms.Panel();
            this.superTooltip = new DevComponents.DotNetBar.SuperTooltip();
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.buttonItemScheduleExit = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItemScheduleAddProgram = new DevComponents.DotNetBar.ButtonItem();
            this.labelItemScheduleSationLogo = new DevComponents.DotNetBar.LabelItem();
            this.ribbonControl.SuspendLayout();
            this.ribbonPanelSchedule.SuspendLayout();
            this.ribbonBarScheduleStation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditScheduleStation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditScheduleDay.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditScheduleDay.Properties)).BeginInit();
            this.pnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbonControl
            // 
            this.ribbonControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            // 
            // 
            // 
            this.ribbonControl.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonControl.Controls.Add(this.ribbonPanelSchedule);
            this.ribbonControl.Controls.Add(this.ribbonPanelOutput);
            this.ribbonControl.Controls.Add(this.ribbonPanelSettings);
            this.ribbonControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.ribbonControl.EnableQatPlacement = false;
            this.ribbonControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ribbonControl.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.ribbonTabItemSchedule,
            this.ribbonTabItemOutput,
            this.ribbonTabItemSettings});
            this.ribbonControl.KeyTipsFont = new System.Drawing.Font("Tahoma", 7F);
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.ribbonControl.Size = new System.Drawing.Size(894, 141);
            this.ribbonControl.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonControl.SystemText.MaximizeRibbonText = "&Maximize the Ribbon";
            this.ribbonControl.SystemText.MinimizeRibbonText = "Mi&nimize the Ribbon";
            this.ribbonControl.SystemText.QatAddItemText = "&Add to Quick Access Toolbar";
            this.ribbonControl.SystemText.QatCustomizeMenuLabel = "<b>Customize Quick Access Toolbar</b>";
            this.ribbonControl.SystemText.QatCustomizeText = "&Customize Quick Access Toolbar...";
            this.ribbonControl.SystemText.QatDialogAddButton = "&Add >>";
            this.ribbonControl.SystemText.QatDialogCancelButton = "Cancel";
            this.ribbonControl.SystemText.QatDialogCaption = "Customize Quick Access Toolbar";
            this.ribbonControl.SystemText.QatDialogCategoriesLabel = "&Choose commands from:";
            this.ribbonControl.SystemText.QatDialogOkButton = "OK";
            this.ribbonControl.SystemText.QatDialogPlacementCheckbox = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatDialogRemoveButton = "&Remove";
            this.ribbonControl.SystemText.QatPlaceAboveRibbonText = "&Place Quick Access Toolbar above the Ribbon";
            this.ribbonControl.SystemText.QatPlaceBelowRibbonText = "&Place Quick Access Toolbar below the Ribbon";
            this.ribbonControl.SystemText.QatRemoveItemText = "&Remove from Quick Access Toolbar";
            this.ribbonControl.TabGroupHeight = 14;
            this.ribbonControl.TabIndex = 0;
            this.ribbonControl.Text = "ribbonControl";
            // 
            // ribbonPanelSchedule
            // 
            this.ribbonPanelSchedule.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelSchedule.Controls.Add(this.ribbonBarScheduleExit);
            this.ribbonPanelSchedule.Controls.Add(this.ribbonBarScheduleAddProgram);
            this.ribbonPanelSchedule.Controls.Add(this.ribbonBarScheduleStation);
            this.ribbonPanelSchedule.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelSchedule.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanelSchedule.Name = "ribbonPanelSchedule";
            this.ribbonPanelSchedule.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelSchedule.Size = new System.Drawing.Size(894, 114);
            // 
            // 
            // 
            this.ribbonPanelSchedule.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSchedule.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSchedule.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelSchedule.TabIndex = 1;
            // 
            // ribbonBarScheduleExit
            // 
            this.ribbonBarScheduleExit.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarScheduleExit.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarScheduleExit.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarScheduleExit.ContainerControlProcessDialogKey = true;
            this.ribbonBarScheduleExit.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarScheduleExit.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemScheduleExit});
            this.ribbonBarScheduleExit.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBarScheduleExit.Location = new System.Drawing.Point(406, 0);
            this.ribbonBarScheduleExit.Name = "ribbonBarScheduleExit";
            this.ribbonBarScheduleExit.Size = new System.Drawing.Size(82, 111);
            this.ribbonBarScheduleExit.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarScheduleExit.TabIndex = 22;
            this.ribbonBarScheduleExit.Text = "EXIT";
            // 
            // 
            // 
            this.ribbonBarScheduleExit.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarScheduleExit.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBarScheduleAddProgram
            // 
            this.ribbonBarScheduleAddProgram.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarScheduleAddProgram.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarScheduleAddProgram.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarScheduleAddProgram.ContainerControlProcessDialogKey = true;
            this.ribbonBarScheduleAddProgram.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarScheduleAddProgram.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItemScheduleAddProgram});
            this.ribbonBarScheduleAddProgram.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBarScheduleAddProgram.Location = new System.Drawing.Point(318, 0);
            this.ribbonBarScheduleAddProgram.Name = "ribbonBarScheduleAddProgram";
            this.ribbonBarScheduleAddProgram.Size = new System.Drawing.Size(88, 111);
            this.ribbonBarScheduleAddProgram.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarScheduleAddProgram.TabIndex = 24;
            this.ribbonBarScheduleAddProgram.Text = "Add Program";
            // 
            // 
            // 
            this.ribbonBarScheduleAddProgram.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarScheduleAddProgram.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // ribbonBarScheduleStation
            // 
            this.ribbonBarScheduleStation.AutoOverflowEnabled = true;
            // 
            // 
            // 
            this.ribbonBarScheduleStation.BackgroundMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarScheduleStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonBarScheduleStation.ContainerControlProcessDialogKey = true;
            this.ribbonBarScheduleStation.Controls.Add(this.comboBoxEditScheduleStation);
            this.ribbonBarScheduleStation.Controls.Add(this.dateEditScheduleDay);
            this.ribbonBarScheduleStation.Dock = System.Windows.Forms.DockStyle.Left;
            this.ribbonBarScheduleStation.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.labelItemScheduleSationLogo,
            this.itemContainerScheduleStation});
            this.ribbonBarScheduleStation.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
            this.ribbonBarScheduleStation.Location = new System.Drawing.Point(3, 0);
            this.ribbonBarScheduleStation.Name = "ribbonBarScheduleStation";
            this.ribbonBarScheduleStation.Size = new System.Drawing.Size(315, 111);
            this.ribbonBarScheduleStation.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonBarScheduleStation.TabIndex = 21;
            this.ribbonBarScheduleStation.Text = "Station";
            // 
            // 
            // 
            this.ribbonBarScheduleStation.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonBarScheduleStation.TitleStyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // comboBoxEditScheduleStation
            // 
            this.comboBoxEditScheduleStation.Location = new System.Drawing.Point(190, 13);
            this.comboBoxEditScheduleStation.Name = "comboBoxEditScheduleStation";
            this.comboBoxEditScheduleStation.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEditScheduleStation.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboBoxEditScheduleStation.Size = new System.Drawing.Size(112, 20);
            this.comboBoxEditScheduleStation.StyleController = this.styleController;
            this.comboBoxEditScheduleStation.TabIndex = 0;
            // 
            // dateEditScheduleDay
            // 
            this.dateEditScheduleDay.EditValue = null;
            this.dateEditScheduleDay.Location = new System.Drawing.Point(190, 65);
            this.dateEditScheduleDay.Name = "dateEditScheduleDay";
            this.dateEditScheduleDay.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.dateEditScheduleDay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, ((System.Drawing.Image)(resources.GetObject("dateEditScheduleDay.Properties.Buttons"))), new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.dateEditScheduleDay.Properties.DisplayFormat.FormatString = "MM/dd/yy";
            this.dateEditScheduleDay.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditScheduleDay.Properties.EditFormat.FormatString = "MM/dd/yy";
            this.dateEditScheduleDay.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEditScheduleDay.Properties.ShowToday = false;
            this.dateEditScheduleDay.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.dateEditScheduleDay.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dateEditScheduleDay.Size = new System.Drawing.Size(112, 20);
            this.dateEditScheduleDay.StyleController = this.styleController;
            this.dateEditScheduleDay.TabIndex = 0;
            // 
            // itemContainerScheduleStation
            // 
            // 
            // 
            // 
            this.itemContainerScheduleStation.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainerScheduleStation.ItemSpacing = 30;
            this.itemContainerScheduleStation.LayoutOrientation = DevComponents.DotNetBar.eOrientation.Vertical;
            this.itemContainerScheduleStation.Name = "itemContainerScheduleStation";
            this.itemContainerScheduleStation.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.controlContainerItem1,
            this.controlContainerItem2});
            this.itemContainerScheduleStation.VerticalItemAlignment = DevComponents.DotNetBar.eVerticalItemsAlignment.Middle;
            // 
            // controlContainerItem1
            // 
            this.controlContainerItem1.AllowItemResize = false;
            this.controlContainerItem1.Control = this.comboBoxEditScheduleStation;
            this.controlContainerItem1.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem1.Name = "controlContainerItem1";
            // 
            // controlContainerItem2
            // 
            this.controlContainerItem2.AllowItemResize = false;
            this.controlContainerItem2.Control = this.dateEditScheduleDay;
            this.controlContainerItem2.MenuVisibility = DevComponents.DotNetBar.eMenuVisibility.VisibleAlways;
            this.controlContainerItem2.Name = "controlContainerItem2";
            // 
            // ribbonPanelOutput
            // 
            this.ribbonPanelOutput.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelOutput.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanelOutput.Name = "ribbonPanelOutput";
            this.ribbonPanelOutput.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelOutput.Size = new System.Drawing.Size(894, 114);
            // 
            // 
            // 
            this.ribbonPanelOutput.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelOutput.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelOutput.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelOutput.TabIndex = 2;
            this.ribbonPanelOutput.Visible = false;
            // 
            // ribbonPanelSettings
            // 
            this.ribbonPanelSettings.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ribbonPanelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ribbonPanelSettings.Location = new System.Drawing.Point(0, 25);
            this.ribbonPanelSettings.Name = "ribbonPanelSettings";
            this.ribbonPanelSettings.Padding = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.ribbonPanelSettings.Size = new System.Drawing.Size(894, 114);
            // 
            // 
            // 
            this.ribbonPanelSettings.Style.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSettings.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.ribbonPanelSettings.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.ribbonPanelSettings.TabIndex = 3;
            this.ribbonPanelSettings.Visible = false;
            // 
            // ribbonTabItemSchedule
            // 
            this.ribbonTabItemSchedule.Checked = true;
            this.ribbonTabItemSchedule.Name = "ribbonTabItemSchedule";
            this.ribbonTabItemSchedule.Panel = this.ribbonPanelSchedule;
            this.ribbonTabItemSchedule.Text = "Schedule";
            // 
            // ribbonTabItemOutput
            // 
            this.ribbonTabItemOutput.Name = "ribbonTabItemOutput";
            this.ribbonTabItemOutput.Panel = this.ribbonPanelOutput;
            this.ribbonTabItemOutput.Text = "Output";
            // 
            // ribbonTabItemSettings
            // 
            this.ribbonTabItemSettings.Name = "ribbonTabItemSettings";
            this.ribbonTabItemSettings.Panel = this.ribbonPanelSettings;
            this.ribbonTabItemSettings.Text = "Settings";
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.pnMain.Controls.Add(this.pnEmpty);
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(0, 141);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(894, 429);
            this.pnMain.TabIndex = 1;
            // 
            // pnEmpty
            // 
            this.pnEmpty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.pnEmpty.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmpty.Location = new System.Drawing.Point(0, 0);
            this.pnEmpty.Name = "pnEmpty";
            this.pnEmpty.Size = new System.Drawing.Size(894, 429);
            this.pnEmpty.TabIndex = 2;
            // 
            // superTooltip
            // 
            this.superTooltip.LicenseKey = "F962CEC7-CD8F-4911-A9E9-CAB39962FC1F";
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
            // buttonItemScheduleExit
            // 
            this.buttonItemScheduleExit.Image = global::ProgramManager.Properties.Resources.Exit;
            this.buttonItemScheduleExit.Name = "buttonItemScheduleExit";
            this.buttonItemScheduleExit.SubItemsExpandWidth = 14;
            this.buttonItemScheduleExit.Text = "buttonItemHomeExit";
            this.buttonItemScheduleExit.Click += new System.EventHandler(this.buttonItemExit_Click);
            // 
            // buttonItemScheduleAddProgram
            // 
            this.buttonItemScheduleAddProgram.Image = global::ProgramManager.Properties.Resources.AddProgram;
            this.buttonItemScheduleAddProgram.Name = "buttonItemScheduleAddProgram";
            this.buttonItemScheduleAddProgram.SubItemsExpandWidth = 14;
            this.buttonItemScheduleAddProgram.Text = "buttonItem1";
            // 
            // labelItemScheduleSationLogo
            // 
            this.labelItemScheduleSationLogo.Image = global::ProgramManager.Properties.Resources.Logo;
            this.labelItemScheduleSationLogo.Name = "labelItemScheduleSationLogo";
            this.labelItemScheduleSationLogo.Click += new System.EventHandler(this.labelItemLogo_Click);
            // 
            // FormMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(894, 570);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.ribbonControl);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MinimumSize = new System.Drawing.Size(900, 595);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Program Manager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.ribbonControl.ResumeLayout(false);
            this.ribbonControl.PerformLayout();
            this.ribbonPanelSchedule.ResumeLayout(false);
            this.ribbonBarScheduleStation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEditScheduleStation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditScheduleDay.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEditScheduleDay.Properties)).EndInit();
            this.pnMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.RibbonControl ribbonControl;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemSchedule;
        private System.Windows.Forms.Panel pnMain;
        public DevComponents.DotNetBar.RibbonPanel ribbonPanelSchedule;
        private DevComponents.DotNetBar.RibbonBar ribbonBarScheduleExit;
        private DevComponents.DotNetBar.ButtonItem buttonItemScheduleExit;
        private DevComponents.DotNetBar.SuperTooltip superTooltip;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelSettings;
        private DevComponents.DotNetBar.RibbonPanel ribbonPanelOutput;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemOutput;
        private DevComponents.DotNetBar.RibbonTabItem ribbonTabItemSettings;
        private DevComponents.DotNetBar.ItemContainer itemContainerScheduleStation;
        private DevComponents.DotNetBar.RibbonBar ribbonBarScheduleAddProgram;
        private DevComponents.DotNetBar.ButtonItem buttonItemScheduleAddProgram;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
        private DevComponents.DotNetBar.StyleManager styleManager;
        private DevExpress.XtraEditors.StyleController styleController;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem1;
        private DevComponents.DotNetBar.ControlContainerItem controlContainerItem2;
        private System.Windows.Forms.Panel pnEmpty;
        public DevExpress.XtraEditors.ComboBoxEdit comboBoxEditScheduleStation;
        public DevExpress.XtraEditors.DateEdit dateEditScheduleDay;
        public DevComponents.DotNetBar.LabelItem labelItemScheduleSationLogo;
        public DevComponents.DotNetBar.RibbonBar ribbonBarScheduleStation;
    }
}

