using System.ComponentModel;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    /// <summary>
    /// Represents a TabControl for presenting WebBrowsers.
    /// </summary>
    class WebBrowserTabControl : TabControl
    {
        /// <summary>
        /// Gets the currently selected WebBrowser.
        /// </summary>
        [Browsable(false)]
        public ExWebBrowser SelectedWebBrowser
        {
            get
            {
                if (TabCount == 0) return null;
                return (ExWebBrowser)SelectedTab.Controls[0];
            }
        }

        /// <summary>
        /// Gets or sets the maximum width of the tab caption (in pixels).
        /// </summary>
        [Description("The maximum width of the tab caption (in pixels).")]
        [DefaultValue(200), Category("Layout")]
        public int MaxTabCaptionWidth { get; set; }

        public WebBrowserTabControl()
        {
            MaxTabCaptionWidth = 200;
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (SelectedWebBrowser.Url != null)
            {
                var bookmark = new Bookmark(SelectedWebBrowser.Url.AbsoluteUri, 
                    SelectedWebBrowser.BestPageTitle, null);
                
                DoDragDrop(bookmark, DragDropEffects.Link);
            }
        }

        protected override void OnControlAdded(ControlEventArgs e)
        {
            base.OnControlAdded(e);
            var browser = new ExWebBrowser();
            browser.DocumentTitleChanged += browser_DocumentTitleChanged;
            browser.ScriptErrorsSuppressed = true;
            browser.Dock = DockStyle.Fill;
            e.Control.Controls.Add(browser);
        }

        private void browser_DocumentTitleChanged(object sender, System.EventArgs e)
        {
            var browser = (ExWebBrowser)sender;
            browser.Parent.Text = browser.BestPageTitle.AutoEllipsesString(Font, MaxTabCaptionWidth);
        }

        /// <summary>
        /// Adds a blank tab to the TabControl.
        /// </summary>
        public void AddTab()
        {
            TabPages.Add("Loading...");
        }

        /// <summary>
        /// Removes the currently selected tab.
        /// </summary>
        public void RemoveSelectedTab()
        {
            TabPages.Remove(SelectedTab);
        }
    }
}
