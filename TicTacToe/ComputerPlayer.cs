using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using TicTacToe.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Represents a player controlled by the computer.
    /// </summary>
    public class ComputerPlayer
    {
        private readonly Grid grid;
        private readonly Timer timer = new Timer();

        /// <summary>
        /// Gets or sets the time it takes to make a move (in MS).
        /// </summary>
        public int IdleTime { get; set; } = 20;

        /// <summary>
        /// Gets or sets whether the computer player is on the X team.
        /// </summary>
        public bool IsXTeam { get; set; } = true;

        /// <summary>
        /// Gets the team opposite of the computers team.
        /// </summary>
        public Team OpposingTeam => IsXTeam ? Team.O : Team.X;

        /// <summary>
        /// Gets the computer team.
        /// </summary>
        private Team Team => IsXTeam ? Team.X : Team.O;

        /// <summary>
        /// Gets or sets whether or not to make a move close to the opposing move if
        /// the opposing move is the first play.
        /// </summary>
        public bool MakeInitialMoveAdjacent { get; set; }

        /// <summary>
        /// Gets or sets how the opponent behaves.
        /// </summary>
        public OpponentMoveMode Mode { get; set; }

        /// <summary>
        /// Occurs when the computer has made a move.
        /// </summary>
        public event EventHandler MoveMade = delegate { };

        /// <summary>
        /// Initializes a new instance of the <see cref="ComputerPlayer"/> class
        /// with the specified grid.
        /// </summary>
        /// <param name="grid">The grid that the computer will be playing on.</param>
        public ComputerPlayer(Grid grid)
        {
            timer.Interval = IdleTime;
            timer.Tick += timer_Tick;
            this.grid = grid;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();

            if (Mode == OpponentMoveMode.Random)
            {
                MakeNextMoveAtRandom();
            }
            else if (Mode == OpponentMoveMode.Logical)
            {
                if (grid.GetCountOf(OpposingTeam) == 1)
                {
                    MakeAdjacentMove();
                }
                else
                {
                    MakeNextMoveLogical();
                }
            }

            MoveMade(this, EventArgs.Empty);
        }

        /// <summary>
        /// Begins the next move.
        /// </summary>
        public void MakeNextMove()
        {
            timer.Start();
        }

        private void MakeAdjacentMove()
        {
            var adjacentPoints = new List<Point>();
            Point oppositionPoint = GetFirstPlayPoint();

            if (oppositionPoint == new Point(-1, -1))
            {
                Debug.WriteLine("First play point yielded -1, -1");
                MakeNextMoveAtRandom();
                return;
            }

            for (int i = 0; i < grid.Dimension; i++)
            {
                for (int i2 = 0; i2 < grid.Dimension; i2++)
                {
                    bool isNearRow = (Math.Abs(oppositionPoint.X - i) <= 1);
                    bool isNearColumn = (Math.Abs(oppositionPoint.Y - i2) <= 1);

                    if (grid.Cells[i, i2].CellState == Team.Undetermined && isNearColumn && isNearRow)
                    {
                        // First move cell found, play around this
                        adjacentPoints.Add(new Point(i, i2));
                    }
                }
            }

            if (adjacentPoints.Count > 0)
            {
                var random = new Random();
                int randomNum = random.Next(0, adjacentPoints.Count);
                int x = adjacentPoints[randomNum].X;
                int y = adjacentPoints[randomNum].Y;
                grid.Cells[x, y].CellState = Team;
                Debug.WriteLine("Adjacent move made");
            }
            else
            {
                MakeNextMoveAtRandom();
            }
        }

        /// <summary>
        /// Gets the position of the first move.
        /// </summary>
        /// <returns>returns X:-1, Y:-1 if no opposing move found.</returns>
        private Point GetFirstPlayPoint()
        {
            for (int i = 0; i < grid.Dimension; i++)
                for (int i2 = 0; i2 < grid.Dimension; i2++)
                    if (grid.Cells[i, i2].CellState == OpposingTeam)
                        return new Point(i, i2);

            return new Point(-1, -1);
        }

        /// <summary>
        /// Find blank cells and make a random move by setting the cell state to one of 
        /// the cells with a random index.
        /// </summary>
        private void MakeNextMoveAtRandom()
        {
            var blankCellList = new List<Cell>();

            foreach (Cell cell in grid.Cells)
            {
                if (cell.CellState == Team.Undetermined)
                    blankCellList.Add(cell);
            }

            var random = new Random();
            int num = random.Next(0, blankCellList.Count);

            if (blankCellList.Count > 0)
            {
                blankCellList[num].CellState = Team;
            }
        }

        /// <summary>
        /// Use logic to make next move, if no logical move, then use random move.
        /// </summary>
        private void MakeNextMoveLogical()
        {
            Cell noneCell = null;
            bool hasWinningMove = false;

            #region Vertical Analysis
            // Look for a viable vertical move, that is a top to bottom move
            for (int i = 0; i < grid.Dimension; i++)
            {
                int noneCount = 0, xCount = 0, oCount = 0;
                Cell tempCell = null;

                for (int i2 = 0; i2 < grid.Dimension; i2++)
                {
                    switch (grid.Cells[i, i2].CellState)
                    {
                        case Team.Undetermined:
                            noneCount++;
                            tempCell = grid.Cells[i, i2];
                            break;

                        case Team.X: xCount++; break;
                        case Team.O: oCount++; break;
                    }

                    if (noneCount != 1) continue;

                    if (xCount == 2)
                    {
                        noneCell = tempCell;
                        hasWinningMove = true;
                    }
                    else if (oCount == 2 && !hasWinningMove)
                    {
                        noneCell = tempCell;
                    }
                }
            }
            #endregion

            #region Horizontal Analysis
            // Look for horizontal win
            for (int i2 = 0; i2 < grid.Dimension; i2++)
            {
                int noneCount = 0, xCount = 0, oCount = 0;
                Cell tempCell = null;

                for (int i = 0; i < grid.Dimension; i++)
                {
                    switch (grid.Cells[i, i2].CellState)
                    {
                        case Team.Undetermined:
                            noneCount++;
                            tempCell = grid.Cells[i, i2];
                            break;

                        case Team.X: xCount++; break;
                        case Team.O: oCount++; break;
                    }

                    if (noneCount == 1)
                    {
                        if (xCount == 2)
                        {
                            noneCell = tempCell;
                            hasWinningMove = true;
                        }
                        else if (oCount == 2 && !hasWinningMove)
                        {
                            noneCell = tempCell;
                        }
                    }
                }
            }
            #endregion

            #region Horiozontal Analysis
            // Check possible opportunity, top left to bottom right
            {
                int noneCount = 0, xCount = 0, oCount = 0;
                Cell tempCell = null;

                for (int i = 0; i < grid.Dimension; i++)
                {
                    switch (grid.Cells[i, i].CellState)
                    {
                        case Team.Undetermined:
                            noneCount++;
                            tempCell = grid.Cells[i, i];
                            break;

                        case Team.X: xCount++; break;
                        case Team.O: oCount++; break;
                    }
                }

                if (noneCount == 1)
                {
                    if (xCount == 2)
                    {
                        noneCell = tempCell;
                        hasWinningMove = true;
                    }
                    else if (oCount == 2 && !hasWinningMove)
                    {
                        noneCell = tempCell;
                    }
                }
            }

            // Check possible opportunity, bottom left to top right
            {
                int noneCount = 0, xCount = 0, oCount = 0;
                Cell tempCell = null;

                int secIndex = grid.Dimension - 1; // Secondary index

                for (int i = 0; i < grid.Dimension; i++)
                {
                    switch (grid.Cells[i, secIndex].CellState)
                    {
                        case Team.Undetermined:
                            noneCount++;
                            tempCell = grid.Cells[i, secIndex];
                            break;

                        case Team.X: xCount++; break;
                        case Team.O: oCount++; break;
                    }

                    secIndex--;
                }

                if (noneCount == 1)
                {
                    if (xCount == 2)
                    {
                        noneCell = tempCell;
                        hasWinningMove = true;
                    }
                    else if (oCount == 2 && !hasWinningMove)
                    {
                        noneCell = tempCell;
                    }
                }
            }
            #endregion

            if (noneCell == null)
            {
                MakeNextMoveAtRandom();
            }
            else
            {
                noneCell.CellState = Team;
            }
        }
    }
}
