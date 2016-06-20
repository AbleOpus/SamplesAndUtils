namespace AdvancedWebBrowser.Forms
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
            this.contextMenuHome = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuItemAddTab = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemRemoveTab = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewSource = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemFullScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemResetZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.labelBrowserStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl = new AdvancedWebBrowser.Forms.WebBrowserTabControl();
            this.historyDisplay = new AdvancedWebBrowser.Forms.HistoryDisplay();
            this.bookmarkBar = new AdvancedWebBrowser.Forms.BookmarkBar();
            this.navigationBar = new AdvancedWebBrowser.Forms.NavigationBar();
            this.contextMenuHome.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuHome
            // 
            this.contextMenuHome.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemAddTab,
            this.menuItemRemoveTab,
            this.toolStripSeparator5,
            this.menuItemSaveAs,
            this.menuItemViewSource,
            this.toolStripSeparator2,
            this.menuItemHistory,
            this.menuItemViewStatusBar,
            this.menuItemFullScreen,
            this.menuItemResetZoom,
            this.toolStripSeparator3,
            this.menuItemSettings,
            this.toolStripSeparator4,
            this.menuItemExit});
            this.contextMenuHome.Name = "cmsHome";
            this.contextMenuHome.Size = new System.Drawing.Size(213, 248);
            // 
            // menuItemAddTab
            // 
            this.menuItemAddTab.Image = global::AdvancedWebBrowser.Properties.Resources.Add;
            this.menuItemAddTab.Name = "menuItemAddTab";
            this.menuItemAddTab.ShortcutKeyDisplayString = "Ctrl+T";
            this.menuItemAddTab.Size = new System.Drawing.Size(212, 22);
            this.menuItemAddTab.Text = "&Add Tab";
            this.menuItemAddTab.Click += new System.EventHandler(this.menuItemAddTab_Click);
            // 
            // menuItemRemoveTab
            // 
            this.menuItemRemoveTab.Enabled = false;
            this.menuItemRemoveTab.Name = "menuItemRemoveTab";
            this.menuItemRemoveTab.ShortcutKeyDisplayString = "Ctrl+Shift+T";
            this.menuItemRemoveTab.Size = new System.Drawing.Size(212, 22);
            this.menuItemRemoveTab.Text = "&Remove Tab";
            this.menuItemRemoveTab.Click += new System.EventHandler(this.menuItemRemoveTab_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(209, 6);
            // 
            // menuItemSaveAs
            // 
            this.menuItemSaveAs.Image = global::AdvancedWebBrowser.Properties.Resources.Save;
            this.menuItemSaveAs.Name = "menuItemSaveAs";
            this.menuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuItemSaveAs.Size = new System.Drawing.Size(212, 22);
            this.menuItemSaveAs.Text = "&Save As...";
            this.menuItemSaveAs.Click += new System.EventHandler(this.menuItemSaveAs_Click);
            // 
            // menuItemViewSource
            // 
            this.menuItemViewSource.Image = global::AdvancedWebBrowser.Properties.Resources.ViewCode;
            this.menuItemViewSource.Name = "menuItemViewSource";
            this.menuItemViewSource.Size = new System.Drawing.Size(212, 22);
            this.menuItemViewSource.Text = "&View Source";
            this.menuItemViewSource.Click += new System.EventHandler(this.menuItemViewSource_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // menuItemHistory
            // 
            this.menuItemHistory.CheckOnClick = true;
            this.menuItemHistory.Image = global::AdvancedWebBrowser.Properties.Resources.History;
            this.menuItemHistory.Name = "menuItemHistory";
            this.menuItemHistory.Size = new System.Drawing.Size(212, 22);
            this.menuItemHistory.Text = "View &History";
            this.menuItemHistory.CheckedChanged += new System.EventHandler(this.menuItemHistory_CheckedChanged);
            // 
            // menuItemViewStatusBar
            // 
            this.menuItemViewStatusBar.CheckOnClick = true;
            this.menuItemViewStatusBar.Image = global::AdvancedWebBrowser.Properties.Resources.StatusStrip;
            this.menuItemViewStatusBar.Name = "menuItemViewStatusBar";
            this.menuItemViewStatusBar.Size = new System.Drawing.Size(212, 22);
            this.menuItemViewStatusBar.Text = "View Statusbar";
            this.menuItemViewStatusBar.CheckedChanged += new System.EventHandler(this.menuItemViewStatusBar_CheckedChanged);
            // 
            // menuItemFullScreen
            // 
            this.menuItemFullScreen.CheckOnClick = true;
            this.menuItemFullScreen.Image = global::AdvancedWebBrowser.Properties.Resources.FullScreen;
            this.menuItemFullScreen.Name = "menuItemFullScreen";
            this.menuItemFullScreen.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.menuItemFullScreen.Size = new System.Drawing.Size(212, 22);
            this.menuItemFullScreen.Text = "&Full-Screen";
            this.menuItemFullScreen.CheckedChanged += new System.EventHandler(this.menuItemFullScreen_CheckedChanged);
            // 
            // menuItemResetZoom
            // 
            this.menuItemResetZoom.Image = global::AdvancedWebBrowser.Properties.Resources.ResetZoom;
            this.menuItemResetZoom.Name = "menuItemResetZoom";
            this.menuItemResetZoom.Size = new System.Drawing.Size(212, 22);
            this.menuItemResetZoom.Text = "&Reset Zoom";
            this.menuItemResetZoom.Click += new System.EventHandler(this.menuItemResetZoom_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(209, 6);
            // 
            // menuItemSettings
            // 
            this.menuItemSettings.Image = global::AdvancedWebBrowser.Properties.Resources.Gear;
            this.menuItemSettings.Name = "menuItemSettings";
            this.menuItemSettings.Size = new System.Drawing.Size(212, 22);
            this.menuItemSettings.Text = "&Settings...";
            this.menuItemSettings.Click += new System.EventHandler(this.menuItemSettings_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // menuItemExit
            // 
            this.menuItemExit.Name = "menuItemExit";
            this.menuItemExit.Size = new System.Drawing.Size(212, 22);
            this.menuItemExit.Text = "E&xit";
            this.menuItemExit.Click += new System.EventHandler(this.menuItemExit_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.labelBrowserStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 496);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip.Size = new System.Drawing.Size(1035, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 5;
            this.statusStrip.Text = "statusStrip1";
            // 
            // labelBrowserStatus
            // 
            this.labelBrowserStatus.Name = "labelBrowserStatus";
            this.labelBrowserStatus.Padding = new System.Windows.Forms.Padding(5, 0, 40, 0);
            this.labelBrowserStatus.Size = new System.Drawing.Size(69, 17);
            this.labelBrowserStatus.Text = "Idle";
            this.labelBrowserStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabControl
            // 
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 66);
            this.tabControl.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(741, 430);
            this.tabControl.TabIndex = 1;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            this.tabControl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlAdded);
            this.tabControl.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.tabControl_ControlRemoved);
            // 
            // historyDisplay
            // 
            this.historyDisplay.Dock = System.Windows.Forms.DockStyle.Right;
            this.historyDisplay.Location = new System.Drawing.Point(741, 66);
            this.historyDisplay.Margin = new System.Windows.Forms.Padding(0);
            this.historyDisplay.Name = "historyDisplay";
            this.historyDisplay.Size = new System.Drawing.Size(294, 430);
            this.historyDisplay.TabIndex = 4;
            this.historyDisplay.Visible = false;
            this.historyDisplay.WebBrowser = null;
            this.historyDisplay.VisibleChanged += new System.EventHandler(this.historyDisplay_VisibleChanged);
            // 
            // bookmarkBar
            // 
            this.bookmarkBar.AllowDrop = true;
            this.bookmarkBar.AutoSize = true;
            this.bookmarkBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookmarkBar.Location = new System.Drawing.Point(0, 41);
            this.bookmarkBar.Margin = new System.Windows.Forms.Padding(0);
            this.bookmarkBar.MaxBookmarkCaptionWidth = 150;
            this.bookmarkBar.Name = "bookmarkBar";
            this.bookmarkBar.Size = new System.Drawing.Size(1035, 25);
            this.bookmarkBar.TabIndex = 2;
            this.bookmarkBar.WebBrowser = null;
            this.bookmarkBar.BookmarkMiddleClicked += new System.EventHandler<AdvancedWebBrowser.Bookmark>(this.bookmarkBar_BookmarkMiddleClicked);
            // 
            // navigationBar
            // 
            this.navigationBar.AutoSize = true;
            this.navigationBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.Margin = new System.Windows.Forms.Padding(0);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.navigationBar.Size = new System.Drawing.Size(1035, 41);
            this.navigationBar.TabIndex = 0;
            this.navigationBar.WebBrowser = null;
            this.navigationBar.MenuButtonClick += new System.EventHandler(this.navigationBar_MenuButtonClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 518);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.historyDisplay);
            this.Controls.Add(this.bookmarkBar);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.statusStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(426, 181);
            this.Name = "MainForm";
            this.Text = "Advanced Browser";
            this.contextMenuHome.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NavigationBar navigationBar;
        private WebBrowserTabControl tabControl;
        private BookmarkBar bookmarkBar;
        private HistoryDisplay historyDisplay;
        private System.Windows.Forms.ContextMenuStrip contextMenuHome;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddTab;
        private System.Windows.Forms.ToolStripMenuItem menuItemRemoveTab;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewSource;
        private System.Windows.Forms.ToolStripMenuItem menuItemSaveAs;
        private System.Windows.Forms.ToolStripMenuItem menuItemResetZoom;
        private System.Windows.Forms.ToolStripMenuItem menuItemExit;
        private System.Windows.Forms.ToolStripMenuItem menuItemFullScreen;
        private System.Windows.Forms.ToolStripMenuItem menuItemHistory;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel labelBrowserStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuItemViewStatusBar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}

