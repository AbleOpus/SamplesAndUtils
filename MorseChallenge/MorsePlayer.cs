using System;
using System.Threading;
using System.Threading.Tasks;

namespace MorseChallenge
{
    /// <summary>
    /// Plays morse code beeps at specific intervals to represent morse code.
    /// </summary>
    class MorsePlayer
    {
        /// <summary>
        /// Gets or sets the duration of a dot.
        /// </summary>
        public int Unit { get; set; }

        /// <summary>
        /// Gets or sets the frequency of the beep.
        /// </summary>
        public int Frequency { get; set; }

        /// <summary>
        /// Gets or sets the pause between letters as a multiple of the Unit.
        /// </summary>
        public int LetterGap { get; set; }

        /// <summary>
        /// Occurs when a morse sequence has finished playing.
        /// </summary>
        public event EventHandler FinishedPlaying;

        /// <summary>
        /// Occurs when the beeper starts or stops beeping.
        /// </summary>
        public event EventHandler<bool> BeepToggled;

        public MorsePlayer()
        {
            Unit = 300;
            Frequency = 1000;
            LetterGap = 3;
        }

        /// <summary>
        /// Raises the <see cref="BeepToggled"/> event.
        /// </summary>
        private void OnBeepToggled(bool toggle) => 
            BeepToggled?.Invoke(this, toggle);

        /// <summary>
        /// Plays the entire more code through the system speakers.
        /// </summary>
        private void PlaySequence(string code)
        {
            foreach (char c in code)
            {
                if (c.Equals('-'))
                {
                    OnBeepToggled(true);
                    Console.Beep(Frequency, Unit * 3);
                    OnBeepToggled(false);
                }
                else if (c.Equals('.') || c.Equals('•'))
                {
                    OnBeepToggled(true);
                    Console.Beep(Frequency, Unit);
                    OnBeepToggled(false);
                }
                else if (c.Equals(' '))
                {
                    // Subtract 1 as we pause at the end of the loop for a unit
                    Thread.Sleep(Unit * (LetterGap - 1));
                }

                Thread.Sleep(Unit);
            }
        }

        public void PlayAsync(string code)
        {
            Task.Run(() =>
            {
                PlaySequence(code);
                FinishedPlaying?.Invoke(this, EventArgs.Empty);
            });
        }
    }
}
