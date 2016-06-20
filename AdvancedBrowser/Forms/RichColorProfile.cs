using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Serialization;
using AdvancedWebBrowser.Drawing;

namespace AdvancedWebBrowser.Forms
{
    /// <summary>
    /// Represents a color to apply to certain text in RTF.
    /// </summary>
    public class RichColorProfile
    {
        /// <summary>
        /// Gets or sets the options to use for looking for substring.
        /// </summary>
        public RegexOptions RegexOptions { get; set; }

        /// <summary>
        /// Gets or sets the pattern to be used for getting substrings.
        /// </summary>
        public string Pattern { get; set; }

        /// <summary>
        /// Gets or sets the color to apply to the matches found with this profile.
        /// </summary>
        [XmlElement(Type = typeof(XmlColor))]
        public Color Color { get; set; }

        // For serialization
        protected RichColorProfile() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="RichColorProfile"/> class
        /// with the specified arguments.
        /// </summary>
        /// <param name="pattern">The pattern to use to find substrings to colorize.</param>
        /// <param name="color">The color to apply to the matches.</param>
        public RichColorProfile(string pattern, Color color)
        {
            Pattern = pattern;
            RegexOptions = RegexOptions.None;
            Color = color;
        } 
    }
}
