using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    public partial class SettingsDialog : Form
    {
        public SettingsDialog()
        {
            InitializeComponent();
            LoadSettings();
        }

        /// <summary>
        /// Updates the UI to reflect to current settings.
        /// </summary>
        private void LoadSettings()
        {
            textBoxHomepage.Text = Settings.Default.Homepage;
            checkBoxHistory.Checked = Settings.Default.TrackHistory;
            checkBoxShowBookmarks.Checked = Settings.Default.ShowBookmarks;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.ShowBookmarks = checkBoxShowBookmarks.Checked;
            Settings.Default.Homepage = textBoxHomepage.Text;
            Settings.Default.TrackHistory = checkBoxHistory.Checked;
            base.OnClosing(e);
        }

        private void buttonClearHistory_Click(object sender, EventArgs e)
        {
            Settings.Default.Clear();
            buttonClearHistory.Enabled = false;
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            buttonReset.Enabled = false;
            Settings.Default.Reset();
            LoadSettings();
        }
    }
}
