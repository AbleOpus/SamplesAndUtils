using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    public partial class BrowserControl : UserControl
    {
        private ExWebBrowser webBrowser;
        /// <summary>
        /// Gets or sets the WebBrowser this and its derivations will interact with.
        /// </summary>
        [Browsable(false)]
        public ExWebBrowser WebBrowser
        {
            get { return webBrowser; }
            set
            {
                if (value != webBrowser)
                {
                    webBrowser = value;
                    OnWebBrowserChanged();
                }
            }
        }


        public BrowserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Occurs when the value of the WebBrowser property has changed.
        /// </summary>
        public event EventHandler WebBrowserChanged;
        /// <summary>
        /// Raises the WebBrowserChanged event.
        /// </summary>
        protected virtual void OnWebBrowserChanged()
        {
            WebBrowserChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
