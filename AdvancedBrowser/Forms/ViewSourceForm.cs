using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    /// <summary>
    /// Represents a form for displaying webpage source.
    /// </summary>
    public partial class ViewSourceForm : Form
    {
        private readonly string originalSource;

        public ViewSourceForm(string source)
        {
            InitializeComponent();
            originalSource = source;
            richColoredTextBox.Text = source;
            SetSyntaxHighlighter();
            menuItemWordWrap.Checked = Settings.Default.ViewSourceWordWrapEnabled;
            menuItemHighlight.Checked = Settings.Default.ViewSourceHighlighterEnabled;
            richColoredTextBox.Font = Settings.Default.ViewSourceFont;
            richColoredTextBox.DataBindings.Add("WordWrap", menuItemWordWrap, "Checked");
            richColoredTextBox.DataBindings.Add("HighlighterEnabled", menuItemHighlight, "Checked");
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.ViewSourceWordWrapEnabled = richColoredTextBox.WordWrap;
            Settings.Default.ViewSourceHighlighterEnabled = richColoredTextBox.HighlighterEnabled;
            Settings.Default.ViewSourceFont = richColoredTextBox.Font;
            base.OnClosing(e);
        }

        /// <summary>
        /// Sets the HTML syntax highlighter for the RichColoredTextBox.
        /// </summary>
        private void SetSyntaxHighlighter()
        {
            var comment = new RichColorProfile(@"<!--.+?-->", Color.DarkGreen);
            comment.RegexOptions = RegexOptions.Singleline;
            var tag = new RichColorProfile(@"<[^>]+?>", Color.DarkBlue);
            var quotes = new RichColorProfile(@"""[^""]*""", Color.DarkRed);
            richColoredTextBox.Highlighter = new RichSyntaxHighlighter("HTML", tag, comment, quotes);
        }

        private void menuItemFont_Click(object sender, System.EventArgs e)
        {
            using (var dialogFont = new FontDialog())
            {
                dialogFont.Font = Settings.Default.ViewSourceFont;

                try
                {
                    if (dialogFont.ShowDialog() == DialogResult.OK)
                    {
                        richColoredTextBox.Font = dialogFont.Font;
                    }
                }
                catch (Exception ex)
                {
                    ex.ShowMessage();
                }
            }
        }

        private void menuItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemSaveAs_Click(object sender, EventArgs e)
        {
            using (var dialogSaveFile = new SaveFileDialog())
            {
                dialogSaveFile.Filter = "Web File|*.html|Text File|*.txt";

                if (dialogSaveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        File.WriteAllText(dialogSaveFile.FileName, originalSource);
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
