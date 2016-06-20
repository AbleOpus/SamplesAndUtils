using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AdvancedWebBrowser.Forms
{
    /// <summary>
    /// Represents a RichTextBo with color syntax highlighting.
    /// </summary>
    class RichColoredTextBox : RichTextBox
    {
        private bool highlighting; // So we don't enter a visions loop when highlighting

        private bool highlighterEnabled;
        /// <summary>
        /// Gets or sets whether the syntax highlighter is enabled.
        /// </summary>
        [Description("Determines whether the syntax highlighter is enabled.")]
        public bool HighlighterEnabled
        {
            get { return highlighterEnabled; }
            set
            {
                if (value == highlighterEnabled) return;
                highlighterEnabled = value;

                if (highlighterEnabled) Highlight();
                else ClearFormatting();
            }
        }

        private RichSyntaxHighlighter highlighter;
        /// <summary>
        /// Gets the currently loaded highlighter.
        /// </summary>
        [Browsable(false)]
        public RichSyntaxHighlighter Highlighter
        {
            get { return highlighter; }
            set
            {
                if (value == highlighter) return;
                highlighter = value;

                if (highlighter.DesiredBackColor != Color.Empty)
                BackColor = highlighter.DesiredBackColor;
                Highlight();
            }
        }

        public RichColoredTextBox()
        {
            ReadOnly = true;
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            Highlight();
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            Highlight();
        }

        /// <summary>
        /// Clears all text formatting.
        /// </summary>
        public void ClearFormatting()
        {
            string temp = Text;
            Text = null;
            Text = temp;
        }

        /// <summary>
        /// Gets the parent color of the character at the index specified.
        /// </summary>
        /// <param name="charIndex">The character index to look around for a parent color.</param>
        /// <param name="count">How many characters to span.</param>
        /// <param name="rtf">The RTF of a RichTextBox.</param>
        /// <returns>-1, if no parent color found.</returns>
        private static string GetParentColor(int charIndex, int count, string rtf)
        {
            int index = rtf.LastIndexOf(@"\cf", charIndex, count, StringComparison.Ordinal);
            if (index == -1 || index + 5 >= rtf.Length) return @"\cf0 ";
            return rtf.Substring(index, 5); // Include right space
        }

        /// <summary>
        /// Performs syntax highlighting with the loaded Highlighter.
        /// </summary>
        public void Highlight()
        {
            if (HighlighterEnabled && Highlighter != null && !highlighting)
            {
                highlighting = true;
                int selectionStart = SelectionStart;
                int selectionLen = SelectionLength;
                string rtf = Rtf;
                rtf = Regex.Replace(rtf, @"\cf\d+ ?", string.Empty);
                // Get the end of the header so we don't accidental format it
                int headerEnd = GetRtfHeaderEnd();
                var table = new RichColorTable();

                // Iterate highlighting profiles and apply them
                foreach (var profile in Highlighter.Profiles)
                {
                    var regex = new Regex(profile.Pattern, profile.RegexOptions);
                    MatchCollection MC = regex.Matches(rtf, headerEnd);
                    bool usingGroups = regex.GetGroupNames().Contains("Value");
                    if (MC.Count <= 0) continue;

                    table.AddColors(profile.Color);
                    string colorID = @"\cf" + table.Colors.Count() + " ";

                    // Do this in reverse so the size of the text does not effect the insertions
                    for (int i = MC.Count - 1; i >= 0; i--)
                    {
                        int start = usingGroups ? MC[i].Groups["Value"].Index : MC[i].Index;
                        int length = usingGroups ? MC[i].Groups["Value"].Length : MC[i].Length;
                        // So we dont get trailing color
                        var parentCol = GetParentColor(start, start - headerEnd, rtf);
                        rtf = rtf.Insert(start + length, parentCol);
                        // Insert color tag
                        rtf = rtf.Insert(start, colorID);
                    }
                }

                rtf = table.InjectTable(rtf);
                Rtf = rtf;
                SelectionStart = selectionStart;
                SelectionLength = selectionLen;
                highlighting = false;
            }
        }

        /// <summary>
        /// Gets the end of the RTF header.
        /// </summary>
        private int GetRtfHeaderEnd()
        {
            Match match = Regex.Match(Rtf, @"\\viewkind");
            return match.Success ? match.Index + match.Length : 0;
        }
    }
}
