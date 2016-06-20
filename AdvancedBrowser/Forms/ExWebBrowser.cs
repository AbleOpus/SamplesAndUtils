using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    public class ExWebBrowser : WebBrowser
    {
        private string lastUrl = string.Empty;

        /// <summary>
        /// Gets the best title for the currently loaded page.
        /// </summary>
        public string BestPageTitle
        {
            get
            {
                if (Document == null) return string.Empty;

                if (!String.IsNullOrEmpty(Document.Title))
                {
                    return Document.Title;
                }

                Match match = Regex.Match(Url.AbsoluteUri, @"https?://(www\.)?(?<Text>[^\.]+)");

                if (match.Groups["Text"].Success)
                {
                    return match.Groups["Text"].Value;
                }

                return Url.AbsoluteUri;
            }
        }

        public event EventHandler PageChanged;
        protected virtual void OnPageChanged()
        {
            PageChanged?.Invoke(this, EventArgs.Empty);
        }

        protected override void OnDocumentCompleted(WebBrowserDocumentCompletedEventArgs e)
        {
            base.OnDocumentCompleted(e);

            if (Url == null)
            {
                // Page goes from something to blank.
                if (lastUrl.Length > 0)
                {
                    OnPageChanged();
                    lastUrl = string.Empty;
                }

                return;
            }

            // Page changes regularly.
            if (lastUrl != Url.AbsoluteUri)
            {
                OnPageChanged();
                lastUrl = Url.AbsoluteUri;
            }
        }

        /// <summary>
        /// Shows a SaveFileDialog for saving the current page to file.
        /// </summary>
        public void SaveCurrentPage()
        {
            using (var dialogSaveFile = new SaveFileDialog())
            {
                dialogSaveFile.Filter = @"Web File|*.html";
                dialogSaveFile.FileName = BestPageTitle;

                if (dialogSaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string content = DocumentText;
                        File.WriteAllText(dialogSaveFile.FileName, content);
                    }
                    catch (Exception ex)
                    {
                        ex.ShowMessage();
                    }
                }
            }
        }
    }
}
