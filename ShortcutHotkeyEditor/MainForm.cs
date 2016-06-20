using System;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace ShortcutHotkeyEditor
{
    public partial class MainForm : Form
    {
        private string shortcutPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeShortcutHotkey()
        {
            IWshShell_Class wshShell = new IWshShell_Class();
            object tempObj = wshShell.CreateShortcut(shortcutPath);
            IWshShortcut shortcut = (IWshShortcut)tempObj;
            shortcut.Hotkey = testBoxHotkey.Text;
            shortcut.Save();
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = "Shortcut|*.lnk";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    shortcutPath = dialog.FileName;
                    buttonPickPath.Text = dialog.SafeFileName;
                    buttonSave.Enabled = true;
                    buttonSave.Select();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                ChangeShortcutHotkey();
                MessageBox.Show("Change saved to shortcut!", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (Exception ex)
            {
                string message = "Unable to change shortcut hotkey!" + "\n" + ex.Message;
                MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
