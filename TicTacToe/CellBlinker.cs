using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;
using TicTacToe.Forms;

namespace TicTacToe
{
    /// <summary>
    /// Provides a blinking effect of <see cref="Cell"/>s.
    /// </summary>
    static class CellBlinker
    {
        private static Color restoreColor;
        private static Color blinkColor = Color.Yellow;
        private static Cell[] setToBlink;
        private static int time;
        private static readonly Timer timerBlink = new Timer();

        /// <summary>
        /// Gets or sets whether the grid is currently blinking.
        /// </summary>
        public static bool IsBlinking { get; set; }

        /// <summary>
        /// Occurs when the blinking sequence has ended.
        /// </summary>
        public static event EventHandler BlinkingEnded = delegate {};

        static CellBlinker()
        {
            timerBlink.Interval = 500;
            timerBlink.Tick += timerBlink_Tick;
        }

        /// <summary>
        /// Blinks the specified cells with the specified color.
        /// </summary>
        /// <param name="blinkColor">The color to simulate a blink.</param>
        /// <param name="cellsToBlink">The cells to apply the blink effect.</param>
        public static void BlinkCells(Color blinkColor, Cell[] cellsToBlink)
        {
            IsBlinking = true;
            restoreColor = cellsToBlink[0].BackColor;
            CellBlinker.blinkColor = blinkColor;
            setToBlink = cellsToBlink;
            time = 0;
            timerBlink.Start();
        }

        /// <summary>
        /// Gets whether a number is odd.
        /// </summary>
        /// <param name="number">The number to evaluate.</param>
        /// <returns>True, if a number is odd, otherwise false.</returns>
        private static bool IsNumberOdd(int number)
        {
            return (number & 1).Equals(0);
        }

        private static void timerBlink_Tick(object sender, EventArgs e)
        {
            if (time == 3)
            {
                timerBlink.Stop();
                ChangeBackColorOfCells(restoreColor);
                IsBlinking = false;
                BlinkingEnded(null, EventArgs.Empty);
            }
            else
            {
                Color color = IsNumberOdd(time) ? blinkColor : restoreColor;
                ChangeBackColorOfCells(color);
                time++;
            }
        }

        /// <summary>
        /// Changes the background color of the current set range of cells.
        /// </summary>
        /// <param name="color">The background color to use.</param>
        private static void ChangeBackColorOfCells(Color color)
        {
            foreach (Cell cell in setToBlink)
                cell.BackColor = color;
        }
    }
}
