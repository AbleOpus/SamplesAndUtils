using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABitOfMemory
{
    public partial class HighScoreForm : Form
    {
        private int time;
        private const float BORDER_STROKE = 6f;
        private readonly Pen pen = new Pen(Color.Black, BORDER_STROKE);

        public HighScoreForm()
        {
            InitializeComponent();
            tmrAnimate.Start();
        }

        public void SetHighScore(int highscore)
        {
            labelScore.Text += highscore;
        }

        public void SetSequence(string sequence)
        {
            labelSequence.Text = sequence;
        }

        private void timerAnimate_Tick(object sender, EventArgs e)
        {
            if (time == 4)
            {
                tmrAnimate.Stop();
                return;
            }

            // Alternate visibility according to the tick oddness.
            Opacity = (++time).IsOdd() ? 0 : 1;
        }


        private void HighScoreForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelScore_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, 0, BORDER_STROKE/2, labelScore.Width, BORDER_STROKE/2);
        }

        private void labelSequence_Paint(object sender, PaintEventArgs e)
        {
            float x1 = labelSequence.Height - BORDER_STROKE + 1;
            float y2 = labelSequence.Height - BORDER_STROKE + 1;
            e.Graphics.DrawLine(pen, 0, x1, labelSequence.Width, y2);
        }
    }
}
