using System;
using System.Drawing;
using System.Windows.Forms;

namespace ABitOfMemory
{
    public partial class MainForm : Form
    {
        private readonly Session session;
        private Point lastClick;

        public MainForm()
        {
            InitializeComponent();
            session = new Session(buttonOne, buttonZero);
            session.SessionCompleted +=session_SequenceCompleted;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Black, 0, 0, Width - 1, Height - 1);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            lastClick = e.Location;
            Cursor = Cursors.SizeAll;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseLeave(e);
            Cursor = Cursors.Default;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                Left += e.X - lastClick.X;
                Top += e.Y - lastClick.Y;
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            switch (e.KeyCode)
            {
                case Keys.D0:
                    session.InputSequence(false);
                    buttonZero.BackColor = Color.White;
                    break;

                case Keys.D1:
                    session.InputSequence(true);
                    buttonOne.BackColor = Color.White;
                    break;
            }
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            buttonOne.BackColor = buttonZero.BackColor = Color.Silver;
        }

        private void session_SequenceCompleted(object sender, string score)
        {
            labelTitle.Text = score.Length + " Bits Of Memory";
        }

        private void buttonNewGame_Click(object sender, EventArgs e)
        {
            labelTitle.Text = Application.ProductName;
            buttonZero.Visible = buttonOne.Visible = true;
            session.New();
        }

        private void labelTitle_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, labelTitle.Bounds, Color.Black, ButtonBorderStyle.Solid);
        }
    }
}
