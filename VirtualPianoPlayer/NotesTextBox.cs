using System;
using System.Text;
using System.Windows.Forms;

namespace VirtualPianoPlayer
{
    class NotesTextBox : TextBox
    {
        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                // Filter text
                StringBuilder SB = new StringBuilder(value);
                SB = SB.Replace("\r", " ");
                SB = SB.Replace("\n", " ");
                SB = SB.Replace("(", string.Empty);
                SB = SB.Replace(")", string.Empty);
                SB = SB.Replace("*", "8+");
                base.Text = SB.ToString();
            }
        }
    }
}
