using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    public partial class MainForm : Form
    {
        private readonly Icon appIcon;

        /// <summary>
        /// Gets or sets whether this Form is displayed in full-screen.
        /// </summary>
        private bool FullScreen
        {
            get { return FormBorderStyle == FormBorderStyle.None; }
            set
            {
                if (value)
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                }
            }
        }

        public MainForm(string[] args)
        {
            InitializeComponent();
            Settings.Default.Bookmarks.CollectionChanged += Bookmarks_CollectionChanged;
            appIcon = Icon;
            AddHomepageTab();
            SetActiveWebBrowser();
            bookmarkBar.Visible = Settings.Default.ShowBookmarks;
            statusStrip.Visible = Settings.Default.ShowStatusBar;
            AddBookmarksToMenu(Settings.Default.Bookmarks);

            if (args.Length > 0)
                tabControl.SelectedWebBrowser.Navigate(args[0]);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.ShowStatusBar = statusStrip.Visible;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        /// <summary>
        /// Processes a command key. 
        /// </summary>
        /// <returns>
        /// true if the keystroke was processed and consumed by the control; otherwise, false to allow further processing.
        /// </returns>
        /// <param name="msg">A <see cref="T:System.Windows.Forms.Message"/>, passed by reference, that represents the Win32 message to process. </param><param name="keyData">One of the <see cref="T:System.Windows.Forms.Keys"/> values that represents the key to process. </param>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.F11:
                    FullScreen = !FullScreen;
                    return true;

                case Keys.Control | Keys.T:
                    AddHomepageTab();
                    return true;

                case Keys.Control | Keys.Shift | Keys.T:
                    RemoveTab();
                    return true;

                case Keys.Control | Keys.S:
                    tabControl.SelectedWebBrowser.SaveCurrentPage();
                    return true;

                case Keys.BrowserHome:
                    tabControl.SelectedWebBrowser.Navigate(Settings.Default.Homepage);
                    break;

                case Keys.BrowserBack:
                    tabControl.SelectedWebBrowser.GoBack();
                    break;

                case Keys.BrowserForward:
                    tabControl.SelectedWebBrowser.GoForward();
                    break;

                case Keys.BrowserRefresh:
                    tabControl.SelectedWebBrowser.Refresh();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void AddTab(string url)
        {
            tabControl.AddTab();
            int index = tabControl.TabCount - 1;
            tabControl.SelectedIndex = index;
            tabControl.SelectedWebBrowser.Navigate(url);
        }

        private void Bookmarks_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            var bookmarks = Bookmark.ExtractBookmarks(e.NewItems);

            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                AddBookmarksToMenu(bookmarks);
            }
        }

        /// <summary>
        /// Adds a set of bookmarks to the menu, if some of the bookmarks are for
        /// bar display, then those bookmarks will be ignored.
        /// </summary>
        private void AddBookmarksToMenu(IEnumerable<Bookmark> bookmarks)
        {
            foreach (var bookmark in bookmarks)
            {
                var item = new ToolStripMenuItem();
                if (bookmark.HasIcon) item.Image = bookmark.FavIcon.ToBitmap();
                item.Tag = bookmark;
                item.Text = bookmark.Title.AutoEllipsesString(item.Font, 300);

                item.Click += delegate
                {
                    if (tabControl.SelectedWebBrowser != null)
                    {
                        var b = (Bookmark)item.Tag;
                        tabControl.SelectedWebBrowser.Navigate(b.Url);
                    }
                };
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            labelBrowserStatus.Width = ClientSize.Width / 2;
        }

        private void AddHomepageTab()
        {
            AddTab(Settings.Default.Homepage);
        }

        /// <summary>
        /// Removes a tab from the tabControl unless there is only one tab remaining.
        /// </summary>
        private void RemoveTab()
        {
            if (tabControl.TabCount > 1)
                tabControl.RemoveSelectedTab();
        }

        private void SetActiveWebBrowser()
        {
            var browser = tabControl.SelectedWebBrowser;
            navigationBar.WebBrowser = browser;
            bookmarkBar.WebBrowser = browser;
            historyDisplay.WebBrowser = browser;
            browser.DocumentTitleChanged += BrowserOnDocumentTitleChanged;
            browser.PageChanged += delegate { navigationBar.IsLoadingPage = false; };
            browser.Navigating += delegate { navigationBar.IsLoadingPage = true; };
            browser.StatusTextChanged += delegate { labelBrowserStatus.Text = browser.StatusText; };
        }

        private async void BrowserOnDocumentTitleChanged(object sender, EventArgs e)
        {
            var browser = (ExWebBrowser)sender;
            string url = browser.Url.ToString();
            if (Settings.Default.TrackHistory)
                Settings.Default.AddHistory(url);
            Text = browser.BestPageTitle;
            Icon icon = await Bookmark.GetFavIconAsync(browser.Url);
            Icon = icon ?? appIcon;
        }

        private void menuItemAddTab_Click(object sender, EventArgs e)
        {
            AddHomepageTab();
        }

        private void menuItemRemoveTab_Click(object sender, EventArgs e)
        {
            RemoveTab();
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            tabControl.SelectedWebBrowser.SaveCurrentPage();
        }

        private void menuItemViewSource_Click(object sender, EventArgs e)
        {
            string content = tabControl.SelectedWebBrowser.DocumentText;
            new ViewSourceForm(content).Show();
        }

        private void menuItemResetZoom_Click(object sender, EventArgs e)
        {
            tabControl.SelectedWebBrowser.Focus();
            SendKeys.Send("^0");
        }

        private void menuItemFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            FullScreen = !FullScreen;
        }

        private void menuItemHistory_CheckedChanged(object sender, EventArgs e)
        {
            historyDisplay.Visible = menuItemHistory.Checked;
        }

        private void menuItemSettings_Click(object sender, EventArgs e)
        {
            using (var dialogSettings = new SettingsDialog())
            {
                dialogSettings.ShowDialog();
            }

            bookmarkBar.Visible = Settings.Default.ShowBookmarks;
        }

        private void menuItemViewStatusBar_CheckedChanged(object sender, EventArgs e)
        {
            statusStrip.Visible = menuItemViewStatusBar.Checked;
        }

        private void historyDisplay_VisibleChanged(object sender, EventArgs e)
        {
            menuItemHistory.Checked = historyDisplay.Visible;
        }

        private void navigationBar_MenuButtonClick(object sender, EventArgs e)
        {
            int x = navigationBar.Location.X;
            int y = navigationBar.Location.Y + navigationBar.Height;
            Point pos = PointToScreen(new Point(x, y));
            contextMenuHome.Show(pos);
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveWebBrowser();
        }

        private void tabControl_ControlRemoved(object sender, ControlEventArgs e)
        {
            // The control does not seem to have been removed yet
            menuItemRemoveTab.Enabled = tabControl.TabCount > 2;
        }

        private void tabControl_ControlAdded(object sender, ControlEventArgs e)
        {
            menuItemRemoveTab.Enabled = tabControl.TabCount > 1;
        }

        private void bookmarkBar_BookmarkMiddleClicked(object sender, Bookmark e)
        {
            AddTab(e.Url);
        }
    }
}
