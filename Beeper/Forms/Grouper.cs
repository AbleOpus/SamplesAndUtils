using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Beeper.Forms
{
    class Grouper : ContainerControl
    {
        private BufferedGraphics bufGraphics;
        private RectangleF stringRect;
        private readonly Pen borderPen = new Pen(Color.FromArgb(70, 70, 70), 4f);

        private int captionIndent = 20;
        /// <summary>
        /// Gets or sets the indentation level of the caption.
        /// </summary>
        [Category("Appearance")]
        [Description("Determines the indentation level of the caption.")]
        public int CaptionIndent
        {
            get { return captionIndent; }
            set
            {
                captionIndent = value;
                UpdateStringRect();
                Invalidate();
            }
        }

        public Grouper()
        {
            SetDefaults();
            UpdateGraphics();
        }

        private void SetDefaults()
        {
            borderPen.DashStyle = DashStyle.Solid;
            Size = new Size(300, 300);
            BackColor = Color.DimGray;
            Font = new Font("Arial", 14f, FontStyle.Bold);
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                ControlStyles.ResizeRedraw | ControlStyles.OptimizedDoubleBuffer, true);
            Padding = new Padding(5);
        }

        private void UpdateStringRect()
        {
            // Update string rect
            if (bufGraphics != null)
            {
                SizeF size = bufGraphics.Graphics.MeasureString(Text, Font);
                Padding = new Padding(Padding.Left, (int)size.Height, Padding.Right, Padding.Left);
                PointF pos = new PointF(CaptionIndent, 0);
                stringRect = new RectangleF(pos, size);
            }
        }

        private void UpdateGraphics()
        {
            if (Width > 0 && Height > 0)
            {
                BufferedGraphicsContext context = BufferedGraphicsManager.Current;
                context.MaximumBuffer = new Size(Width + 1, Height + 1);
                bufGraphics = context.Allocate(CreateGraphics(), ClientRectangle);
                UpdateStringRect();
            }
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            UpdateGraphics();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (bufGraphics != null)
            {
                bufGraphics.Graphics.Clear(BackColor);
                // Draw border
                float x = borderPen.Width / 2f;
                float y = stringRect.Height / 2f;
                float width = Width - borderPen.Width;
                float height = Height - y - borderPen.Width / 2;
                bufGraphics.Graphics.DrawRectangle(borderPen, x, y, width, height);
                // Draw string rect
                bufGraphics.Graphics.FillRectangle(new SolidBrush(BackColor), stringRect);
                // Draw caption
                bufGraphics.Graphics.DrawString(Text, Font, new SolidBrush(ForeColor), stringRect);
                bufGraphics.Render(e.Graphics);
            }
        }

        protected override void OnFontChanged(EventArgs e)
        {
            base.OnFontChanged(e);
            UpdateStringRect();
            Invalidate();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            UpdateStringRect();
            Invalidate();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            bufGraphics?.Dispose();
            borderPen?.Dispose();
        }
    }
}
