namespace AdvancedWebBrowser.Forms
{
    partial class NavigationBar
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
            this.buttonMenu = new System.Windows.Forms.ToolStripButton();
            this.buttonBack = new System.Windows.Forms.ToolStripButton();
            this.buttonForward = new System.Windows.Forms.ToolStripButton();
            this.textBoxAddress = new AdvancedWebBrowser.Forms.ToolStripSpringTextBox();
            this.buttonStop = new System.Windows.Forms.ToolStripButton();
            this.buttonRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.buttonHome = new System.Windows.Forms.ToolStripButton();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMenu
            // 
            this.buttonMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonMenu.Image = global::AdvancedWebBrowser.Properties.Resources.AppIcon;
            this.buttonMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonMenu.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(28, 40);
            // 
            // buttonBack
            // 
            this.buttonBack.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonBack.Enabled = false;
            this.buttonBack.Image = global::AdvancedWebBrowser.Properties.Resources.Back;
            this.buttonBack.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonBack.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(28, 40);
            this.buttonBack.Text = "Go Back";
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonForward.Enabled = false;
            this.buttonForward.Image = global::AdvancedWebBrowser.Properties.Resources.Forward;
            this.buttonForward.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonForward.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonForward.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(28, 40);
            this.buttonForward.Text = "Go Forward";
            this.buttonForward.Click += new System.EventHandler(this.buttonForward_Click);
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.textBoxAddress.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAddress.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.textBoxAddress.Size = new System.Drawing.Size(487, 43);
            this.textBoxAddress.ToolTipText = "Type a search term or URL";
            this.textBoxAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAddress_KeyDown);
            this.textBoxAddress.MouseLeave += new System.EventHandler(this.textBoxAddress_MouseLeave);
            this.textBoxAddress.MouseUp += new System.Windows.Forms.MouseEventHandler(this.textBoxAddress_MouseUp);
            // 
            // buttonStop
            // 
            this.buttonStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonStop.Image = global::AdvancedWebBrowser.Properties.Resources.Stop;
            this.buttonStop.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonStop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(36, 40);
            this.buttonStop.ToolTipText = "Stop";
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonRefresh.Image = global::AdvancedWebBrowser.Properties.Resources.Refresh;
            this.buttonRefresh.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(28, 40);
            this.buttonRefresh.ToolTipText = "Refresh";
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.AllowMerge = false;
            this.toolStrip.CanOverflow = false;
            this.toolStrip.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buttonMenu,
            this.buttonBack,
            this.buttonForward,
            this.buttonHome,
            this.buttonRefresh,
            this.buttonStop,
            this.textBoxAddress});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Padding = new System.Windows.Forms.Padding(5);
            this.toolStrip.ShowItemToolTips = false;
            this.toolStrip.Size = new System.Drawing.Size(715, 53);
            this.toolStrip.TabIndex = 0;
            // 
            // buttonHome
            // 
            this.buttonHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buttonHome.Image = global::AdvancedWebBrowser.Properties.Resources.Home;
            this.buttonHome.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.buttonHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(28, 40);
            this.buttonHome.ToolTipText = "Refresh";
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.toolStrip);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(715, 53);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton buttonMenu;
        private System.Windows.Forms.ToolStripButton buttonBack;
        private System.Windows.Forms.ToolStripButton buttonForward;
        private ToolStripSpringTextBox textBoxAddress;
        private System.Windows.Forms.ToolStripButton buttonStop;
        private System.Windows.Forms.ToolStripButton buttonRefresh;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton buttonHome;
    }
}
