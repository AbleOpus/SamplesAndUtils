using System;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    public partial class NavigationBar : BrowserControl
    {
        private bool shouldSelectAll = true;

        /// <summary>
        /// Gets or sets whether the UI reflects a loading webpage.
        /// </summary>
        [Browsable(false), DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public bool IsLoadingPage
        {
            get { return buttonStop.Visible; }
            set
            {
                buttonStop.Visible = value;
                buttonRefresh.Visible = !value;
            }
        }

        /// <summary>
        /// Occurs when the menu button is clicked.
        /// </summary>
        [Description("Occurs when the menu button is clicked."), Category("Action")]
        public event EventHandler MenuButtonClick
        {
            add { buttonMenu.Click += value; }
            remove { buttonMenu.Click -= value; }
        }

        public NavigationBar()
        {
            InitializeComponent();
            Settings.Default.HistoryAdded += Instance_HistoryAdded;
        }

        private void Instance_HistoryAdded(object sender, EventArgs e)
        {
            var range = Settings.Default.History.Distinct();
            textBoxAddress.AutoCompleteCustomSource.AddRange(range.ToArray());
        }

        protected override void OnWebBrowserChanged()
        {
            base.OnWebBrowserChanged();
            if (WebBrowser.Url != null) textBoxAddress.Text = WebBrowser.Url.ToString();
            WebBrowser.DocumentTitleChanged += WebBrowser_DocumentTitleChanged;
            WebBrowser.CanGoBackChanged += delegate { buttonBack.Enabled = WebBrowser.CanGoBack; };
            WebBrowser.CanGoForwardChanged += delegate { buttonForward.Enabled = WebBrowser.CanGoForward; };
        }

        private void WebBrowser_DocumentTitleChanged(object sender, EventArgs e)
        {
            var browser = (ExWebBrowser)sender;
            textBoxAddress.Text = browser.Url.ToString();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            WebBrowser.GoBack();
        }

        private void buttonForward_Click(object sender, EventArgs e)
        {
            WebBrowser.GoForward();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            WebBrowser.Refresh();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            WebBrowser.Stop();
        }

        private void textBoxAddress_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

                // If search term and not link.
                if (textBoxAddress.Text.Contains(' ') || !textBoxAddress.Text.Contains('.'))
                {
                    string term = WebUtility.UrlEncode(textBoxAddress.Text);
                    WebBrowser.Navigate("http://www.google.ca/#q=" + term);
                }
                else
                {
                    WebBrowser.Navigate(textBoxAddress.Text);
                }
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            WebBrowser.Navigate(Settings.Default.Homepage);
        }

        private void textBoxAddress_MouseUp(object sender, MouseEventArgs e)
        {
            if (shouldSelectAll)
            {
                textBoxAddress.SelectAll();
                shouldSelectAll = false;
            }

        }

        private void textBoxAddress_MouseLeave(object sender, EventArgs e)
        {
            shouldSelectAll = true;
        }
    }
}
