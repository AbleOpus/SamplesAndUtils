using System.Drawing;
using System.IO;
using System.Xml.Serialization;
using AdvancedWebBrowser.Drawing;

namespace AdvancedWebBrowser.Forms
{
    /// <summary>
    /// Represents a syntax highlighter.
    /// </summary>
    public class RichSyntaxHighlighter
    {
        /// <summary>
        /// Gets or sets the color profiles for this highlighter.
        /// </summary>
        public RichColorProfile[] Profiles { get; set; }

        /// <summary>
        /// Gets or sets the name of this syntax highlighter.
        /// </summary>
        [XmlAttribute]
        public string Name { get; set; }

        /// <summary>
        /// Gets the desired back color to be used with this highlighter.
        /// </summary>
        [XmlElement(Type = typeof(XmlColor))]
        public Color DesiredBackColor { get; set; }

        // For serialization
        protected RichSyntaxHighlighter() { }

        public RichSyntaxHighlighter(string name, params RichColorProfile[] profiles)
        {
            Name = name;
            Profiles = profiles;
        }

        /// <summary>
        /// Saves this instance as XML.
        /// </summary>
        public void Save(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Create))
            {
                var xml = new XmlSerializer(this.GetType());
                xml.Serialize(stream, this);
            }
        }

        /// <summary>
        /// Loads a RichSyntaxHighlighter from file.
        /// </summary>
        /// <param name="fileName">The path of the file to load.</param>
        public static RichSyntaxHighlighter Load(string fileName)
        {
            using (var stream = new FileStream(fileName, FileMode.Open))
            {
                var xml = new XmlSerializer(typeof(RichSyntaxHighlighter));
               return (RichSyntaxHighlighter)xml.Deserialize(stream);
            }
        }
    }
}
