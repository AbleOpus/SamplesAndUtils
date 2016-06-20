using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Media;
using ABitOfMemory.Properties;

namespace ABitOfMemory
{
    class Session : IDisposable
    {
        private int score, playbackIndex, playIndex, time;
        private const int PLAYBACK_SPEED = 200;
        private readonly List<bool> sequence = new List<bool>();
        private readonly Button buttonOne, buttonZero;
        private readonly Timer timer = new Timer();
        private readonly SoundPlayer soundPlayer = new SoundPlayer();
        private readonly Random random = new Random();

        public event EventHandler<string> SessionCompleted;

        public Session(Button oneButton, Button zeroButton)
        {
            timer.Interval = PLAYBACK_SPEED;
            timer.Tick += timer_Tick;
            buttonOne = oneButton;
            buttonZero = zeroButton;
            buttonOne.Click += (sender, e) => InputSequence(true);
            buttonZero.Click += (sender, e) => InputSequence(false);
        }

        public void InputSequence(bool b)
        {
            PlaySound(b);

            if (sequence[playIndex] == b)
            {
                if (playIndex >= sequence.Count - 1)
                {
                    score++;
                    StartPlayBack();
                    return;
                }

                playIndex++;
            }
            else
            {
                soundPlayer.Stop();
                buttonOne.Visible = buttonZero.Visible = false;
                CheckHighScore();
                SessionCompleted?.Invoke(this, SequenceString);
            }
        }

        /// <summary>
        /// Plays a high beep for 1, which is true, and a low beep
        /// for 0, which is false.
        /// </summary>
        private void PlaySound(bool isOne)
        {
            soundPlayer.Stream = isOne ? Resources.high_beep : Resources.low_beep;
            soundPlayer.Play();
        }

        /// <summary>
        /// Checks for a high score. If one is found, then show the high score window.
        /// </summary>
        private void CheckHighScore()
        {
            if (score > Settings.Default.highScore)
            {
                HighScoreForm highScoreForm = new HighScoreForm();
                highScoreForm.SetHighScore(score);
                string seq = SequenceString;
                // Remove last number in sequence as it was the fail
                seq = seq.Substring(0, seq.Length - 1);
                highScoreForm.SetSequence(seq);
                highScoreForm.ShowDialog();
                highScoreForm.Dispose();
                Settings.Default.highScore = score;
                Settings.Default.Save();
            }
        }

        public void New()
        {
            timer.Stop();
            score = playIndex = 0;
            sequence.Clear();
            StartPlayBack();
        }

        private void AddBit()
        {
            int num = random.Next(0, 2);
            bool b = (!num.Equals(0));
            sequence.Add(b);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if ((time++).IsOdd())
            {
                if (playbackIndex > sequence.Count - 1)
                {
                    playIndex = 0;
                    timer.Stop();
                    buttonOne.Enabled = buttonZero.Enabled = true;
                    return;
                }

                IlluminateButton();

                playbackIndex++;
            }
            else
            {
                buttonOne.BackColor = buttonZero.BackColor = Color.Silver;
            }
        }

        private void IlluminateButton()
        {
            if (sequence[playbackIndex] == false)
            {
                PlaySound(false);
                buttonZero.BackColor = Color.White;
                buttonOne.BackColor = Color.Silver;
            }
            else
            {
                PlaySound(true);
                buttonZero.BackColor = Color.Silver;
                buttonOne.BackColor = Color.White;
            }
        }

        private void StartPlayBack()
        {
            playbackIndex = 0;
            AddBit();
            buttonZero.Enabled = buttonOne.Enabled = false;
            timer.Start();
        }

        /// <summary>
        /// Gets the sequence that has been entered correctly as a string
        /// </summary>
        private string SequenceString
        {
            get
            {
                string seq = string.Empty;

                foreach (bool b in sequence)
                    seq += b ? "1" : "0";

                if (seq.Length > 0)
                    seq = seq.Substring(0, seq.Length - 1);

                return seq;
            }
        }

        public void Dispose()
        {
            timer.Dispose();
            soundPlayer.Dispose();
        }
    }
}
