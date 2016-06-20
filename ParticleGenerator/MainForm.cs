using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace ParticleGenerator
{
    public partial class MainForm : Form
    {
        //Random number for our x and y particle positions
        private readonly Random randomNum = new Random();
        private Graphics graphics;

        public MainForm()
        {
            InitializeComponent();
            graphics = CreateGraphics();
            Size = SystemInformation.PrimaryMonitorSize;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            graphics = CreateGraphics();
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }
        }

        private void Render()
        {
            if (checkBoxClear.Checked)
                graphics.Clear(BackColor);

            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.High;
            int xMinPos = 0, xMaxPos = 0, yMinPos = 0, yMaxPos = 0;
            SetParticleBoundarys(ref xMinPos, ref xMaxPos, ref yMinPos, ref yMaxPos);
            float particleWidth = (float)numberBoxParticleSize.Value;

            using (var brush = new SolidBrush(panelColor.BackColor))
            {
                //Generate particles according to the max/min pos, count, and particle width.
                for (int i = 0; i < numberBoxParticles.Value; i++)
                {
                    var xPos = randomNum.Next(xMinPos, xMaxPos);
                    var yPos = randomNum.Next(yMinPos, yMaxPos);
                    graphics.FillEllipse(brush, xPos, yPos, particleWidth, particleWidth);
                }
            }
        }

        /// <summary>
        /// Sets the particles rectangular boundary using the value
        /// provided by the numeric up down density control.
        /// </summary>
        private void SetParticleBoundarys(ref int xMinPos, ref int xMaxPos, ref int yMinPos, ref int yMaxPos)
        {
            // Apply multiplier to the width and height to get smaller bounds.
            xMaxPos = (int)(Width * numberBoxDensity.Value + 0.5m);
            yMaxPos = (int)(Height * numberBoxDensity.Value + 0.5m);

            // Get the difference between the size of the form and the new bounds.
            // Then do some wacky calculations to center the particles.
            xMinPos = ((Width - xMaxPos) / 4) + ((Width - xMaxPos) / 2);
            yMinPos = ((Height - yMaxPos) / 4) + ((Height - yMaxPos) / 2);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (BackgroundImage == null)
            {
                MessageBox.Show("Image not generated.", Application.ProductName,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "Bitmap Format|*.bmp";
                dialog.InitialDirectory =
                    Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    BackgroundImage.Save(dialog.FileName);
                }
            }
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog dialog = new ColorDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    panelColor.BackColor = dialog.Color;
                }
            }
        }

        private void buttonGenerate_Click(object sender, EventArgs e)
        {
            Render();
        }
    }
}
