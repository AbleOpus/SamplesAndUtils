using System;
using System.Drawing;
using System.Windows.Forms;

namespace Beeper.Forms
{
    public partial class StyledForm : Form
    {
        private Point lastPos;

        private bool showMinimizeButton;
        /// <summary>
        /// Gets or sets whether to show the minimize button.
        /// </summary>
        public bool ShowMinimizeButton
        {
            get { return showMinimizeButton; }
            set
            {
                showMinimizeButton = value;
                minimizeButton.Visible = value;
            }
        }

        protected StyledForm()
        {
            InitializeComponent();
            PlaceButtons();
            minimizeButton.Visible = ShowMinimizeButton;
        }

        private void MakeControlsDraggable()
        {
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    control.MouseMove += StyledForm_MouseMove;
                    control.MouseUp += StyledForm_MouseUp;
                    control.MouseDown += StyledForm_MouseDown;
                }
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            MakeControlsDraggable();
        }

        private void PlaceButtons()
        {
            // We do this because anchoring will cause unpredictable results in this case
            // Close button
            int x = Width - exitButton.Width - 10;
            int y = 10;
            exitButton.Location = new Point(x, y);
            x = Width - exitButton.Width - minimizeButton.Width - 16;
            y = 10;
            minimizeButton.Location = new Point(x, y);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            PlaceButtons();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                Color.Black, ButtonBorderStyle.Solid);
        }

        private void StyledForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPos.X;
                Top += e.Y - lastPos.Y;
            }
        }

        private void StyledForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastPos = e.Location;

            if (e.Button == MouseButtons.Left)
                Cursor = Cursors.SizeAll;
        }

        private void StyledForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                Cursor = Cursors.Default;
        }

        private void buttonMinize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
