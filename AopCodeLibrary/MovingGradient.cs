using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AboCodeLibrary
{
    class MovingGradient
    {
        private readonly Timer timerAnimate = new Timer();
        private readonly Graphics graphics;
        private LinearGradientBrush lgb;
        private Rectangle rect;
        private readonly Control control;

        public Color Color1 { get; set; }

        public Color Color2 { get; set; }

        public float GradientAngle { get; set; }

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
            lgb = new LinearGradientBrush(rect, Color1, Color2, GradientAngle);
            lgb.WrapMode = WrapMode.TileFlipX;
            graphics.FillRectangle(lgb, control.ClientRectangle);
        }

        public void StartAnimation()
        {
            timerAnimate.Start();
        }

        public void StopAnimation()
        {
            timerAnimate.Stop();
        }
    }
}
