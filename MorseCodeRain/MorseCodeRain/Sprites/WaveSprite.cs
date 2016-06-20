using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace MorseCodeRain.Sprites
{
    /// <summary>
    /// Represents the moving wave game graphics.
    /// </summary>
    class WaveSprite : Sprite, IDisposable
    {
        private float waveBaseHeight, x, arcWidth;
        private decimal loopPercent;

        /// <summary>
        /// Gets or sets how many arc there are in the wave.
        /// </summary>
        public float ArcCount { get; set; } = 15;

        /// <summary>
        /// Gets or sets the height of the arc (According to DrawArc).
        /// </summary>
        public float ArcHeight { get; set; }

        /// <summary>
        /// Gets or sets the height of the base of the wave as a percentage
        /// of the canvas height.
        /// </summary>
        public float WaveBasePercent { get; set; }

        /// <summary>
        /// Gets or sets whether the waves move right to left or the other way.
        /// </summary>
        public bool RightToLeft { get; set; }

        /// <summary>
        /// Gets or sets the animation speed of the waves.
        /// </summary>
        public decimal WaveSpeed { get; set; } = 0.002m;

        private readonly SolidBrush brush = new SolidBrush(Color.SteelBlue);
        public Color WaveColor
        {
            get { return brush.Color; }
            set { brush.Color = value; }
        }

        public override void Draw(Graphics graphics, Size canvasSize, decimal frameLength)
        {
            var path = new GraphicsPath();
            float arcY = canvasSize.Height - ArcHeight - waveBaseHeight;
            // We need a wave padding on either side 
            // (+1 for the path imperfection on smaller sweeps)
            arcWidth = canvasSize.Width / (ArcCount - 3);

            for (int i = 0; i < ArcCount; i++)
            {
                float arcX = x + arcWidth * i;
                // Arc must be inversed so we can connect path properly from left to right 
                path.AddArc(arcX, arcY, arcWidth, ArcHeight, 130, -110);
            }

            path.AddLine(canvasSize.Width, canvasSize.Height, 0, canvasSize.Height);
            graphics.FillPath(brush, path);
            path.Dispose();

            if (RightToLeft)
            {
                loopPercent -= frameLength * WaveSpeed;
                x = arcWidth * -2 + (arcWidth * (float)loopPercent);
                if (loopPercent < 0) loopPercent = 1;
            }
            else
            {
                loopPercent += frameLength * WaveSpeed;
                x = arcWidth * -2 + (arcWidth * (float)loopPercent);
                if (loopPercent > 1) loopPercent = 0;
            }
        }

        public override void AdjustScale(Size canvasSize)
        {
            ArcHeight = canvasSize.Height * 0.1f;
            waveBaseHeight = canvasSize.Height * WaveBasePercent;
        }

        public void Dispose()
        {
            brush.Dispose();
        }
    }
}
