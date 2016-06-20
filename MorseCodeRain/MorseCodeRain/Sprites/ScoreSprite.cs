using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace MorseCodeRain.Sprites
{
    /// <summary>
    /// Represents the score display graphics.
    /// </summary>
    class ScoreSprite : Sprite, IDisposable
    {
        private readonly SolidBrush foreBrush = new SolidBrush(Color.LightGray);
        private bool needsLayout;
        private Font font;
        private PointF location;
        public static readonly Color GreenColor = Color.DarkGreen;
        public static readonly Color RedColor = Color.DarkRed;

        private int score;
        public int Score
        {
            get { return score; }
            set
            {
                if (value > score)
                    FadeFrom(GreenColor);
                else if (value < score)
                    FadeFrom(RedColor);

                score = value;
                needsLayout = true;
            }
        }
        
        public override void AdjustScale(Size canvasSize)
        {
            base.AdjustScale(canvasSize);
            font = new Font("Comic Sans MS", canvasSize.Width * 0.03f, FontStyle.Bold);
            string strScore = score.ToString();
            Size fontSize = TextRenderer.MeasureText(strScore, font);
            float x = canvasSize.Width / 2f - fontSize.Width / 2f;
            float y = canvasSize.Height - fontSize.Height;
            location = new PointF(x, y);
        }

        public override void Draw(Graphics gfx, Size canvasSize, decimal frameLength)
        {
            if (needsLayout)
            {
                AdjustScale(canvasSize);
                needsLayout = false;
            }

            if (foreBrush.Color != Color.White)
            {
                int increment = (int)(frameLength / 10.0m);
                int R = (foreBrush.Color.R < 255) ? foreBrush.Color.R + increment : foreBrush.Color.R;
                int G = (foreBrush.Color.G < 255) ? foreBrush.Color.G + increment : foreBrush.Color.G;
                int B = (foreBrush.Color.B < 255) ? foreBrush.Color.B + increment : foreBrush.Color.B;
                if (R > 255) R = 255;
                if (B > 255) B = 255;
                if (G > 255) G = 255;
                foreBrush.Color = Color.FromArgb(R, G, B);
            }

            gfx.DrawString(score.ToString(CultureInfo.InvariantCulture), font, foreBrush, location);
        }

        /// <summary>
        /// Sets the color at which to fade from.
        /// </summary>
        public void FadeFrom(Color color) => foreBrush.Color = color;

        public void Dispose()
        {
            foreBrush?.Dispose();
            font?.Dispose();
        }
    }
}
