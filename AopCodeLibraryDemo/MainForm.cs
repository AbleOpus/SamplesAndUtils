using System.Windows.Forms;
using AboCodeLibrary;

namespace AopCodeLibraryDemo
{
    public partial class MainForm : Form
    {
        private readonly FormFader fader;

        public MainForm()
        {
            InitializeComponent();
            fader = new FormFader(this);
            fader.FadeInIncrement = 0.05;
        }

        private void MainForm_MouseEnter(object sender, System.EventArgs e)
        {
            fader.FadeTo(1);
        }

        private void MainForm_MouseLeave(object sender, System.EventArgs e)
        {
            fader.FadeTo(0.5);
        }
    }
}
