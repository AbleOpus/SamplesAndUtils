using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MorseChallenge.Properties;

namespace MorseChallenge.Forms
{
    public partial class MainForm : Form
    {
        private ChartForm formChart = new ChartForm();
        private readonly MorsePlayer morsePlayer = new MorsePlayer();
        private string answerWord, answerMorse;
        private const int COUNTDOWN = 2;
        private int wrong, right, ticks = COUNTDOWN;
        private bool closing;

        public MainForm()
        {
            InitializeComponent();
            morsePlayer.FinishedPlaying += delegate { UpdateUI(false); };
            morsePlayer.BeepToggled += morsePlayer_BeepToggled;

            BindNumberSettings(numberBoxdDotDuration, "Unit");
            BindNumberSettings(numberBoxFreq, "Freq");
            BindNumberSettings(numberBoxLetterGap, "LetterGap");
            SetAnswer();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            closing = true;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        /// <summary>
        /// Binds a settings value to the <see cref="NumericUpDown.Value"/> property of a <see cref="NumericUpDown"/>.
        /// </summary>
        private static void BindNumberSettings(NumericUpDown numberBox, string settingVal)
        {
            numberBox.DataBindings.Add("Value", Settings.Default, settingVal, true, 
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void morsePlayer_BeepToggled(object sender, bool e)
        {
            if (closing || IsDisposed || Disposing) return;

            Invoke(new MethodInvoker(() =>
            {
                picLight.Image = (e) ? Resources.LightIllum : Resources.Light;
            }));
        }

        private void UpdateUI(bool playing)
        {
            if (closing || IsDisposed || Disposing) return;

            Invoke(new MethodInvoker(() =>
            {
                buttonPlay.Enabled = !playing;
                lblAnswer.Enabled = buttonSubmit.Enabled = textBoxAnswer.Enabled = !playing;
                SetReportLabel(!playing ? "Idle" : "Playing Morse");
            }));
        }

        private void SetAnswer()
        {
            string[] words = Resources.Word_List.Split(' ');
            Random random = new Random();
            int num = random.Next(0, words.Length);
            answerWord = words[num];
            answerMorse = MorseTranslator.EnglishToMorse(answerWord, true);
        }

        private void SetReportLabel(string text) => labelReport.Text = $@"Report: {text}";

        private void UpdateScoreLabel() => labelScore.Text = $"Score: {right} Right, {wrong} Wrong";

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (answerWord.Equals(textBoxAnswer.Text.Trim(), StringComparison.InvariantCultureIgnoreCase))
            {
                right++;
                labelScore.BackColor = Color.YellowGreen;
            }
            else
            {
                wrong++;
                labelScore.BackColor = Color.LightCoral;
                SetReportLabel($@"Answer was ""{answerWord}"" ({answerMorse})");
            }

            UpdateScoreLabel();
            lblAnswer.Enabled = buttonSubmit.Enabled = textBoxAnswer.Enabled = false;
            SetAnswer();
            textBoxAnswer.Clear();
            textBoxScrapbook.Clear();
            buttonPlay.Focus();
        }

        private void buttonOpenChart_Click(object sender, EventArgs e)
        {
            if (formChart.IsDisposed) formChart = new ChartForm();

            if (formChart.Visible)
            {
                formChart.BringToFront();
            }
            else
            {
                formChart.Show();
            }
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            buttonPlay.Enabled = false;
            buttonPlay.Text = ticks.ToString();
            timerCountDown.Start();
        }

        private void textBoxScrapbook_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.F1:
                    int lastSel = textBoxScrapbook.SelectionStart;
                    textBoxScrapbook.Text = textBoxScrapbook.Text.Insert(lastSel, "•");
                    e.SuppressKeyPress = true;
                    textBoxScrapbook.SelectionStart = lastSel + 1;
                    break;

                case Keys.F2:
                    lastSel = textBoxScrapbook.SelectionStart;
                    textBoxScrapbook.Text = textBoxScrapbook.Text.Insert(lastSel, "-");
                    e.SuppressKeyPress = true;
                    textBoxScrapbook.SelectionStart = lastSel + 1;
                    break;
            }
        }

        private void numberBoxFreq_ValueChanged(object sender, EventArgs e)
        {
            morsePlayer.Frequency = (int)numberBoxFreq.Value;
        }

        private void numberBoxDotDuration_ValueChanged(object sender, EventArgs e)
        {
            morsePlayer.Unit = (int)numberBoxdDotDuration.Value;
        }

        private void pictureBoxLight_DoubleClick(object sender, EventArgs e)
        {
            picLight.Hide();
        }

        private void timerCountDown_Tick(object sender, EventArgs e)
        {
            ticks--;
            buttonPlay.Text = ticks.ToString();

            if (ticks == 0)
            {
                UpdateUI(true);
                morsePlayer.PlayAsync(answerMorse);
                timerCountDown.Stop();
                ticks = COUNTDOWN;
                buttonPlay.Text = "Play";
            }
        }

        private void numberBoxLetterGap_ValueChanged(object sender, EventArgs e) => 
            morsePlayer.LetterGap = (int)numberBoxLetterGap.Value;
    }
}
