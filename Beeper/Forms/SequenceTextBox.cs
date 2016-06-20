using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Beeper.Forms
{
    class SequenceTextBox : TextBox
    {
        private MatchCollection matches;

        public SequenceTextBox()
        {
            HideSelection = false;
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.A && e.Control)
            {
                SelectAll();
                e.SuppressKeyPress = true;
            }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            matches = Regex.Matches(Text, @"\(\d+-\d+(-\d+)?\)");
        }

        /// <summary>
        /// Selects the text of the specified note.
        /// </summary>
        public void SelectNote(int index)
        {
            if (matches != null && index >= 0 && index < matches.Count)
            {
                int start = matches[index].Index;
                int len = matches[index].Length;
                Select(start, len);
                ScrollToCaret();
            }
        }
    }
}
