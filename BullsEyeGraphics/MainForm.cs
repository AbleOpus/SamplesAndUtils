using System;
using System.Drawing;
using System.Windows.Forms;

namespace BullsEyeGraphics
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            //Create a high res bitmap to draw to
            Bitmap drawingSurface = new Bitmap(1000, 1000);
            //Create a graphics object to do the drawing
            using (Graphics graphics = Graphics.FromImage(drawingSurface))
            {
                //Make it look nice
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                graphics.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                //Draw bullseye
                graphics.FillEllipse(Brushes.Red, 0, 0, 1000, 1000);
                graphics.FillEllipse(Brushes.White, 100, 100, 800, 800);
                graphics.FillEllipse(Brushes.Red, 200, 200, 600, 600);
                graphics.FillEllipse(Brushes.White, 300, 300, 400, 400);
                graphics.FillEllipse(Brushes.Red, 400, 400, 200, 200);
            }

            //Display the bitmap in the pictureBox
            pictureBox.Image = drawingSurface;
        }
    }
}
