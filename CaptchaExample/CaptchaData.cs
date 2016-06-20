using System;
using System.Drawing;

namespace CaptchaExample
{
    /// <summary>
    /// Represents data for a captcha system.
    /// </summary>
    class CaptchaData : IDisposable
    {
        /// <summary>
        /// Gets the captcha image generated.
        /// </summary>
        public Bitmap Image { get; } = new Bitmap(310, 77);

        /// <summary>
        /// Gets the captcha code which corresponds to the image.
        /// </summary>
        public string Code { get; private set; } = string.Empty;

        public CaptchaData()
        {
            SetRandomizedCode();
            SetBitmap();
        }

        private void SetBitmap()
        {
            const FontStyle style = FontStyle.Italic | FontStyle.Strikeout | FontStyle.Underline | FontStyle.Bold;

            using (Font font = new Font("Arial", 50f, style))
            {
                using (Graphics graphics = Graphics.FromImage(Image))
                {
                    graphics.RotateTransform(11);
                    graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    graphics.FillRectangle(Brushes.LightBlue, 0, 0, Image.Width, Image.Height);
                    graphics.DrawString(Code, font, Brushes.CornflowerBlue, new Point(0, -25));
                }
            }
        }

        private void SetRandomizedCode()
        {
            Code = string.Empty;

            Random random = new Random();

            for (int i = 0; i < 7; i++)
            {
                Code += random.Next(0, 10).ToString();
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        /// <filterpriority>2</filterpriority>
        public void Dispose()
        {
            Image?.Dispose();
        }
    }
}
