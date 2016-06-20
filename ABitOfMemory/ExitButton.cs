using System;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;

namespace ABitOfMemory
{
    class ExitButton : Button
    {
        private readonly Pen exitLine;
        private const int X_PADDING = 7;

        public ExitButton()
        {
            exitLine = new Pen(Color.Black, 3f);
            FlatStyle = FlatStyle.Flat;
            base.BackColor = Color.FromArgb(173, 202, 113);
        }

        [Browsable(false)]
        public override string Text
        {
            get { return base.Text; }
            set { base.Text = string.Empty; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Point start = new Point(X_PADDING, X_PADDING);
            Point end = new Point(Width - X_PADDING, Height - X_PADDING);
            e.Graphics.DrawLine(exitLine, start, end);
            start = new Point(X_PADDING, Height - X_PADDING);
            end = new Point(Width - X_PADDING, X_PADDING);
            e.Graphics.DrawLine(exitLine, start, end);
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            Application.Exit();
        }
    }
}
