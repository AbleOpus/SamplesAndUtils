using System;
using System.Drawing;
using System.Windows.Forms;
using WebFilesEnhanced.Properties;

namespace WebFilesEnhanced
{
    public partial class SettingsDialog : Form
    {
        public event EventHandler<Font> FontPicked;

        public event EventHandler<Orientation> SplitViewOrientationChanged;

        public SettingsDialog()
        {
            InitializeComponent();
            checkBoxHorizSplitView.Checked = Settings.Default.SplitViewOrient == Orientation.Horizontal;
        }

        private void buttonPickFont_Click(object sender, EventArgs e)
        {
            using (FontDialog dialog = new FontDialog())
            {
                dialog.ShowEffects = false;
                dialog.AllowScriptChange = false;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Settings.Default.EditorFont = dialog.Font;
                    FontPicked?.Invoke(this, dialog.Font);
                }
            }
        }

        private void checkBoxHorizSplitView_CheckedChanged(object sender, EventArgs e)
        {
            Orientation orientation = checkBoxHorizSplitView.Checked ? Orientation.Horizontal : Orientation.Vertical;
            Settings.Default.SplitViewOrient = Orientation.Horizontal;
            SplitViewOrientationChanged?.Invoke(this, orientation);
        }
    }
}
