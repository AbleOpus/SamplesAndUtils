using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using WebFilesEnhanced.Properties;
using System.ComponentModel;
using System.Linq;

namespace WebFilesEnhanced
{
    public partial class MainForm : Form
    {
        private readonly List<string> webFilePaths = new List<string>();
        private int editPathIndex = -1, previewPathIndex = -1;
        private string siteDirectory;

        public MainForm()
        {
            InitializeComponent();
            LoadSettingsAndDefaults();
        }

        private void LoadSettingsAndDefaults()
        {
            splitContainer.Orientation = Settings.Default.SplitViewOrient;
            richTextBoxCode.Font = Settings.Default.EditorFont;

            if (Settings.Default.SplitterDistance == 0)
            {
                Settings.Default.SplitterDistance = splitContainer.ClientSize.Width / 2;
            }

            splitContainer.SplitterDistance = Settings.Default.SplitterDistance;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            SaveFile();
            Settings.Default.SplitViewOrient = splitContainer.Orientation;
            Settings.Default.SplitterDistance = splitContainer.SplitterDistance;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.F5)
            {
                SaveFile();
                UpdatePreview();
            }
        }

        private void LoadWebSite(string sitePath)
        {
            string[] filePaths;

            try
            {
                filePaths = Directory.GetFiles(sitePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            siteDirectory = sitePath;

            foreach (string file in filePaths)
            {
                string ext = Path.GetExtension(file).ToLower();
                //if it is a plain text web file, then add safeFileName to
                // edit file comboBox and _webFiles List
                if (ext == ".css" || ext == ".html" || ext == ".htm")
                {
                    var name = Path.GetFileName(file);
                    comboEditFile.Items.Add(name);
                    comboPreviewFile.Items.Add(name);
                    webFilePaths.Add(file);
                }
            }

            SetDefaultPage(filePaths);
        }

        private void SetDefaultPage(string[] fileNames)
        {
            int index = 0;

            for (int i = 0; i < fileNames.Length; i++)
            {
                string fileName = Path.GetFileNameWithoutExtension(fileNames[i]).ToLower();
                //If there is an index file, set it as the default viewed page
                if (fileName == "index")
                {
                    index = i;
                    break;
                }
            }

            editPathIndex = previewPathIndex = index;
            comboEditFile.SelectedIndex = index;
            comboPreviewFile.SelectedIndex = index;
            UpdateEditor();
            UpdatePreview();
            SetControlAbility(true);
        }

        /// <summary>
        /// Enables or disables controls that operate on website files
        /// </summary>
        private void SetControlAbility(bool isEnabled)
        {
            btnCloseSite.Enabled = isEnabled;
            btnNewFile.Enabled = isEnabled;
            richTextBoxCode.Enabled = isEnabled;
            comboEditFile.Enabled = isEnabled;
            comboPreviewFile.Enabled = isEnabled;
            tsmiZoomFactor.Enabled = isEnabled;
            btnExploreSite.Enabled = isEnabled;
        }

        /// <summary>
        /// Reads the web document and updates the textBoxes text accordingly
        /// </summary>
        private void UpdateEditor()
        {
            richTextBoxCode.Text = File.ReadAllText(webFilePaths[editPathIndex]);
        }

        /// <summary>
        /// Writes any chages to the selected edit file
        /// </summary>
        private void SaveFile()
        {
            if (editPathIndex != -1)
            {
                string fileName = webFilePaths[editPathIndex];

                if (File.Exists(fileName))
                {
                    File.WriteAllText(fileName, richTextBoxCode.Text);
                }
            }
        }

        /// <summary>
        /// Navigates the webBrowser control to the selected preview file
        /// </summary>
        private void UpdatePreview()
        {
            webBrowser.Navigate(webFilePaths[previewPathIndex]);
        }

        private void UncheckAllZoomItems()
        {
            foreach (ToolStripMenuItem item in tsmiZoomFactor.DropDownItems)
            {
                item.Checked = false;
            }
        }

        /// <summary>
        /// Reset any values related to the website
        /// </summary>
        private void CloseWebSite()
        {
            comboEditFile.Items.Clear();
            comboPreviewFile.Items.Clear();
            webFilePaths.Clear();
            richTextBoxCode.Clear();
            //Navigate away from absent page
            webBrowser.Navigate(string.Empty);
            //Reset siteDirectory to null
            siteDirectory = null;
            //Disable webSite file related controls
            SetControlAbility(false);
        }

        #region Event handlers
        private void buttonOpenDir_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (Settings.Default.LastFolder.Length > 0)
                {
                    folderBrowserDialog.SelectedPath = Settings.Default.LastFolder;
                }

                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        LoadWebSite(folderBrowserDialog.SelectedPath);
                        Settings.Default.LastFolder = folderBrowserDialog.SelectedPath;
                    }
                    catch (Exception ex)
                    {
                        CloseWebSite();
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }

        private void comboSelectEditFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            editPathIndex = comboEditFile.SelectedIndex;
            UpdateEditor();
        }

        private void comboSelectPreviewFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            previewPathIndex = comboPreviewFile.SelectedIndex;
            UpdatePreview();
        }

        private void buttonCloseWebSite_Click(object sender, EventArgs e)
        {
            CloseWebSite();
        }

        private void buttonNewFile_Click(object sender, EventArgs e)
        {
            using (NewFileDialog dialog = new NewFileDialog())
            {
                dialog.InitialDirectory = siteDirectory;
                //Open the form at the cursor position for convenience
                dialog.Location = Cursor.Position;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    //Reopen WebSite, easiest way to add file to project
                    string temp = siteDirectory;
                    CloseWebSite();
                    LoadWebSite(temp);
                }
            }
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            using (SettingsDialog formSettings = new SettingsDialog())
            {
                formSettings.SplitViewOrientationChanged += FormSettingsOnSplitViewOrientationChanged;
                formSettings.FontPicked += delegate { richTextBoxCode.Font = Settings.Default.EditorFont; };
                formSettings.ShowDialog();
            }
        }

        private void FormSettingsOnSplitViewOrientationChanged(object sender, Orientation orientation)
        {
            Settings.Default.SplitViewOrient = orientation;
            splitContainer.Orientation = orientation;

            if (orientation == Orientation.Horizontal)
            {
                splitContainer.SplitterDistance = splitContainer.ClientSize.Height/2;
            }
            else
            {
                splitContainer.SplitterDistance = splitContainer.ClientSize.Width / 2;
            }
        }

        private void ZoomItems_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem current = ((ToolStripMenuItem)sender);
            // We are using the tag property to store the int
            int zoomLevel = int.Parse(current.Tag.ToString());
            webBrowser.Zoom(zoomLevel);
            UncheckAllZoomItems();
            current.Checked = true;
        }

        private void buttonExplore_Click(object sender, EventArgs e)
        {
            if (siteDirectory == null)
            {
                MessageBox.Show("No site loaded.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Process.Start(siteDirectory);
            }
        }
        #endregion
    }
}
