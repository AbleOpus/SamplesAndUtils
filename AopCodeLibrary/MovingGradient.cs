using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AboCodeLibrary
{
    /// <summary>
    /// Applies a moving, 2-color, gradient effect to a <see cref="Control"/>.
    /// </summary>
    public class MovingGradient : IDisposable
    {
        private readonly Timer timerAnimate = new Timer();
        private readonly Graphics graphics;
        private LinearGradientBrush lgb;
        private Rectangle rect;
        private readonly Control control;

        /// <summary>
        /// Gets or sets the first color of the gradient.
        /// </summary>
        public Color Color1 { get; set; }

        /// <summary>
        /// Gets or sets the second color of the gradient.
        /// </summary>
        public Color Color2 { get; set; }

        /// <summary>
        /// Gets or sets the angle of the gradient.
        /// </summary>
        public float GradientAngle { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MovingGradient"/> class
        /// with the specified arguments.
        /// </summary>
        /// <param name="control"></param>
        /// <param name="gradientAngle">The angle of the gradient.</param>
        /// <param name="color1">The first color of the gradient.</param>
        /// <param name="color2">The second color of the gradient.</param>
        public MovingGradient(Control control, float gradientAngle, Color color1, Color color2)
        {
            timerAnimate.Interval = 1;
            timerAnimate.Tick +=TimerAnimateTick;
            GradientAngle = gradientAngle;
            Color1 = color1;
            Color2 = color2;
            this.control = control;
            rect = control.ClientRectangle;
            graphics = control.CreateGraphics();
        }

        private void TimerAnimateTick(object sender, EventArgs e)
        {
            rect = new Rectangle(rect.X + 1, rect.Y + 1, rect.Width, rect.Height);
            lgb?.Dispose(); // Dispose old LGB.
            lgb = new LinearGradientBrush(rect, Color1, Color2, GradientAngle);
            lgb.WrapMode = WrapMode.TileFlipX;
            graphics.FillRectangle(lgb, control.ClientRectangle);
        }

        /// <summary>
        /// Starts the gradient animation.
        /// </summary>
        public void StartAnimation()
        {
            timerAnimate.Start();
        }

        /// <summary>
        /// Stops the gradient animation.
        /// </summary>
        public void StopAnimation()
        {
            timerAnimate.Stop();
        }

        /// <summary>
        /// Releases all resources used by the <see cref="MovingGradient"/>, other than the control.
        /// </summary>
        public void Dispose()
        {
            timerAnimate.Dispose();
            graphics?.Dispose();
            lgb?.Dispose();
        }
    }
}
