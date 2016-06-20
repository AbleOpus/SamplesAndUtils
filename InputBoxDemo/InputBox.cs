using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace InputBoxDemo
{
    class InputBox : TextBox
    {
        /// <summary>
        /// Occurs when text has been submitted using the enter key.
        /// </summary>
        public event EventHandler TextSubmitted;

        /// <summary>
        /// Gets whether to use the enter key to submit text.
        /// </summary>
        [Description("Whether to use the enter key to submit text."), Category("Behavior")]
        public bool SubmitOnEnter { get; set; }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (SubmitOnEnter && e.KeyCode == Keys.Enter && !e.Shift)
            {
                // Do not add a newline to the text box after clearing
                e.SuppressKeyPress = true;
                TextSubmitted?.Invoke(this, EventArgs.Empty);
                Clear();
            }
        }
    }
}
