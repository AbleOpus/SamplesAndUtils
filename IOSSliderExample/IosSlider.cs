using IOSSliderExample.Properties;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace IOSSliderExample
{
    class IosSlider : Slider
    {
        private readonly SolidBrush _barPlainBrush = new SolidBrush(Color.FromArgb(36, 37, 42));
        private readonly Color _upperBevelColor = Color.FromArgb(16, 17, 21);
        private readonly Color _lowerBevelColor = Color.FromArgb(101, 102, 107);
        private readonly SolidBrush _progressBrush = new SolidBrush(Color.FromArgb(137, 138, 142));
        private const int _CORNER_RADIUS = 3;

        public IosSlider()
        {
            KnobImage = Resources.MetalKnob;
        }

        protected override void DrawBar(Graphics graphics)
        {
            if (this.Width - KnobImage.Width > 1)
            {
                int barHeight = this.Height/3;
                int x = KnobImage.Width/2;
                int y = this.Height/2 - barHeight/2;

                // Draw bevel
                Rectangle rect = new Rectangle(x, y, this.Width - KnobImage.Width, barHeight);
                var path = RoundedRectangle.Create(rect, _CORNER_RADIUS);
                var brush = new LinearGradientBrush(rect, _upperBevelColor, _lowerBevelColor, 90f);
                graphics.FillPath(brush, path);

                // Draw full bar
                rect.Inflate(0, -1);
                path = RoundedRectangle.Create(rect, _CORNER_RADIUS);
                graphics.FillPath(_barPlainBrush, path);

                // Draw partial color
                path = RoundedRectangle.Create(rect.X, rect.Y, KnobX + KnobImage.Width/2, rect.Height, _CORNER_RADIUS);
                graphics.FillPath(_progressBrush, path);
            }
        }

        private abstract class RoundedRectangle
        {
            public enum RectangleCorners
            {
                None = 0, TopLeft = 1, TopRight = 2, BottomLeft = 4, BottomRight = 8,
                All = TopLeft | TopRight | BottomLeft | BottomRight
            }

            public static GraphicsPath Create(int x, int y, int width, int height,
                                              int radius, RectangleCorners corners)
            {
                int xw = x + width;
                int yh = y + height;
                int xwr = xw - radius;
                int yhr = yh - radius;
                int xr = x + radius;
                int yr = y + radius;
                int r2 = radius * 2;
                int xwr2 = xw - r2;
                int yhr2 = yh - r2;

                GraphicsPath p = new GraphicsPath();
                p.StartFigure();

                //Top Left Corner
                if ((RectangleCorners.TopLeft & corners) == RectangleCorners.TopLeft)
                {
                    p.AddArc(x, y, r2, r2, 180, 90);
                }
                else
                {
                    p.AddLine(x, yr, x, y);
                    p.AddLine(x, y, xr, y);
                }

                //Top Edge
                p.AddLine(xr, y, xwr, y);

                //Top Right Corner
                if ((RectangleCorners.TopRight & corners) == RectangleCorners.TopRight)
                {
                    p.AddArc(xwr2, y, r2, r2, 270, 90);
                }
                else
                {
                    p.AddLine(xwr, y, xw, y);
                    p.AddLine(xw, y, xw, yr);
                }

                //Right Edge
                p.AddLine(xw, yr, xw, yhr);

                //Bottom Right Corner
                if ((RectangleCorners.BottomRight & corners) == RectangleCorners.BottomRight)
                {
                    p.AddArc(xwr2, yhr2, r2, r2, 0, 90);
                }
                else
                {
                    p.AddLine(xw, yhr, xw, yh);
                    p.AddLine(xw, yh, xwr, yh);
                }

                //Bottom Edge
                p.AddLine(xwr, yh, xr, yh);

                //Bottom Left Corner
                if ((RectangleCorners.BottomLeft & corners) == RectangleCorners.BottomLeft)
                {
                    p.AddArc(x, yhr2, r2, r2, 90, 90);
                }
                else
                {
                    p.AddLine(xr, yh, x, yh);
                    p.AddLine(x, yh, x, yhr);
                }

                //Left Edge
                p.AddLine(x, yhr, x, yr);

                p.CloseFigure();
                return p;
            }

            public static GraphicsPath Create(Rectangle rect, int radius, RectangleCorners c)
            { return Create(rect.X, rect.Y, rect.Width, rect.Height, radius, c); }

            public static GraphicsPath Create(int x, int y, int width, int height, int radius)
            { return Create(x, y, width, height, radius, RectangleCorners.All); }

            public static GraphicsPath Create(Rectangle rect, int radius)
            { return Create(rect.X, rect.Y, rect.Width, rect.Height, radius); }

            public static GraphicsPath Create(int x, int y, int width, int height)
            { return Create(x, y, width, height, 5); }

            public static GraphicsPath Create(Rectangle rect)
            { return Create(rect.X, rect.Y, rect.Width, rect.Height); }
        }
    }
}
