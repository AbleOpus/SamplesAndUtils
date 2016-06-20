using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AboCodeLibrary
{
    /// <summary>
    /// Specifies how two perpendicular lines intersect each other.
    /// </summary>
    public enum LineIntersectType
    {
        /// <summary>
        /// The horizontal line will be on top.
        /// </summary>
        HorizOnTop,
        /// <summary>
        /// The vertical line will be on top.
        /// </summary>
        VertOnTop,
        /// <summary>
        /// The intersect points of the lines will be the color of the control.
        /// </summary>
        Subtract
    }


    /// <summary>
    /// Represents a class that draws a mouse tracker on a certain control.
    /// </summary>
    public class MouseTracker : IDisposable
    {
        private readonly Control control;

        /// <summary>
        /// Gets or sets the Pen to use for the vertical line.
        /// </summary>
        public Pen VerticalPen { get; set; } = new Pen(Color.CornflowerBlue, 3);

        /// <summary>
        /// Gets or sets the Pen to use for the horizontal line.
        /// </summary>
        public Pen HorizontalPen { get; set; } = new Pen(Color.Blue, 3);

        /// <summary>
        /// Gets or sets whether to automatically hide the tracker when the mouse
        /// leaves the bounds of the control.
        /// </summary>
        public bool AutoHide { get; set; } = true;

        /// <summary>
        /// Gets or sets whether to show the vertical line.
        /// </summary>
        public bool VerticalLineVisible { get; set; } = true;

        /// <summary>
        /// Gets or sets whether to show the horizontal line.
        /// </summary>
        public bool HorizontalLineVisible { get; set; } = true;

        /// <summary>
        /// Gets or sets how the lines intersect with each other.
        /// </summary>
        public LineIntersectType IntersectType { get; set; } = LineIntersectType.Subtract;

        /// <summary>
        /// Initializes a new instance of the <see cref="MouseTracker"/> class
        /// with the specified argument.
        /// </summary>
        /// <param name="control">The control to draw on.</param>
        public MouseTracker(Control control)
        {
            this.control = control;
            control.MouseMove += InvalidateHandler;
            control.MouseEnter += InvalidateHandler;
            control.MouseLeave += InvalidateHandler;
            control.SizeChanged += InvalidateHandler;
            control.Paint += ControlOnPaint;
        }

        private void ControlOnPaint(object sender, PaintEventArgs e)
        {
            Point curPos = control.PointToClient(Cursor.Position);

            if (control.ClientRectangle.Contains(curPos))
            {
                if (!HorizontalLineVisible && !VerticalLineVisible) return;
                e.Graphics.Clear(control.BackColor);

                if (HorizontalLineVisible && HorizontalPen != null)
                    e.Graphics.DrawLine(HorizontalPen, 0, curPos.Y, control.Width, curPos.Y);

                if (VerticalLineVisible && VerticalPen != null)
                    e.Graphics.DrawLine(VerticalPen, curPos.X, 0, curPos.X, control.Height);

                switch (IntersectType)
                {
                    case LineIntersectType.Subtract:
                        {
                            float xPos = curPos.X - VerticalPen.Width / 2f;
                            float yPos = curPos.Y - VerticalPen.Width / 2f;

                            using (var brush = new SolidBrush(control.BackColor))
                                e.Graphics.FillRectangle(brush, xPos, yPos, VerticalPen.Width, VerticalPen.Width);
                        }
                        break;

                    case LineIntersectType.HorizOnTop:
                        {
                            float xPos = curPos.X - VerticalPen.Width / 2f;
                            float yPos = curPos.Y - VerticalPen.Width / 2f;

                            e.Graphics.FillRectangle(HorizontalPen.Brush, xPos,
                                yPos, HorizontalPen.Width, HorizontalPen.Width);
                        }
                        break;
                }
            }
        }

        private void InvalidateHandler(object sender, EventArgs e)
        {
            control.Invalidate(true);
        }

        public void Dispose()
        {
            VerticalPen?.Dispose();
            HorizontalPen?.Dispose();
        }
    }
}
