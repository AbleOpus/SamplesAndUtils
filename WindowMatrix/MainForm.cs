using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace WindowMatrix
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void timerDraw_Tick(object sender, EventArgs e) => 
            BackgroundImage = CaptureRegion(Bounds);

        /// <summary>
        /// Captures the specified screen region as a a bitmap.
        /// </summary>
        /// <param name="rect">The rectangular region to capture.</param>
        /// <returns>The captured bitmap.</returns>
        public static Bitmap CaptureRegion(Rectangle rect)
        {
            Bitmap screenshot = new Bitmap(rect.Width, rect.Height, PixelFormat.Format32bppRgb);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(rect.Location, Point.Empty, rect.Size);
            }

            return screenshot;
        }
    }
}
