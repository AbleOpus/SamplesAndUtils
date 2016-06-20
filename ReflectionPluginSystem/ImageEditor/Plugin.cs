using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ImageEditor
{
    /// <summary>
    /// Represents an application plug-in.
    /// </summary>
    public class Plugin
    {
        /// <summary>
        /// Gets the menu item associated with the plug-in.
        /// </summary>
        public ToolStripMenuItem MenuItem { get; } = new ToolStripMenuItem();

        /// <summary>
        /// Gets the exception that was thrown when trying to load the plug-in.
        /// </summary>
        public Exception Exception { get; }

        /// <summary>
        /// Gets the name of the plug-in.
        /// </summary>
        public string PluginName { get; private set; }

        /// <summary>
        /// Gets whether the plug-in has been successfully loaded.
        /// </summary>
        public bool Loaded => Exception == null;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plugin"/> class
        /// with the specified arguments.
        /// </summary>
        /// <param name="fileName">The location of the plug-in file.</param>
        /// <param name="picBox">The picture box the plug-in will work on.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public Plugin(string fileName, PictureBox picBox)
        {
            if (String.IsNullOrEmpty(fileName))
                throw new ArgumentNullException(nameof(fileName));

            PluginName = Path.GetFileName(fileName);

            try
            {
                Assembly assembly = Assembly.LoadFrom(fileName);
                Type type = assembly.GetType("ImageEditor.Plugin");
                MenuItem.Text = type.GetProperty("Caption").GetValue(null).ToString();
                MenuItem.Image = (Image)type.GetProperty("Bitmap").GetValue(null);
                MenuItem.Click += delegate
                {
                    Type[] args = { typeof(PictureBox) };
                    type.GetMethod("Entry", args).Invoke(null, new object[] { picBox });
                };
            }
            // A plug-in system could be loading a to of third party plug-ins which may be unstable.
            // It's best to not allow a plug-in to break a program, but save the exception for later.
            catch (Exception ex)
            {
                Exception = ex;
            }
        }
    }
}
