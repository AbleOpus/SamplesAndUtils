using System;
using System.Collections.Generic;
using System.Drawing;
using System.Diagnostics;
using TicTacToe.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Represents the play grid.
    /// </summary>
    public class Grid
    {
        #region Properties

        /// <summary>
        /// Gets the <see cref="Cell"/>s for this grid.
        /// </summary>
        public Cell[,] Cells { get; }

        /// <summary>
        /// Gets or sets whether all of the <see cref="Cell"/>s are enabled.
        /// </summary>
        public bool CellsEnabled
        {
            get { return Cells[0, 0].Enabled; }
            set
            {
                foreach (Cell cell in Cells)
                {
                    cell.Enabled = value;
                }
            }
        }

        /// <summary>
        /// Gets or sets the color of the grid <see cref="Cell"/>s.
        /// </summary>
        public Color CellColor
        {
            get { return Cells[0, 0].BackColor; }
            set
            {
                foreach (Cell cell in Cells)
                {
                    cell.BackColor = value;
                }
            }
        }

        private int dimension = 3;
        /// <summary>
        /// Gets or sets the amount of columns and rows in the grid, they are expected to be the same.
        /// </summary>
        public int Dimension
        {
            get { return dimension; }
            set
            {
                if (dimension < 3)
                {
                    throw new ArgumentException(
                        "The value of the Dimension property must be greater than or equal to 3.", 
                        nameof(value));
                }

                dimension = value;
            }
        }

        /// <summary>
        /// Gets the amount of moves that has been made.
        /// </summary>
        public int TotalMoves
        {
            get
            {
                int count = 0;

                foreach (Cell cell in Cells)
                {
                    if (cell.CellState != Team.Undetermined)
                        count++;
                }

                return count;
            }
        }

        /// <summary>
        /// Gets or sets the grid spacing.
        /// </summary>
        public int GridSpacing { get; set; }
        #endregion

        /// <summary>
        /// Initializes a new instance of the <see cref="Grid"/> class with
        /// the specified grid dimensions.
        /// </summary>
        /// <param name="dimension">The grid dimensions (width and height).</param>
        public Grid(int dimension)
        {
            this.dimension = dimension;
            Cells = new Cell[dimension, dimension];
            GridSpacing = 5;

            // Create cell matrix
            for (int i = 0; i < dimension; i++)
            {
                for (int i2 = 0; i2 < dimension; i2++)
                {
                    Cell cell = new Cell();
                    Cells[i, i2] = cell;
                }
            }
        }

        /// <summary>
        /// Sets the state of all cells to none.
        /// </summary>
        public void Reset()
        {
            foreach (Cell cell in Cells)
            {
                cell.CellState = Team.Undetermined;
            }
        }

        /// <summary>
        /// Checks for a winner. 
        /// </summary>
        /// <returns>True, if winner found, otherwise false.</returns>
        public bool CheckForWinner()
        {
            // Check for vertical win
            for (int i = 0; i < dimension; i++)
            {
                for (int i2 = 0; i2 < dimension; i2++)
                {
                    if (i2 - 1 >= 0 && i2 + 1 < dimension &&
                    Cells[i, i2 - 1].CellState == Cells[i, i2].CellState &&
                    Cells[i, i2].CellState == Cells[i, i2 + 1].CellState &&
                    Cells[i, i2].CellState != Team.Undetermined)
                    {
                        CellsEnabled = false;
                        Color blinkColor = (Cells[i, i2].CellState == Team.X) ? Color.Red : Color.Green;
                        Cell[] cellsToBlink = { Cells[i, i2 - 1], Cells[i, i2], Cells[i, i2 + 1] };
                        CellBlinker.BlinkCells(blinkColor, cellsToBlink);
                        Debug.WriteLine("Vertical win found!");
                        return true;
                    }
                }
            }

            // Check for horizontal win
            for (int i = 0; i < dimension; i++)
            {
                for (int i2 = 0; i2 < dimension; i2++)
                {
                    if (i2 - 1 >= 0 && i2 + 1 < dimension &&
                        Cells[i2 - 1, i].CellState == Cells[i2, i].CellState &&
                        Cells[i2, i].CellState == Cells[i2 + 1, i].CellState &&
                        Cells[i2, i].CellState != Team.Undetermined)
                    {
                        CellsEnabled = false;
                        Color blinkColor = (Cells[i2, i].CellState == Team.X) ? Color.Red : Color.Green;
                        Cell[] setToBlink = { Cells[i2 - 1, i], Cells[i2, i], Cells[i2 + 1, i] };
                        CellBlinker.BlinkCells(blinkColor, setToBlink);
                        Debug.WriteLine("Horizontal win found!");
                        return true;
                    }
                }
            }

            // Check for diagonal wins (Top-Left to Bottom-Right)
            for (int i = 0; i < dimension; i++)
            {
                if (i - 1 >= 0 && i + 1 < dimension &&
                    Cells[i - 1, i - 1].CellState == Cells[i, i].CellState &&
                    Cells[i, i].CellState == Cells[i + 1, i + 1].CellState &&
                        Cells[i, i].CellState != Team.Undetermined)
                {
                    CellsEnabled = false;
                    Color blinkColor = (Cells[i, i].CellState == Team.X) ? Color.Red : Color.Green;
                    Cell[] setToBlink = { Cells[i - 1, i - 1], Cells[i, i], Cells[i + 1, i + 1] };
                    CellBlinker.BlinkCells(blinkColor, setToBlink);
                    Debug.WriteLine("Diagonal win found! (Top-Left to Bottom-Right)");
                    return true;
                }
            }

            // Check for diagonal win (Bottom-left to Top-right)
            int decrement = dimension - 1;

            for (int i = 0; i < dimension; i++)
            {
                if (i - 1 >= 0 && i + 1 < dimension &&
                    Cells[i - 1, decrement + 1].CellState == Cells[i, decrement].CellState &&
                    Cells[i, decrement].CellState == Cells[i + 1, decrement - 1].CellState &&
                        Cells[i, decrement].CellState != Team.Undetermined)
                {
                    CellsEnabled = false;
                    Color blinkColor = (Cells[i, decrement].CellState == Team.X) ? Color.Red : Color.Green;
                    Cell[] setToBlink = { Cells[i - 1, decrement + 1], Cells[i, decrement], Cells[i + 1, decrement - 1] };
                    CellBlinker.BlinkCells(blinkColor, setToBlink);
                    Debug.WriteLine("Diagonal win found! bottom-left to top-right");
                    return true;
                }

                decrement--;
            }

            CheckForDraw(); // No winner found, check for draw
            return false;
        }

        /// <summary>
        /// Check to see if the current session is a tie. If it is, then
        /// blink the tied cell.
        /// </summary>
        private void CheckForDraw()
        {
            var cellStack = new Stack<Cell>();

            foreach (Cell cell in Cells)
            {
                if (cell.CellState == Team.Undetermined) return;
                cellStack.Push(cell);
            }

            CellBlinker.BlinkCells(Color.Purple, cellStack.ToArray());
        }

        /// <summary>
        /// Gets how many moves a team has made.
        /// </summary>
        public int GetCountOf(Team cellState)
        {
            int count = 0;

            foreach (Cell cell in Cells)
            {
                if (cell.CellState.Equals(cellState))
                    count++;
            }

            return count;
        }
    }
}