using System.Drawing;
using System.Xml.Serialization;

namespace AdvancedWebBrowser.Drawing
{
    /// <summary>
    /// Represents an XML-serializable color.
    /// </summary>
    public class XmlColor
    {
        private Color color = Color.Black;

        /// <summary>
        /// Gets or sets the name of this color.
        /// </summary>
        [XmlAttribute]
        public string Name
        {
            get { return ColorTranslator.ToHtml(color); }
            set
            {
                try
                {
                    color = ColorTranslator.FromHtml(value);
                }
                catch
                {
                    color = Color.Empty;
                }
            }
        }

        public XmlColor() { }

        public XmlColor(Color c) { color = c; }

        /// <summary>
        /// Convert to standard <see cref="Color"/> type.
        /// </summary>
        public Color ToColor()
        {
            return color;
        }

        public static implicit operator Color(XmlColor x)
        {
            return x.ToColor();
        }

        public static implicit operator XmlColor(Color c)
        {
            return new XmlColor(c);
        }
    }
}
