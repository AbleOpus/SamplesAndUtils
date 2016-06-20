using System;
using System.IO;
using System.Windows.Forms;
using IniEditing;

namespace IniEditingDemo
{
    public partial class MainForm : Form
    {
        private readonly IniEditor iniEditor = new IniEditor();

        public MainForm(string[] args)
        {
            InitializeComponent();
            SetUiEditReady(false);

            if (args.Length > 0)
            {
                LoadIni(args[0]);
            }
        }

        /// <summary>
        /// Sets the enabled property of controls according to whether an .ini is loaded.
        /// </summary>
        private void SetUiEditReady(bool ready)
        {
            foreach (Control control in Controls)
                control.Enabled = ready;

            buttonLoad.Enabled = true;
        }

        private void LoadIni(string fileName)
        {
            try
            {
                iniEditor.Load(fileName);
                DisplayContent();
                iniEditor.AutoSetCommentChar();
                SetUiEditReady(true);
            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void DisplayIfSuccess(bool success)
        {
            if (success)
            {
                DisplayContent();
            }
            else
            {
                MessageBox.Show("Could not find key", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private static void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, Application.ProductName,
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void DisplayContent()
        {
            textBoxContent.Text = iniEditor.GetContent();
            labelInfo.Text = $"Loaded File: {Path.GetFileName(iniEditor.FileName)}\nSection Count:" + 
                $" {iniEditor.SectionCount}\nComment Count: {iniEditor.CommentCount}\nPair Count: {iniEditor.KeyCount}";
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            using (var dialogOpenFile = new OpenFileDialog())
            {
                dialogOpenFile.Filter = "Initialization|*.ini|Config|*.cfg";

                if (dialogOpenFile.ShowDialog() == DialogResult.OK)
                {
                    LoadIni(dialogOpenFile.FileName);
                }
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            bool success = iniEditor.ModifyValue(textBoxSection.Text,
                textBoxKeyName.Text, textBoxNewValue.Text, true, true);

            DisplayIfSuccess(success);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                iniEditor.Save();

                MessageBox.Show("Saved!", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                ShowErrorMessage(ex.Message);
            }
        }

        private void buttonRemoveComment_Click(object sender, EventArgs e)
        {
            iniEditor.RemoveAllComments();
            DisplayContent();
        }

        private void buttonFormatBlankLines_Click(object sender, EventArgs e)
        {
            iniEditor.FormatBlankLines();
            DisplayContent();
        }

        private void buttonIndentAll_Click(object sender, EventArgs e)
        {
            iniEditor.IndentAllPairs();
            DisplayContent();
        }

        private void buttonUnIndentAll_Click(object sender, EventArgs e)
        {
            iniEditor.UnindentAllPairs();
            DisplayContent();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            var success = textBoxNewValue.TextLength > 0 ?
                iniEditor.RemoveKey(textBoxSection.Text, textBoxKeyName.Text, textBoxNewValue.Text) :
                iniEditor.RemoveKey(textBoxSection.Text, textBoxKeyName.Text);

            DisplayIfSuccess(success);
        }

        private void buttonRemoveEmpty_Click(object sender, EventArgs e)
        {
            iniEditor.RemoveEmptyKeys();
            DisplayContent();
        }
    }
}
