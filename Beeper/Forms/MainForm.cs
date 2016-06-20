using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Beeper.Properties;

namespace Beeper.Forms
{
    public partial class MainForm : StyledForm
    {
        private readonly BeepPlayer beepPlayer = new BeepPlayer();
        private readonly Color titleColor = Color.FromArgb(0, 142, 213);
        private bool closing;
        private int note;

        public MainForm()
        {
            InitializeComponent();
            textBoxSequence.Text = Settings.Default.LastPlayed;
            sequenceMenuStrip.ForeColor = Color.FromArgb(0, 142, 213);
            numberBoxSpeed.Value = (decimal)Settings.Default.SpeedMutliplier;
            SetupBeepPlayer();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            closing = true;
            Settings.Default.LastPlayed = textBoxSequence.Text;
            Settings.Default.SpeedMutliplier = (float)numberBoxSpeed.Value;
            Settings.Default.Save();
            base.OnClosing(e);
        }

        private void SetupBeepPlayer()
        {
            beepPlayer.FinishedPlaying += (s, e) =>
            {
                beepPlayer.Stop();
                buttonPlay.Text = "Play";
                labelTitle.ForeColor = titleColor;
                note = 0;
                textBoxSequence.Select(0, 0);
            };

            beepPlayer.NotePlaying += (s, e) =>
            {
                NumberRange range = FreqAnalyzer.GetFreqRangeFromNotes(beepPlayer.Notes);
                FreqAnalyzer FA = new FreqAnalyzer(titleColor, e.Frequency, range);
                Color color = FA.GetNewColor();
                labelTitle.ForeColor = color;
                textBoxSequence.SelectNote(note++);
            };
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (buttonPlay.Text == "Play")
            {
                beepPlayer.Sequence = textBoxSequence.Text;
                beepPlayer.Play();
                buttonPlay.Text = "Stop";
            }
            else
            {
                beepPlayer.Stop();
            }
        }

        private void numberBoxDuration_ValueChanged(object sender, EventArgs e)
        {
            beepPlayer.SpeedMultiplier = (float)numberBoxSpeed.Value;
        }

        private void buttonOpenParser_Click(object sender, EventArgs e)
        {
            using (var formParse = new ParserForm())
            {
                formParse.ShowDialog();
            }
        }

        private void sequenceMenuStrip_SequenceLoaded(object sender, string e)
        {
            textBoxSequence.Text = e;
            beepPlayer.Stop();
        }
    }
}
