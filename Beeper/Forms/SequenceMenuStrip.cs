using System;
using System.IO;
using System.Windows.Forms;

namespace Beeper.Forms
{
    class SequenceMenuStrip : ContextMenuStrip
    {
        /// <summary>
        /// Occurs when the user clicks on a sequence and it is loaded.
        /// </summary>
        public event EventHandler<string> SequenceLoaded;

        public SequenceMenuStrip()
        {
            string[] fileNames = Directory.GetFiles(Application.StartupPath, "*.txt");

            foreach (string fileName in fileNames)
            {
                string name = Path.GetFileNameWithoutExtension(fileName);
                var item = new ToolStripMenuItem(name, null, MenuItem_Clicked);
                item.Tag = fileName;
                Items.Add(item);
            }
        }

        private void MenuItem_Clicked(object sender, EventArgs e)
        {
            if (SequenceLoaded == null) return;
            var item = sender as ToolStripMenuItem;

            if (item != null)
            {
                try
                {
                    SequenceLoaded(this, File.ReadAllText(item.Tag.ToString()));
                }
                catch (Exception ex)
                {
                    ex.ShowError();
                }
            }
        }
    }
}
