using System;
using System.Drawing;
using System.Windows.Forms;

namespace TicTacToe.Forms
{
    public partial class MainForm : Form
    {
        private readonly Grid grid = new Grid(3); // 3x3 (9 cells)
        private readonly ComputerPlayer opponent;
        private Point lastPos;

        public MainForm()
        {
            InitializeComponent();
            opponent = new ComputerPlayer(grid);
            opponent.Mode = OpponentMoveMode.Logical;
            opponent.MoveMade += _opponent_MoveMade;
            SetupCells();
            SetCellBounds();
            grid.CellColor = Color.Gray;
            CellBlinker.BlinkingEnded += CellBlinker_BlinkingEnded;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPos.X;
                Top += e.Y - lastPos.Y;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lastPos = e.Location;
                Cursor = Cursors.SizeAll;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            Cursor = Cursors.Default;
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            grid.GridSpacing = Width / 30;
            SetCellBounds();
        }

        private void _opponent_MoveMade(object sender, EventArgs e)
        {
            if (!CellBlinker.IsBlinking)
            {
                grid.CellsEnabled = true;
            }
        }

        private void CellBlinker_BlinkingEnded(object sender, EventArgs e)
        {
            grid.Reset();
            grid.CellsEnabled = true;
        }

        private void SetupCells()
        {
            foreach (Cell cell in grid.Cells)
            {
                cell.PlayerMoved += cell_CellStateChanged;
                Controls.Add(cell);
            }
        }

        private void cell_CellStateChanged(object sender, EventArgs e)
        {
            // TODO casues bug

            // If no winner and last play made is human
            if (!grid.CheckForWinner() && ((Cell)sender).CellState == opponent.OpposingTeam)
            {
                grid.CellsEnabled = false;
                opponent.MakeNextMove();
            }
        }

        /// <summary>
        /// Sets the size and location of all cells, 
        /// taking the cell padding number into calculations.
        /// </summary>
        private void SetCellBounds()
        {
            for (int i = 0; i < grid.Dimension; i++)
            {
                for (int i2 = 0; i2 < grid.Dimension; i2++)
                {
                    if (grid.Cells[i, i2] == null) continue;
                    // Set cells size
                    int totalSpacing = grid.GridSpacing * (grid.Dimension - 1);
                    int width = (int)((Width - totalSpacing) / (float)grid.Dimension + 0.5f);
                    int height = (int)((Height - totalSpacing) / (float)grid.Dimension + 0.5f);
                    grid.Cells[i, i2].Size = new Size(width, height);
                    // Set cells location
                    float temp = grid.GridSpacing / (grid.Dimension - 1f);
                    int x = (int)(i * ((float)Width / grid.Dimension + temp) + 0.5f);
                    int y = (int)(i2 * ((float)Height / grid.Dimension + temp) + 0.5f);
                    grid.Cells[i, i2].Location = new Point(x, y);
                }
            }
        }
    }
}