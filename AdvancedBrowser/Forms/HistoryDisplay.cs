using System;

namespace AdvancedWebBrowser.Forms
{
    public partial class HistoryDisplay : BrowserControl
    {
        public HistoryDisplay()
        {
            InitializeComponent();
        }

        protected override void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);

            listBoxHistory.Items.Clear();
            var history = Settings.Default.History;

            for (int i = history.Length - 1; i > 0; i--)
            {
                string link = history[i];
                listBoxHistory.Items.Add(link);
            }

            //foreach (string link in UserSettings.Instance.History)
            //{
            //    listHistory.Items.Add(link);
            //}
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            Settings.Default.ClearHistory();
            listBoxHistory.Items.Clear();
        }

        private void listHistory_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxHistory.SelectedIndex != -1)
            WebBrowser.Navigate(listBoxHistory.SelectedItem.ToString());
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
