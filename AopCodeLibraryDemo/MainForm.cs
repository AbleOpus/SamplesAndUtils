using System.Drawing;
using System.Windows.Forms;
using AboCodeLibrary;

namespace AopCodeLibraryDemo
{
    public partial class MainForm : Form
    {
        private readonly FormFader fader;
        private readonly MovingGradient movingGradient;

        public MainForm()
        {
            InitializeComponent();
            fader = new FormFader(this);
            fader.FadeInIncrement = 0.05;
            movingGradient = new MovingGradient(this, 45, Color.YellowGreen, Color.Black);
            movingGradient.StartAnimation();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyData)
            {
                case Keys.Up:
                    this.DockTop();
                    break;

                case Keys.Down:
                    this.DockBottom();
                    break;

                case Keys.Left:
                    this.DockLeft();
                    break;

                case Keys.Right:
                    this.DockRight();
                    break;
            }
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
