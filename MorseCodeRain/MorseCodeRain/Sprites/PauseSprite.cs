using System;
using System.Drawing;
using System.Windows.Forms;

namespace MorseCodeRain.Sprites
{
    /// <summary>
    /// Represents the graphics to be displayed when the game is paused
    /// </summary>
    class PauseSprite : Sprite, IDisposable
    {
        private Font font = new Font("Arial", 20f, FontStyle.Bold);
        private Size fontSize;
        private const string CAPTION = "Paused";

        public override void AdjustScale(Size canvasSize)
        {
            font = new Font("Arial", canvasSize.Height / 8f, FontStyle.Bold);
            fontSize = TextRenderer.MeasureText(CAPTION, font);
        }

        public override void Draw(Graphics graphics, Size canvasSize, decimal frameLength)
        {
            Size size = new Size(canvasSize.Width, (int)(canvasSize.Height * .3f));
            var point = new Point(0, canvasSize.Height/2 - size.Height/2);
            var rect = new Rectangle(point, size);
            graphics.FillRectangle(new SolidBrush(Color.FromArgb(30, 30, 30)), rect);
            int x = canvasSize.Width / 2 - fontSize.Width / 2;
            int y = canvasSize.Height / 2 - fontSize.Height / 2;
            graphics.DrawString(CAPTION, font, Brushes.White, x, y);
        }

        public void Dispose()
        {
            font.Dispose();
        }
    }
}
