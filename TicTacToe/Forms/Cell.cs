using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace TicTacToe.Forms
{
    /// <summary>
    /// Represents a tic-tac-toe cell.
    /// </summary>
    public class Cell : Control
    {
        // Created for more robust drawing
        private Color currentBackColor;
        /// <summary>
        /// Gets or sets the current background color.
        /// </summary>
        private Color CurrentBackColor
        {
            get { return currentBackColor; }
            set
            {
                if (value != currentBackColor)
                {
                    currentBackColor = value;
                    Invalidate();
                }
            }
        }

        private Team cellState = Team.Undetermined;
        /// <summary>
        /// Gets what <see cref="Team"/> has played on this cell.
        /// </summary>
        [Description("Determined what Team has played on this cell.")]
        public Team CellState
        {
            get { return cellState; }
            set
            {
                if (value != cellState)
                {
                    cellState = value;
                    Invalidate();

                    if (value != Team.Undetermined)
                        PlayerMoved(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Occurs when a player has made a move.
        /// </summary>
        [Description("Occurs when a player has made a move.")]
        public event EventHandler PlayerMoved = delegate { };

        /// <summary>
        /// Initializes a new instance of the <see cref="Cell"/> class.
        /// </summary>
        public Cell()
        {
            base.DoubleBuffered = true;
            ResizeRedraw = true;
            base.Cursor = Cursors.Hand;
        }

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Control.BackColorChanged"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data. </param>
        protected override void OnBackColorChanged(EventArgs e)
        {
            base.OnBackColorChanged(e);
            CurrentBackColor = BackColor;
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (CellState == Team.Undetermined)
                CurrentBackColor = Color.FromArgb(60, 60, 60);
        }

        protected override void OnMouseLeave(EventArgs e) => CurrentBackColor = Color.DimGray;

        protected override void OnMouseClick(MouseEventArgs e)
        {
            if (cellState == Team.Undetermined)
            {
                CellState = Team.O;
                CurrentBackColor = Color.DimGray;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.Clear(CurrentBackColor);
            // The stroke of X and O's will be 15% of the cells width
            float penWidth = Width*0.15f;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            const float PAD = 0.2f;
            const float OPP_PAD = 1 - PAD;

            if (cellState == Team.O)
            {
                // Manuelly draw an 'O'
                var pen = new Pen(Color.LightBlue, penWidth);
                RectangleF rect = ClientRectangle;
                rect.Inflate(Width *- OPP_PAD, Height *- OPP_PAD);
                e.Graphics.DrawEllipse(pen, rect);
            }
            else if (cellState == Team.X)
            {
                var pen = new Pen(Color.LightCoral, penWidth);
                // Manuelly draw an 'X'
                var line1Start = new PointF(Width * PAD, Height * PAD);     // Top-Left
                var line1End = new PointF(Width * OPP_PAD, Height * OPP_PAD); // Bottom-Right
                e.Graphics.DrawLine(pen, line1Start, line1End);

                var line2Start = new PointF(Width * PAD, Height * OPP_PAD);  // Bottom-Left
                var line2End = new PointF(Width * OPP_PAD, Height * PAD);    // Top-Right
                e.Graphics.DrawLine(pen, line2Start, line2End);
            }
        }
    }
}
