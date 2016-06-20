using System;
using System.Windows.Forms;

namespace MsgSandBox
{
    public partial class SandBoxForm : Form
    {
        /// <summary>
        /// Occurs when a windows forms message has been processed.
        /// </summary>
        public event EventHandler<Message> MessageReceived;

        public SandBoxForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            MessageReceived?.Invoke(this, m);
        }
    }
}
