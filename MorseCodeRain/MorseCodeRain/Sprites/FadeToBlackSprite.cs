using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MorseCodeRain.Sprites
{
    /// <summary>
    /// Represents a fade to black effect.
    /// </summary>
    class FadeFromBlackSprite : Sprite, IDisposable
    {
        private LinearGradientBrush lgb1, lgb2;

        /// <summary>
        /// Gets or sets the top and bottom fade as a percentage of the canvas.
        /// </summary>
        public float FadePercent { get; set; }

        public FadeFromBlackSprite()
        {
            FadePercent = 0.2f;
        }

        public override void Draw(Graphics graphics, Size canvasSize, decimal frameLength)
        {
            if (canvasSize.Height == 0 || canvasSize.Width == 0)
                return;

            float height = canvasSize.Height * FadePercent;
            graphics.FillRectangle(lgb1, 0, 0, canvasSize.Width, height);
            graphics.FillRectangle(lgb2, 0, canvasSize.Height - height, canvasSize.Width, height);
        }

        public override void AdjustScale(Size canvasSize)
        {
            if (canvasSize.Height == 0 || canvasSize.Width == 0)
                return;

            float height = canvasSize.Height * FadePercent;
            var rect = new RectangleF(0, 0, canvasSize.Width, height);
            lgb1 = new LinearGradientBrush(rect, Color.Black, Color.Transparent, 90f);
            rect = new RectangleF(0, canvasSize.Height - height, canvasSize.Width, height);
            Color faintBlack = Color.FromArgb(200, 0, 0, 0);
            lgb2 = new LinearGradientBrush(rect, Color.Transparent, faintBlack, 90f);
            lgb1.WrapMode = lgb2.WrapMode = WrapMode.TileFlipXY;
        }

        public void Dispose()
        {
            lgb1.Dispose();
            lgb2.Dispose();
        }
    }
}
