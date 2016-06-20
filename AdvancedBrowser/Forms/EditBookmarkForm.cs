using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AdvancedWebBrowser.Properties;

namespace AdvancedWebBrowser.Forms
{
    /// <summary>
    /// Represents a form for editing a bookmark
    /// </summary>
    public partial class EditBookmarkForm : Form
    {
        private readonly Bookmark bookmark;

        public EditBookmarkForm(Bookmark bookmark)
        {
            InitializeComponent();
            this.bookmark = bookmark;
            textBoxCaption.Text = bookmark.Title;
            textBoxUrl.Text = bookmark.Url;
            Icon = Resources.Bookmark.ToIcon();
        }

        private async void buttonOk_Click(object sender, EventArgs e)
        {
            buttonOk.Enabled = false;
            string URL = FixUrl(textBoxUrl.Text);

            try
            {
                // Use the Uri class for quick validation of the URL.
                 new Uri(URL);
            }
            catch
            {
                MessageBox.Show("The URL is invalid", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bookmark.Title = textBoxCaption.Text;
            bookmark.Url = URL;
            bookmark.FavIcon = await Bookmark.GetFavIconAsyc(URL);
            Close();
        }

        /// <summary>
        /// Prefixes the URL with a protocol if it is not present.
        /// </summary>
        private static string FixUrl(string url)
        {
            const string PATTERN = @"(https?|ftp)://";

            if (Regex.IsMatch(url, PATTERN, RegexOptions.IgnoreCase))
            {
                return url;
            }

            return "http://" + url;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            buttonOk.Enabled = (textBoxCaption.TextLength > 0 && textBoxUrl.TextLength > 0);
        }
    }
}
