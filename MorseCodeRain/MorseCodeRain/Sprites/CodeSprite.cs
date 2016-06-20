using System;
using System.Drawing;
using System.Windows.Forms;

namespace MorseCodeRain.Sprites
{
    /// <summary>
    /// Represents a falling morse code sequence.
    /// </summary>
    class CodeSprite : Sprite, IDisposable
    {
        private Font font;
        private SizeF textSize;
        private const decimal SHRINK_SPEED = 0.00015m;
        private const decimal DROP_SPEED = 0.00009m;
        private float fontSize = 0.06f; // The size of the font as a percentage of the canvas
        private readonly float xPercent;
        private float widthDiff, heightDiff;

        #region Properties
        /// <summary>
        /// Gets the morse code associated with this sprite.
        /// </summary>
        public MorseCode MorseCode { get; }

        private readonly SolidBrush foreBrush = new SolidBrush(Color.Gainsboro);
        /// <summary>
        /// Gets or sets the color of the text.
        /// </summary>
        public Color ForeColor
        {
            get { return foreBrush.Color; }
            set { foreBrush.Color = value; }
        }

        public float YPercent { get; set; }

        /// <summary>
        /// Gets or sets the value that marks this sprite as correctly answered.
        /// </summary>
        public bool AnsweredCorrectly { get; set; }

        /// <summary>
        /// Gets whether this sprite is full hidden.
        /// </summary>
        public bool Hidden { get; private set; }
        #endregion

        public CodeSprite(Size canvasSize)
        {
            MorseCode = MorseCodeManager.GetRandomMorseCode(MorseCodeType.Any, true);
            UpdateFontScale(canvasSize.Width);
            // Set init y
            YPercent = (textSize.Height / canvasSize.Height) * -1.0f;
            // Set solid state x
            float textWidthPercent = textSize.Width / canvasSize.Width;
            Random random = new Random();
            int num = random.Next(0, 100 - (int)(textWidthPercent * 100f));
            xPercent = num / 100f;
            widthDiff = 0; // WidthDiff will be set and it needs to be zero off th start
        }

        public override void Draw(Graphics graphics, Size canvasSize, decimal frameLength)
        {
            YPercent += (float)(frameLength * DROP_SPEED);
            if (Hidden) return;

            if (AnsweredCorrectly)
            {
                fontSize -= (float)(frameLength * SHRINK_SPEED);
                UpdateFontScale(canvasSize.Width);
            }

            float lastX = canvasSize.Width * xPercent + widthDiff / 2f;
            float lastY = canvasSize.Height * YPercent + heightDiff / 2f;
            graphics.DrawString(MorseCode.Code, font, Brushes.Black, lastX + font.Size / 7f, lastY + font.Size / 8f);
            graphics.DrawString(MorseCode.Code, font, foreBrush, lastX, lastY);
        }

        public void UpdateFontScale(int canvasWidth)
        {
            float size = canvasWidth * fontSize;

            if (size < 0.1f)
            {
                Hidden = true;
                return;
            }

            font = new Font("Tahoma", canvasWidth * fontSize, FontStyle.Bold);
            SizeF textSize = TextRenderer.MeasureText(MorseCode.Code, font);
            widthDiff += this.textSize.Width - textSize.Width;
            heightDiff += this.textSize.Height - textSize.Height;
            this.textSize = textSize;
        }

        public void Dispose()
        {
            font?.Dispose();
            foreBrush?.Dispose();
        }
    }
}
