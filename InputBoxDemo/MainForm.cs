using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InputBoxDemo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void inputBox_TextSubmitted(object sender, EventArgs e)
        {
            chatArea.AppendText(inputBox.Text + "\r\n\r\n");
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            chatArea.AppendText(inputBox.Text + "\r\n\r\n");
            inputBox.Clear();
        }
    }
}
