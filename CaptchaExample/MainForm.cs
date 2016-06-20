using System;
using System.Windows.Forms;

namespace CaptchaExample
{
    public partial class MainForm : Form
    {
        private CaptchaData captchaData = new CaptchaData();

        public MainForm()
        {
            InitializeComponent();
            pictureBoxCaptcha.Image = captchaData.Image;
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            captchaData = new CaptchaData();
            pictureBoxCaptcha.Image = captchaData.Image;
            textBoxInput.Text = string.Empty;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (textBoxInput.Text == captchaData.Code)
            {
                MessageBox.Show("Information Submitted!", Application.ProductName,
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Captcha Input Invalid!", Application.ProductName, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
