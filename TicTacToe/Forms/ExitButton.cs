using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToe.Forms
{
    /// <summary>
    /// Represents a <see cref="Button"/> to exit the application.
    /// </summary>
    class ExitButton : Control
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExitButton"/> class.
        /// </summary>
        public ExitButton()
        {
            Size = new Size(25, 25);
            base.BackColor = Color.LightPink;
            base.ForeColor = Color.FromArgb(40, 40, 40);
            base.DoubleBuffered = true;
        }

        // Set defaults

        [DefaultValue(typeof(Color), "LightPink")]
        public override Color BackColor
        {
            get { return base.BackColor; }
            set { base.BackColor = value; }
        }

        [DefaultValue(typeof(Color), "40, 40, 460")]
        public override Color ForeColor
        {
            get { return base.ForeColor; }
            set { base.ForeColor = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var forePen = new Pen(ForeColor, 4f);
            forePen.Width = Width*.15f;
            e.Graphics.Clear(BackColor);
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            forePen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawRectangle(forePen, ClientRectangle);

            const float X_PAD = 0.2f;
            const float xInversePad = 1 - X_PAD;
            var line1Start = new PointF(Width * X_PAD, Height * X_PAD);           // Top-Left
            var line1End = new PointF(Width * xInversePad, Height * xInversePad); // Bottom-Right
            var line2Start = new PointF(Width * X_PAD, Height * xInversePad);     // Bottom-Left
            var line2End = new PointF(Width * xInversePad, Height * X_PAD);       // Top-Right
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            e.Graphics.DrawLine(forePen, line1Start, line1End);
            e.Graphics.DrawLine(forePen, line2Start, line2End);
        }

        protected override void OnMouseEnter(EventArgs e) => BackColor = Color.LightPink;

        protected override void OnMouseLeave(EventArgs e) => BackColor = Color.LightCoral;

        protected override void OnMouseClick(MouseEventArgs e) => Application.Exit();
    }
}
