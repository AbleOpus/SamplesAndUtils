using System.Drawing;
using System.Windows.Forms;

namespace AboCodeLibrary
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Determines whether or not the char is a vowel.
        /// </summary>
        public static bool IsVowel(this char c)
        {
            return c.Equals('a') ||
                   c.Equals('e') ||
                   c.Equals('i') ||
                   c.Equals('o') ||
                   c.Equals('u');
        }

        /// <summary>
        /// Gets whether the number is odd.
        /// </summary>
        public static bool IsOdd(this int number)
        {
            return (number & 1).Equals(0);
        }

        /// <summary>
        /// Gets short-form information about a Font.
        /// </summary>
        /// <param name="font"></param>
        /// <returns>A simple string representation of the Font.</returns>
        public static string GetBasicInfo(this Font font)
        {
            return font.FontFamily.Name + " " + font.Size;
        }

        /// <summary>
        /// Docks the Form to the left of the screen it is within.
        /// </summary>
        public static void DockLeft(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            Rectangle rect = Screen.GetWorkingArea(form);
            form.Bounds = new Rectangle(rect.X, rect.Y, rect.Width /2, rect.Height);
        }

        /// <summary>
        /// Docks the Form to the bottom of the screen it is within.
        /// </summary>
        public static void DockBottom(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            Rectangle rect = Screen.GetWorkingArea(form);
            form.Bounds = new Rectangle(rect.X, rect.Y + rect.Height / 2, rect.Width, rect.Height / 2);
        }

        /// <summary>
        /// Docks the Form to the top of the screen it is within.
        /// </summary>
        public static void DockTop(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            Rectangle rect = Screen.GetWorkingArea(form);
            form.Bounds = new Rectangle(rect.X, rect.Y, rect.Width, rect.Height / 2);
        }

        /// <summary>
        /// Docks the Form to the right of the screen it is within.
        /// </summary>
        public static void DockRight(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            Rectangle rect = Screen.GetWorkingArea(form);
            form.Bounds = new Rectangle(rect.X + rect.Width / 2, rect.Y, rect.Width / 2, rect.Height);
        }

        /// <summary>
        /// Scales a control with a center anchor.
        /// </summary>
        /// <param name="control">The control to be scaled.</param>
        /// <param name="scaleFactor">The factor at which to scale.</param>
        public static void ScaleAroundCenter(this Control control, float scaleFactor)
        {
            Size lastSize = control.Size;
            control.Size = new Size((int)(control.Width * scaleFactor + 0.5),
                (int)(control.Height * scaleFactor));

            control.Location = new Point(control.Location.X +
                (lastSize.Width - control.Size.Width) / 2,
                control.Location.Y + (lastSize.Height - control.Size.Height) / 2);
        }

        /// <summary>
        /// Scales a control with a center anchor.
        /// </summary>
        /// <param name="control">The control to be scaled.</param>
        /// <param name="scaleAmount">The amount to scale.</param>
        public static void ScaleAroundCenter(this Control control, int scaleAmount)
        {
            control.Size = new Size(control.Size.Width + scaleAmount,
                control.Size.Height + scaleAmount);

            control.Location = new Point(control.Location.X - (scaleAmount / 2),
                control.Location.Y - (scaleAmount / 2));
        }

        /// <summary>
        /// Gets the bit value as a character, bit value being 1 or 0
        /// </summary>
        public static char ToBitChar(this bool boolean)
        {
            return boolean ? '1' : '0';
        }

        /// <summary>
        /// Converts the char to a boolean. 1 returns true,
        /// everything else returns false.
        /// </summary>
        public static bool ToBoolean(this char c)
        {
            return (c.Equals('1'));
        }

        /// <summary>
        /// Changes the brightness of a color by altering its RGB values.
        /// </summary>
        /// <param name="color">The color to be altered.</param>
        /// <param name="factor">The amount to change and in what way (Negative is darker).</param>
        /// <returns>Color that has been altered.</returns>
        public static Color ChangeBrightness(this Color color, int factor)
        {
            int R = (color.R + factor > 255) ? 255 : color.R + factor;
            int G = (color.G + factor > 255) ? 255 : color.G + factor;
            int B = (color.B + factor > 255) ? 255 : color.B + factor;
            if (R < 0) R = 0;
            if (B < 0) B = 0;
            if (G < 0) G = 0;
            return Color.FromArgb(R, G, B);
        }
    }
}
