using System;
using System.Windows.Forms;

namespace IOSSliderExample
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void iosSlider_ValueChanged(object sender, EventArgs e)
        {
            Text = iosSlider.GetValueInfo();
        }
    }
}
