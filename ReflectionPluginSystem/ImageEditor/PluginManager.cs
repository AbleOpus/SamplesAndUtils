using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ImageEditor
{
    /// <summary>
    /// Manages loaded or failed to load plug-ins.
    /// </summary>
    class PluginManager
    {
        private readonly List<Plugin> plugins = new List<Plugin>();
        /// <summary>
        /// Gets the plug-ins loaded into the application.
        /// </summary>
        public IReadOnlyList<Plugin> Plugins => plugins;

        /// <summary>
        /// Initializes a new instance of the <see cref="PluginManager"/> class
        /// with the specified argument.
        /// </summary>
        /// <param name="pictureBox">The picture box to alter.</param>
        public PluginManager(PictureBox pictureBox)
        {
            string[] fileNames = Directory.GetFiles(Application.StartupPath, "*.dll");

            foreach (string name in fileNames)
            {
                plugins.Add(new Plugin(name, pictureBox));
            }
        }
    }
}
