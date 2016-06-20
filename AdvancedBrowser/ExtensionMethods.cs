using System;
using System.Drawing;
using System.Windows.Forms;

namespace AdvancedWebBrowser
{
    static class ExtensionMethods
    {
        /// <summary>
        /// Adds an auto-ellipses to the specified string, if the specified string is too long.
        /// </summary>
        /// <param name="text">The text to append to.</param>
        /// <param name="font">The font to use as measurement.</param>
        /// <param name="maxWidth">The maximum width the caption should roughly be.</param>
        /// <returns>Returns the original string, if the original string is short enough.</returns>
        public static string AutoEllipsesString(this string text, Font font, int maxWidth)
        {
            int elipsesWidth = TextRenderer.MeasureText("...", font).Width;
            bool appendPeriods = false;

            while (TextRenderer.MeasureText(text, font).Width + elipsesWidth > maxWidth)
            {
                text = text.Remove(text.Length - 1, 1);
                appendPeriods = true;
            }

            if (appendPeriods) return text + "...";
            return text;
        }

        /// <summary>
        /// Converts the Bitmap to an Icon.
        /// </summary>
        /// <param name="bitmap">The Bitmap to convert.</param>
        /// <returns>The converted Bitmap as an Icon.</returns>
        public static Icon ToIcon(this Bitmap bitmap)
        {
            var handle = bitmap.GetHicon();
            return Icon.FromHandle(handle);
        }

        /// <summary>
        /// Shows the Exception's message in an error dialog.
        /// </summary>
        public static void ShowMessage(this Exception ex)
        {
            MessageBox.Show(ex.Message, Application.ProductName,
              MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
