using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Beeper
{
    /// <summary>
    /// Deals with converting to and from a sequence string.
    /// </summary>
    static class SequenceConversion
    {
        /// <summary>
        /// Converts PowerShell commands to a note array.
        /// </summary>
        public static Note[] PowerShellToNoteArray(string text, ConversionParams CP)
        {
            var noteList = new List<Note>();

            const string PATTERN = 
                @"((|\[console\]::)beep\((?<Freq>\d+)\s*,\s*(?<Dura>\d+)\);?)|
                (Start-Sleep\s+-m\s+(?<Sleep>\d+))";

            const RegexOptions OPTIONS = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
            var MC = Regex.Matches(text, PATTERN, OPTIONS);

            foreach (Match match in MC)
            {
                if (match.Groups["Sleep"].Success && noteList.Count > 0)
                {
                    noteList.Last().Pause = int.Parse(match.Groups["Sleep"].Value);
                }
                else
                {
                    int freq = int.Parse(match.Groups["Freq"].Value);
                    int dura = int.Parse(match.Groups["Dura"].Value);
                    noteList.Add(new Note(freq, dura, CP.DefaultPause));
                }
            }

            return noteList.ToArray();
        }

        /// <summary>
        /// Converts bash commands to a note array.
        /// </summary>
        public static Note[] BashToNoteArray(string text, ConversionParams CP)
        {
            var noteList = new List<Note>();
            // Ex. {beep -f 295 -l 222}
            const string PATTERN = @"beep\s+(-f)\s+(?<Freq>\d+)\s+(-l)?\s+(?<Dura>\d+)";

            const RegexOptions OPTIONS = RegexOptions.IgnoreCase | RegexOptions.IgnorePatternWhitespace;
            var MC = Regex.Matches(text, PATTERN, OPTIONS);

            foreach (Match match in MC)
            {
                if (match.Groups["Sleep"].Success && noteList.Count > 0)
                {
                    noteList.Last().Pause = int.Parse(match.Groups["Sleep"].Value);
                }
                else
                {
                    int freq = int.Parse(match.Groups["Freq"].Value);
                    int dura = int.Parse(match.Groups["Dura"].Value);
                    noteList.Add(new Note(freq, dura, CP.DefaultPause));
                }
            }

            return noteList.ToArray();
        }

        /// <summary>
        /// Converts a note array to a sequence string.
        /// </summary>
        public static string NoteArrayToSequence(Note[] notes)
        {
            var SB = new StringBuilder();

            foreach (Note note in notes)
                SB.Append(note + " ");

            return SB.ToString();
        }

        /// <summary>
        /// Converts a typical text music sheet to a note array.
        /// </summary>
        public static Note[] MusicSheetToNoteArray(string text, ConversionParams CP)
        {
            var noteList = new List<Note>();
            text = text.ToLower();
            MatchCollection matches = Regex.Matches(text, @"\b(?<Note>[a-g]\#?)[,\.;]?");

            for (int i = 0; i < matches.Count; i++)
            {
                string strNote = matches[i].Groups["Note"].Value;
                int freq = LetterNoteToFreq(strNote);
                int pause;
                string temp = matches[i].Value;

                if (temp.Contains(",")) 
                    pause = CP.DefaultCommaPause;
                else if (temp.Contains(";"))
                    pause = CP.DefaultSemiColonPause;
                else if (temp.Contains("."))
                    pause = CP.DefaultPeriodPause;
                else pause =  CP.DefaultPause;

                noteList.Add(new Note(freq, CP.DefaultDuration, pause));
            }

            return noteList.ToArray();
        }

       /// <summary>
       /// Converts a letter representation of a note to the equivalent beep frequency.
       /// </summary>
        private static int LetterNoteToFreq(string note)
        {
            note = note.ToLower();

            switch (note)
            {
                case "a": return 220;
                case "a#": return 233;
                case "b": return 247;
                case "c": return 262;
                case "c#": return 277;
                case "d": return 294;
                case "d#": return 311;
                case "e": return 330;
                case "f": return 349;
                case "f#": return 370;
                case "g": return 392;
                case "g#": return 415;
                default: return 2000;
            }
        }

        /// <summary>
        /// Converts C# code to a note array.
        /// </summary>
        public static Note[] CSharpCodeToNoteArray(string code, ConversionParams CP)
        {
            var noteList = new List<Note>();
            var MC = Regex.Matches(
                code, 
                @"(Thread\.Sleep\((?<Pause>\d+)\);)|(Console\.Beep\((?<Freq>\d+),\s*(?<Dura>\d+)\);)",
                RegexOptions.IgnorePatternWhitespace);

            foreach (Match match in MC)
            {
                // If we find a pause then apply the pause for the last note in the list
                if (match.Groups["Pause"].Success && noteList.Count > 0)
                {
                    int num;
                    int.TryParse(match.Groups["Pause"].Value, out num);
                    noteList[noteList.Count - 1].Pause = num;
                }
                else if (match.Groups["Freq"].Success)
                {
                    int num1, num2;
                    int.TryParse(match.Groups["Freq"].Value, out num1);
                    int.TryParse(match.Groups["Dura"].Value, out num2);
                    noteList.Add(new Note(num1, num2, CP.DefaultPause));
                }
            }

            return noteList.ToArray();
        }
    }
}
