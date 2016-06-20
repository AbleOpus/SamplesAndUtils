using System;
using System.Drawing;
using System.Windows.Forms;

namespace Eventing
{
    public partial class MainForm : Form
    {
        // The total pixels the special control has moved left
        private int moveLeftAmount;

        public MainForm()
        {
            InitializeComponent();
        }

        private void specialControl_MoveLeft(object sender, MovedLeftEventArgs e)
        {
            // Add amount moved to total before displaying
            moveLeftAmount += e.MoveAmount;
            Text = moveLeftAmount.ToString();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            // Move special control left by 3 pixels.
            specialControl.Location = new Point
                (specialControl.Location.X - 3, specialControl.Location.Y);
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            // Move special control right by 3 pixels.
            specialControl.Location = new Point
                (specialControl.Location.X + 3, specialControl.Location.Y);
        }
    }
}
