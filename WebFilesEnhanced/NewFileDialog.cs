using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace WebFilesEnhanced
{
    public partial class NewFileDialog : Form
    {
        public string InitialDirectory { get; set; }

        public string FileName => textBoxFileName.Text;

        public NewFileDialog()
        {
            InitializeComponent();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (Path.GetInvalidFileNameChars().Any(c => textBoxFileName.Text.Contains(c)))
            {
                MessageBox.Show("Invalid characters in file name.", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string ext = Path.GetExtension(textBoxFileName.Text);
            string fileName = InitialDirectory + '\\' + textBoxFileName.Text;

            if (ext == ".html" || ext == ".htm")
            {
                DialogResult result = MessageBox.Show(
                    "Would you like to insert a HTML template int your document?", 
                    Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                switch (result)
                {
                    case DialogResult.Yes:
                        string templateData = File.ReadAllText("template.html");
                        File.WriteAllText(fileName, templateData);
                        break;

                    case DialogResult.No:
                        File.Create(fileName);
                        break;
                }
            }
            else
            {
                File.Create(fileName);
            }

            Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e) =>
            Close();
    }
}
