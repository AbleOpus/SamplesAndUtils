using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Beeper
{
    /// <summary>
    /// Plays musical notes through the system speakers.
    /// </summary>
    class BeepPlayer
    {
        private SynchronizationContext syncContext;
        private bool cancelationPending;

        /// <summary>
        /// Gets or sets the multiplier to alter the master speed 
        /// at which the track is played.
        /// </summary>
        public float SpeedMultiplier { get; set; }

        /// <summary>
        /// Gets the loaded notes.
        /// </summary>
        public Note[] Notes { get; private set; }

        private string sequence;
        public string Sequence
        {
            get { return sequence; }
            set
            {
                sequence = value;
                Notes = GetNotes(sequence);
            }
        }

        /// <summary>
        /// Occurs when a note just starts playing.
        /// </summary>
        public event EventHandler<Note> NotePlaying;

        /// <summary>
        /// Occurs when a sequence has finished playing.
        /// </summary>
        public event EventHandler FinishedPlaying;

        public BeepPlayer()
        {
            SpeedMultiplier = 1;
        }

        private Note[] GetNotes(string sequence)
        {
            cancelationPending = false;
            var noteList = new List<Note>();
            MatchCollection matches = Regex.Matches(
                sequence, 
                @"\((?<Freq>\d+)-(?<Dura>\d+)(-(?<Pause>\d+))?\)");

            foreach (Match match in matches)
            {
                int freq = int.Parse(match.Groups["Freq"].Value);
                int dura = int.Parse(match.Groups["Dura"].Value);
                int pause = 0;

                if (match.Groups["Pause"].Success)
                   pause = int.Parse(match.Groups["Pause"].Value);

                noteList.Add(new Note(freq, dura, pause));
            }

            return noteList.ToArray();
        }

        public void Play()
        {
            if (syncContext == null)
            {
                syncContext = SynchronizationContext.Current;
            }

            Task.Run(() =>
            {
                foreach (Note note in Notes)
                {
                    if (cancelationPending) break;
                    int duration = (int) (note.Duration*SpeedMultiplier + 0.5f);
                    int pause = (int) (note.Pause*SpeedMultiplier + 0.5f);
                    syncContext.Post(OnNotePlaying, new Note(note.Frequency, duration, pause));
                    //OnNotePlaying(new Note(note.Frequency, duration, pause));
                    //NotePlaying?.Invoke(this,new Note(note.Frequency, duration, pause));
                    Console.Beep(note.Frequency, duration);
                    Thread.Sleep(pause);
                }

                syncContext.Post(OnFinishedPlaying, null);
               // FinishedPlaying?.Invoke(this, EventArgs.Empty);
            });
        }

        private void OnFinishedPlaying(object obj)
        {
            FinishedPlaying?.Invoke(this, EventArgs.Empty);
        }

        private void OnNotePlaying(object obj)
        {
            NotePlaying?.Invoke(this, (Note)obj);
        }

        /// <summary>
        /// Stops the async playback of the sequence.
        /// </summary>
        public void Stop()
        {
            cancelationPending = true;
        }
    }
}
