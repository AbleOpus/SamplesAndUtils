using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;

namespace AdvancedWebBrowser.Forms
{
    class RichColorTable
    {
        // ex: {\colortbl ;\red220\green220\blue220;\red30\green30\blue30;}
        private const string TABLE_PATTERN = @"\{\\colortbl[^\}]+\}";
        private const string TABLE_ELEMENT_PATTERN = @"\\red(?<R>\d{1,3})\\green(?<G>\d{1,3})\\blue(?<B>\d{1,3})";

        /// <summary>
        /// Gets a RichColorTable with no colors.
        /// </summary>
        public static RichColorTable Empty => new RichColorTable();

        private readonly List<Color> colors = new List<Color>();
        /// <summary>
        /// Gets the list of colors that make up the table.
        /// </summary>
        public IEnumerable<Color> Colors => colors;

        /// <summary>
        /// Adds colors to the color table, if they do not already exist.
        /// </summary>
        public void AddColors(params Color[] colors)
        {
            foreach (var color in colors)
            {
                if (!this.colors.Contains(color))
                    this.colors.Add(color);
            }
        }

        /// <summary>
        /// Gets the color ID as a string (Ex: cf4).
        /// </summary>
        /// <param name="color">The color to look for an ID for.</param>
        /// <returns>null, if no matching color in table.</returns>
        public string GetColorID(Color color)
        {
            int num = GetColorIndex(color);
            if (num == -1) return null;
            // Inject right space otherwise, intentional space might be ignored.
            return "\\cf" + num + " "; 
        }

        /// <summary>
        /// Gets the index (offset around one), to apply the color in RTF.
        /// </summary>
        /// <returns>-1, if not present.</returns>
        public int GetColorIndex(Color color)
        {
            for (int i = 0; i < colors.Count; i++)
            {
                if (colors[i] == color) return i + 1; // Index offset around 1
            }

            return -1;
        }

        public override string ToString()
        {
            // ex: {\colortbl ;\red220\green220\blue220;\red30\green30\blue30;}
            var SB = new StringBuilder();
            SB.Append(@"{\colortbl ;");

            foreach (Color color in colors)
            {
                SB.Append(@"\red" + color.R);
                SB.Append(@"\green" + color.G);
                SB.Append(@"\blue" + color.B + ";");
            }

            SB.Append(@"}");
            return SB.ToString();
        }

        /// <summary>
        /// Removes the old table from the RTF and injects this one.
        /// </summary>
        /// <param name="rtf">The RTF of a RichTextBox.</param>
        public string InjectTable(string rtf)
        {
            Match match = Regex.Match(rtf, TABLE_PATTERN);

            if (match.Success)
            {
                rtf = rtf.Remove(match.Index, match.Length);
                rtf = rtf.Insert(match.Index, this.ToString());
                return rtf;
            }

            int index = rtf.IndexOf("\r\n");

            if (index == -1) 
                throw new IndexOutOfRangeException("No viable place to inject color table");

            return rtf.Insert(index + 2, this + "\n");
        }

        /// <summary>
        /// Gets the color table defined in rich text format.
        /// </summary>
        /// <returns>An empty table, if no table found.</returns>
        /// <param name="rtf">The RTF of a RichTextBox.</param>
        public static RichColorTable ExtractColorTable(string rtf)
        {
            string tableStr = Regex.Match(rtf, TABLE_PATTERN).Value;
            if (String.IsNullOrEmpty(tableStr)) return Empty;
            MatchCollection MC = Regex.Matches(tableStr, TABLE_ELEMENT_PATTERN);
            var table = new RichColorTable();

            foreach (Match match in MC)
            {
                int R = int.Parse(match.Groups["R"].Value);
                int G = int.Parse(match.Groups["G"].Value);
                int B = int.Parse(match.Groups["B"].Value);
                table.AddColors(Color.FromArgb(R, G, B));
            }

            return table;
        }

        /// <summary>
        /// Removes the color table statement from the RTF.
        /// </summary>
        /// <param name="rtf">The RTF of a RichTextBox.</param>
        /// <returns>The original string, if no table found.</returns>
        public static string RemoveColorTable(string rtf)
        {
            Match match = Regex.Match(rtf, TABLE_PATTERN);

            if (match.Success)
            {
                return rtf.Remove(match.Index, match.Length);
            }

            return rtf;
        }

        #region Equality
        protected bool Equals(RichColorTable other)
        {
            return Equals(colors, other.colors);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((RichColorTable)obj);
        }

        public override int GetHashCode()
        {
            return colors?.GetHashCode() ?? 0;
        }

        public static bool operator ==(RichColorTable left, RichColorTable right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(RichColorTable left, RichColorTable right)
        {
            return !Equals(left, right);
        }
        #endregion
    }
}
