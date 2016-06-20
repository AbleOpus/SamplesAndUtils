using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ImageEditor
{
    /// <summary>
    /// The plug-in provider.
    /// </summary>
    public static class Plugin
    {
        public static string Caption => "Invert Colors";

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
                    graphics.Clear(Color.Aquamarine);
                    graphics.DrawRectangle(Pens.CornflowerBlue, 0, 0, bitmap.Width - 1, bitmap.Height - 1);
                }

                return bitmap;
            }
        }

        /// <summary>
        /// The entry point for the plug-in, the only method to be called by the program.
        /// </summary>
        public static void Entry(PictureBox picBox)
        {
            BitmapInvertColors((Bitmap)picBox.Image);
            picBox.Invalidate(); // Most likely want the changes to appear right away
        }

        private static void BitmapInvertColors(Bitmap bitmapImage)
        {
            var bitmapRead = bitmapImage.LockBits(new Rectangle(0, 0, bitmapImage.Width, bitmapImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppPArgb);
            var bitmapLength = bitmapRead.Stride * bitmapRead.Height;
            var bitmapBGRA = new byte[bitmapLength];
            Marshal.Copy(bitmapRead.Scan0, bitmapBGRA, 0, bitmapLength);
            bitmapImage.UnlockBits(bitmapRead);

            for (int i = 0; i < bitmapLength; i += 4)
            {
                bitmapBGRA[i] = (byte)(255 - bitmapBGRA[i]);
                bitmapBGRA[i + 1] = (byte)(255 - bitmapBGRA[i + 1]);
                bitmapBGRA[i + 2] = (byte)(255 - bitmapBGRA[i + 2]);
                //        [i + 3] = ALPHA.
            }

            var bitmapWrite = bitmapImage.LockBits(new Rectangle(0, 0, bitmapImage.Width, bitmapImage.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppPArgb);
            Marshal.Copy(bitmapBGRA, 0, bitmapWrite.Scan0, bitmapLength);
            bitmapImage.UnlockBits(bitmapWrite);
        }
    }
}
