using System.Collections.Generic;
using System.Drawing;

namespace Beeper
{
    class FreqAnalyzer
    {
        private NumberRange freqRange;
        private readonly Color oldColor;
        private readonly int frequency;

        public FreqAnalyzer(Color oldColor, int freq, NumberRange freqRange)
        {
            this.oldColor = oldColor;
            frequency = freq;
            this.freqRange = freqRange;
        }

        /// <summary>
        /// Gets a percentage of the pitch. The pitch is acquired by contrasting the
        /// frequency with the frequency range (0-1).
        /// </summary>
        private float GetPitchPercentage()
        {
            return (frequency - freqRange.From) / 
                (float)(freqRange.To - freqRange.From);
        }

        public Color GetNewColor()
        {
            float percent = GetPitchPercentage() + 0.6f;
            return ChangeColorBrightness(oldColor, percent);
        }

        private static Color ChangeColorBrightness(Color color, float factor)
        {
            int R = (color.R * factor > 255) ? 255 : (int)(color.R * factor);
            int G = (color.G * factor > 255) ? 255 : (int)(color.G * factor);
            int B = (color.B * factor > 255) ? 255 : (int)(color.B * factor);
            if (R < 0) R = 0;
            if (B < 0) B = 0;
            if (G < 0) G = 0;
            return Color.FromArgb(R, G, B);
        }

        /// <summary>
        /// Gets the lowest and highest frequencies used in a note array
        /// </summary>
        public static NumberRange GetFreqRangeFromNotes(IEnumerable<Note> notes)
        {
            int lowest = int.MaxValue;
            int highest = 0;

            foreach (Note note in notes)
            {
                if (note.Frequency > highest) highest = note.Frequency;
                if (note.Frequency < lowest) lowest = note.Frequency;
            }

            return new NumberRange(lowest, highest);
        }
    }
}
