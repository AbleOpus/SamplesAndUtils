namespace AboStopWatch
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAlwaysOnTop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemTimeFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemClock = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeconds = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemMinutes = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonStart = new AboStopWatch.IlluminateButton();
            this.buttonExit = new AboStopWatch.IlluminateButton();
            this.buttonStop = new AboStopWatch.IlluminateButton();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 20;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // textBoxTime
            // 
            this.textBoxTime.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxTime.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxTime.ContextMenuStrip = this.contextMenuStrip;
            this.textBoxTime.Font = new System.Drawing.Font("Segoe UI Semibold", 25F, System.Drawing.FontStyle.Bold);
            this.textBoxTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.textBoxTime.Location = new System.Drawing.Point(12, 62);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.ReadOnly = true;
            this.textBoxTime.Size = new System.Drawing.Size(369, 45);
            this.textBoxTime.TabIndex = 8;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.SystemColors.Control;
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAlwaysOnTop,
            this.menuItemTimeFormat});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(154, 48);
            // 
            // menuItemAlwaysOnTop
            // 
            this.menuItemAlwaysOnTop.CheckOnClick = true;
            this.menuItemAlwaysOnTop.Name = "menuItemAlwaysOnTop";
            this.menuItemAlwaysOnTop.Size = new System.Drawing.Size(153, 22);
            this.menuItemAlwaysOnTop.Text = "Always On Top";
            this.menuItemAlwaysOnTop.Click += new System.EventHandler(this.menuItemAlwaysOnTop_Click);
            // 
            // menuItemTimeFormat
            // 
            this.menuItemTimeFormat.BackColor = System.Drawing.SystemColors.Control;
            this.menuItemTimeFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemClock,
            this.menuItemMS,
            this.menuItemSeconds,
            this.menuItemMinutes});
            this.menuItemTimeFormat.Name = "menuItemTimeFormat";
            this.menuItemTimeFormat.Size = new System.Drawing.Size(153, 22);
            this.menuItemTimeFormat.Text = "Time Format";
            // 
            // menuItemClock
            // 
            this.menuItemClock.Name = "menuItemClock";
            this.menuItemClock.Size = new System.Drawing.Size(179, 22);
            this.menuItemClock.Text = "Clock (min/sec/ms)";
            this.menuItemClock.Click += new System.EventHandler(this.menuItemClock_Click);
            // 
            // menuItemMS
            // 
            this.menuItemMS.Name = "menuItemMS";
            this.menuItemMS.Size = new System.Drawing.Size(179, 22);
            this.menuItemMS.Text = "Milliseconds";
            this.menuItemMS.Click += new System.EventHandler(this.menuItemMS_Click);
            // 
            // menuItemSeconds
            // 
            this.menuItemSeconds.Name = "menuItemSeconds";
            this.menuItemSeconds.Size = new System.Drawing.Size(179, 22);
            this.menuItemSeconds.Text = "Seconds";
            this.menuItemSeconds.Click += new System.EventHandler(this.menuItemSeconds_Click);
            // 
            // menuItemMinutes
            // 
            this.menuItemMinutes.Name = "menuItemMinutes";
            this.menuItemMinutes.Size = new System.Drawing.Size(179, 22);
            this.menuItemMinutes.Text = "Minutes";
            this.menuItemMinutes.Click += new System.EventHandler(this.menuItemMinutes_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.AutoSize = true;
            this.buttonStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStart.BackColor = System.Drawing.Color.Transparent;
            this.buttonStart.ContextMenuStrip = this.contextMenuStrip;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.DefaultImage = global::AboStopWatch.Properties.Resources.Play;
            this.buttonStart.DepressBrightness = 1F;
            this.buttonStart.DepressConstrast = 1F;
            this.buttonStart.DepressGamma = 1F;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.HoverBrightness = 1F;
            this.buttonStart.HoverContrast = 1.2F;
            this.buttonStart.Image = global::AboStopWatch.Properties.Resources.Play;
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(38, 38);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.AutoSize = true;
            this.buttonExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.DefaultImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.DefaultImage")));
            this.buttonExit.DepressBrightness = 1F;
            this.buttonExit.DepressConstrast = 1F;
            this.buttonExit.DepressGamma = 1F;
            this.buttonExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.HoverBrightness = 2F;
            this.buttonExit.HoverContrast = 2F;
            this.buttonExit.HoverGamma = 0.5F;
            this.buttonExit.Image = ((System.Drawing.Image)(resources.GetObject("buttonExit.Image")));
            this.buttonExit.Location = new System.Drawing.Point(343, 12);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(38, 38);
            this.buttonExit.TabIndex = 7;
            this.buttonExit.TabStop = false;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.AutoSize = true;
            this.buttonStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonStop.BackColor = System.Drawing.Color.Transparent;
            this.buttonStop.ContextMenuStrip = this.contextMenuStrip;
            this.buttonStop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStop.DefaultImage = global::AboStopWatch.Properties.Resources.Stop;
            this.buttonStop.DepressBrightness = 1F;
            this.buttonStop.DepressConstrast = 1F;
            this.buttonStop.DepressGamma = 1F;
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStop.Enabled = false;
            this.buttonStop.FlatAppearance.BorderSize = 0;
            this.buttonStop.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStop.HoverBrightness = 1F;
            this.buttonStop.HoverContrast = 1.2F;
            this.buttonStop.Image = global::AboStopWatch.Properties.Resources.Stop;
            this.buttonStop.Location = new System.Drawing.Point(65, 12);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(38, 38);
            this.buttonStop.TabIndex = 5;
            this.buttonStop.TabStop = false;
            this.buttonStop.UseVisualStyleBackColor = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // MainForm
            // 
            this.AcceptButton = this.buttonStart;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CancelButton = this.buttonExit;
            this.ClientSize = new System.Drawing.Size(393, 119);
            this.ContextMenuStrip = this.contextMenuStrip;
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Stop Watch";
            this.TopMost = true;
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerUpdate;
        private IlluminateButton buttonStart;
        private IlluminateButton buttonStop;
        private IlluminateButton buttonExit;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem menuItemAlwaysOnTop;
        private System.Windows.Forms.ToolStripMenuItem menuItemTimeFormat;
        private System.Windows.Forms.ToolStripMenuItem menuItemClock;
        private System.Windows.Forms.ToolStripMenuItem menuItemMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemSeconds;
        private System.Windows.Forms.ToolStripMenuItem menuItemMinutes;
    }
}

