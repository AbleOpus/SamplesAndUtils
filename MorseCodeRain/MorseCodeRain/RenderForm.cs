using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Globalization;
using System.Windows.Forms;

namespace MorseCodeRain
{
    public partial class RenderForm : Form
    {
        /// <summary>
        /// Gets or sets the caption to display. The caption is for debugging purposes.
        /// </summary>
        public static string DebugCaption { get; set; }

        private readonly Stopwatch stopwatch = new Stopwatch();
        private int frames;

        /// <summary>
        /// Gets how many seconds have elapsed since application start.
        /// </summary>
        [Browsable(false)]
        public long SecondsElapsed { get; private set; }

        /// <summary>
        /// Gets or sets whether to show debug information.
        /// </summary>
        public virtual bool ShowDebugInfo { get; set; }

        /// <summary>
        /// Gets the frame rate, in frames per second.
        /// </summary>
        [Browsable(false)]
        public int FrameRate { get; private set; } = 30;

        /// <summary>
        /// Gets or sets whether this window is full-screen.
        /// </summary>
        public bool FullScreen
        {
            get { return FormBorderStyle == FormBorderStyle.None; }
            set
            {
                if (value)
                {
                    FormBorderStyle = FormBorderStyle.None;
                    WindowState = FormWindowState.Maximized;
                }
                else
                {
                    FormBorderStyle = FormBorderStyle.Sizable;
                    WindowState = FormWindowState.Normal;
                    TopMost = false;
                }
            }
        }

        protected RenderForm()
        {
            InitializeComponent();
            stopwatch.Start();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
#if DEBUG
            TopMost = false;
#endif
        }

        /// <summary>
        /// Raises when a second has elapsed.
        /// </summary>
        protected virtual void OnSecondElapsed()
        {
        }

        /// <summary>
        /// Implements rendering logic for the game.
        /// </summary>
        /// <param name="graphics">The surface to draw to.</param>
        protected virtual void Render(Graphics graphics)
        {
        }

        /// <param name="e">A <see cref="T:System.Windows.Forms.PaintEventArgs"/> that contains the event data. </param>
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAlias;

            Render(e.Graphics);

            if (ShowDebugInfo && DebugCaption != null)
            {
                e.Graphics.DrawString(DebugCaption, Font, Brushes.Lime, 10, 10);
            }

            frames++;

            if (stopwatch.ElapsedTicks >= Stopwatch.Frequency)
            {
                SecondsElapsed++;
                FrameRate = frames;
                frames = 0;
                stopwatch.Restart();
                OnSecondElapsed();
            }
        }

        private void timerInvalidate_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
