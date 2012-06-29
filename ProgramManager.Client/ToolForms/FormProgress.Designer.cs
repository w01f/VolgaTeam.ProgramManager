namespace ProgramManager.Client.ToolForms
{
    partial class FormProgress
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
            this.laProgress = new System.Windows.Forms.Label();
            this.circularProgress = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.panelEx = new DevComponents.DotNetBar.PanelEx();
            this.styleManager = new DevComponents.DotNetBar.StyleManager(this.components);
            this.panelEx.SuspendLayout();
            this.SuspendLayout();
            // 
            // laProgress
            // 
            this.laProgress.BackColor = System.Drawing.Color.Transparent;
            this.laProgress.Dock = System.Windows.Forms.DockStyle.Fill;
            this.laProgress.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.laProgress.ForeColor = System.Drawing.Color.Black;
            this.laProgress.Location = new System.Drawing.Point(0, 0);
            this.laProgress.Name = "laProgress";
            this.laProgress.Size = new System.Drawing.Size(305, 49);
            this.laProgress.TabIndex = 2;
            this.laProgress.Text = "Loading data...";
            this.laProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.laProgress.UseMnemonic = false;
            this.laProgress.UseWaitCursor = true;
            // 
            // circularProgress
            // 
            this.circularProgress.AnimationSpeed = 50;
            this.circularProgress.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.circularProgress.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.circularProgress.Enabled = false;
            this.circularProgress.Location = new System.Drawing.Point(0, 49);
            this.circularProgress.Name = "circularProgress";
            this.circularProgress.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Dot;
            this.circularProgress.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circularProgress.ProgressTextFormat = "";
            this.circularProgress.Size = new System.Drawing.Size(305, 39);
            this.circularProgress.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress.TabIndex = 3;
            // 
            // panelEx
            // 
            this.panelEx.CanvasColor = System.Drawing.SystemColors.Control;
            this.panelEx.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.panelEx.Controls.Add(this.laProgress);
            this.panelEx.Controls.Add(this.circularProgress);
            this.panelEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEx.Location = new System.Drawing.Point(2, 2);
            this.panelEx.Name = "panelEx";
            this.panelEx.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panelEx.Size = new System.Drawing.Size(305, 98);
            this.panelEx.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.panelEx.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.panelEx.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.panelEx.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
            this.panelEx.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.panelEx.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.panelEx.Style.GradientAngle = 90;
            this.panelEx.TabIndex = 4;
            // 
            // styleManager
            // 
            this.styleManager.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(163)))), ((int)(((byte)(26))))));
            // 
            // FormProgress
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(228)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(309, 102);
            this.ControlBox = false;
            this.Controls.Add(this.panelEx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormProgress";
            this.Opacity = 0.85D;
            this.Padding = new System.Windows.Forms.Padding(2);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressForm";
            this.Shown += new System.EventHandler(this.FormProgress_Shown);
            this.panelEx.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label laProgress;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress;
        private DevComponents.DotNetBar.PanelEx panelEx;
        private DevComponents.DotNetBar.StyleManager styleManager;
    }
}