namespace Beeper
{
    class Note
    {
        /// <summary>
        /// Gets the pitch of the note.
        /// </summary>
        public int Frequency { get; }

        /// <summary>
        /// Gets how long the note will play for.
        /// </summary>
        public int Duration { get; }

        /// <summary>
        /// Gets or sets the pause at the end of the note.
        /// </summary>
        public int Pause { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Note"/> class
        /// with the specified arguments.
        /// </summary>
        /// <param name="frequency">The pitch of the note.</param>
        /// <param name="duration">How long the note will play for.</param>
        /// <param name="pause">The pause at the end of the note.</param>
        public Note(int frequency, int duration, int pause)
        {
            Duration = duration;
            Frequency = frequency;
            Pause = pause;
        }

        public override string ToString()
        {
            return Pause > 0 ? 
                $@"({Frequency}-{Duration}-{Pause})" : $@"({Frequency}-{Duration})";
        }
    }
}
