namespace Beeper
{
    class ConversionParams
    {
        /// <summary>
        /// Gets the default pause time (in MS). Which should typically be zero.
        /// </summary>
        public int DefaultPause { get; set; }

        /// <summary>
        /// Gets the default duration (in MS) of a note when duration info cant be retrieved.
        /// </summary>
        public int DefaultDuration { get; set; }

        /// <summary>
        /// Gets the time (in MS) to pause when a comma is found in music notes.
        /// </summary>
        public int DefaultCommaPause { get; set; }

        /// <summary>
        /// Gets the time (in MS) to pause when a semi-colon is found in music notes.
        /// </summary>
        public int DefaultSemiColonPause { get; set; }

        /// <summary>
        /// Gets the time (in MS) to pause when a period is found in music notes.
        /// </summary>
        public int DefaultPeriodPause { get; set; }
    }
}
