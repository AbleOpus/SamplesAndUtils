using System.Drawing;
using System.Windows.Forms;

namespace ImageEditor
{
    /// <summary>
    /// The plug-in provider.
    /// </summary>
    public static class Plugin
    {
        public static string Caption => "Add Border";

        /// <summary>
        /// Gets the image to be displayed next to the caption on the menu item.
        /// </summary>
        public static Bitmap Bitmap
        {
            get
            {
                // You may just retrieve an image from resources.

                // Programmatically draw icon.
                Bitmap bitmap = new Bitmap(16, 16);

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    graphics.DrawRectangle(Pens.Red, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
                }

                return bitmap;
            }
        }

        /// <summary>
        /// The entry point for the plug-in, the only method to be called by the program.
        /// </summary>
        public static void Entry(PictureBox picBox)
        {
            using (Graphics graphics = Graphics.FromImage(picBox.Image))
            {
                ControlPaint.DrawBorder3D(graphics, 0, 0, picBox.Image.Width, picBox.Image.Height);
            }

            picBox.Invalidate(); // Most likely want the changes to appear right away
        }
    }
}
