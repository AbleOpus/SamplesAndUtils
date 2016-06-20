using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ImageEditor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PresentPlugins();
        }

        /// <summary>
        /// Loads the plug-ins using the plug-in manager and presents them 
        /// in the tool strip menu.
        /// </summary>
        private void PresentPlugins()
        {
            PluginManager pluginMan = new PluginManager(pictureBox);
    
            foreach (Plugin plugin in pluginMan.Plugins)
            {
                if (plugin.Exception == null)
                {
                    menuItemPlugins.DropDownItems.Add(plugin.MenuItem);
                }
                else
                {
                    MessageBox.Show(
                        $@"Could not load plugin ""{plugin.PluginName}"".\n{plugin.Exception.Message}", 
                        Application.ProductName, 
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            if (pictureBox.Image == null) return;

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = @"Bitmap|*.bmp";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox.Image.Save(dialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                dialog.Filter = @"Portable Network Graphics|*.png|Bitmap|*.bmp|Graphics Interchange|*.gif|JPEG|*.jpeg;*.jpg";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox.Image = Image.FromFile(dialog.FileName);
                    Text = Application.ProductName + " - " + Path.GetFileName(dialog.FileName);
                    menuItemSave.Enabled = true;
                    menuItemPlugins.Enabled = true;
                }
            }
        }
    }
}
