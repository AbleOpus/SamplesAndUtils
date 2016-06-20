using System;

namespace IniEditing
{
    /// <summary>
    /// Raises when entering a context where a file needs to be loaded and is not.
    /// </summary>
    public class NoFileLoadedException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NoFileLoadedException"/>
        /// class with a specified argument.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public NoFileLoadedException(string message) : base(message) { }
    }
}
