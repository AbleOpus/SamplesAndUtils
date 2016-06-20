using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;
using AboStopWatch.Properties;
using System.IO;

namespace AboStopWatch
{
    public partial class MainForm : Form
    {
        private readonly Stopwatch stopWatch = new Stopwatch();
        private Point lastPos;

        public MainForm()
        {
            InitializeComponent();
            LoadDefaults();
            UpdateTime();
        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Space)
            {
                buttonStart.PerformClick();
                return true;
            }

            return base.ProcessDialogKey(keyData);
        }


        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, 
                Color.FromArgb(0, 122, 204), ButtonBorderStyle.Solid);
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            Settings.Default.TopMost = menuItemAlwaysOnTop.Checked;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            if (e.Button == MouseButtons.Left)
            {
                Top += e.Y - lastPos.Y;
                Left += e.X - lastPos.X;
            }
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);

            if (e.Button == MouseButtons.Left)
            {
                Cursor = Cursors.Default;
            }
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                lastPos = e.Location;
                Cursor = Cursors.SizeAll;
            }
        }

        private void LoadDefaults()
        {
            TopMost = menuItemAlwaysOnTop.Checked = Settings.Default.TopMost;

            switch (Settings.Default.FormatIndex)
            {
                case 0: menuItemMinutes.Checked = true; break;
                case 1: menuItemMS.Checked = true; break;
                case 2: menuItemClock.Checked = true; break;
                case 3: menuItemSeconds.Checked = true; break;
            }
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private static string SpanToClockString(TimeSpan timeSpan)
        {
            return $"{timeSpan.Minutes:00}:{timeSpan.Seconds:00}:{timeSpan.Milliseconds/10:00}";
        }

        /// <summary>
        /// Appends a line of time, prefixed by the date, to the log file.
        /// </summary>
        private void LogData()
        {
            try
            {
                TimeSpan TS = stopWatch.Elapsed;
                string time = Text = SpanToClockString(TS);
                File.AppendAllText("Time.log", $"[{DateTime.Now.ToShortDateString()}] {time} \r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTime()
        {
            switch (Settings.Default.FormatIndex)
            {
                case 0: // Minutes
                    textBoxTime.Text = Text = "Minutes: " + stopWatch.Elapsed.Minutes;
                    break;

                case 1: // Milliseconds
                    string time = stopWatch.ElapsedMilliseconds.ToString();
                    textBoxTime.Text = "Milliseconds: " + time;
                    Text = "MS: " + time;
                    break;

                case 2: // Clock
                    textBoxTime.Text = Text = SpanToClockString(stopWatch.Elapsed);
                    break;

                case 3: // Seconds
                    textBoxTime.Text = Text = "Seconds: " + stopWatch.Elapsed.Seconds;
                    break;
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning)
            {
                buttonStop.Enabled = true;
                buttonStart.DefaultImage = Resources.Pause;
                stopWatch.Start();
                timerUpdate.Start();
                buttonStop.Focus();
            }
            else
            {
                buttonStart.DefaultImage = Resources.Play;
                stopWatch.Stop();
                timerUpdate.Stop();
                UpdateTime();
            }
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            buttonStop.Enabled = false;
            stopWatch.Stop();
            LogData();
            stopWatch.Reset();
            timerUpdate.Stop();
            UpdateTime();
            buttonStart.DefaultImage = Resources.Play;
            buttonStart.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuItemAlwaysOnTop_Click(object sender, EventArgs e)
        {
            TopMost = Settings.Default.TopMost = menuItemAlwaysOnTop.Checked;
        }

        private void menuItemClock_Click(object sender, EventArgs e)
        {
            menuItemClock.Checked = true;
            menuItemSeconds.Checked = false;
            menuItemMS.Checked = false;
            menuItemMinutes.Checked = false;
            Settings.Default.FormatIndex = 2;
            UpdateTime();
        }

        private void menuItemMinutes_Click(object sender, EventArgs e)
        {
            menuItemSeconds.Checked = false;
            menuItemMS.Checked = false;
            menuItemClock.Checked = false;
            menuItemMinutes.Checked = true;
            Settings.Default.FormatIndex = 0;
            UpdateTime();
        }

        private void menuItemMS_Click(object sender, EventArgs e)
        {
            menuItemClock.Checked = false;
            menuItemSeconds.Checked = false;
            menuItemMS.Checked = true;
            menuItemMinutes.Checked = false;
            Settings.Default.FormatIndex = 1;
            UpdateTime();
        }

        private void menuItemSeconds_Click(object sender, EventArgs e)
        {
            menuItemClock.Checked = false;
            menuItemSeconds.Checked = true;
            menuItemMS.Checked = false;
            menuItemMinutes.Checked = false;
            Settings.Default.FormatIndex = 3;
            UpdateTime();
        }
    }
}
