using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Diagnostics;

namespace LogFileRemover
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            listBoxRemoved.Items.Clear();
            listBoxUnremovable.Items.Clear();
            progressBar.Style = ProgressBarStyle.Marquee;
            buttonStart.Visible = false;
            checkBoxStrictRemoval.Enabled = false;
            logRemover.RunWorkerAsync(checkBoxStrictRemoval.Checked);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            logRemover.CancelAsync();
        }

        private void logRemover_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // Result is a multi-dimensional array.
            // The first array is the removable filePaths.
            // The second is the irremovable filePaths.
            string[][] filePathSet = (string[][])e.Result;
            listBoxRemoved.SuspendLayout();
            listBoxRemoved.Items.Clear();
            listBoxRemoved.Items.AddRange(filePathSet[0]);
            listBoxRemoved.ResumeLayout();
            listBoxUnremovable.SuspendLayout();
            listBoxUnremovable.Items.Clear();
            listBoxUnremovable.Items.AddRange(filePathSet[1]);
            listBoxUnremovable.ResumeLayout();
            lblRemoved.Text = listBoxRemoved.Items.Count + " Removed:";
            lblUnremovable.Text = listBoxUnremovable.Items.Count + " Unremovable:";
            // Disable progress animation.
            progressBar.Style = ProgressBarStyle.Blocks;
            checkBoxStrictRemoval.Enabled = true;
            buttonStart.Visible = true;
        }

        private void listBoxUnremovable_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxUnremovable.SelectedItem != null)
            {
                try
                {
                    Process.Start(listBoxUnremovable.SelectedItem.ToString());
                }
                catch (Exception ex)
                {
                    string message = "Unable to open file.\n" + ex.Message;
                    MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
