using System.Drawing;
using System.Windows.Forms;

namespace AboCodeLibrary
{
    // Assume the less specific overloads are error boxes.
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

        public static string GetBasicInfo(this Font font)
        {
            return font.FontFamily.Name + " " + font.Size;
        }

        public static void DockLeft(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            int width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            form.Size = new Size(width, height);
            form.Location = Screen.PrimaryScreen.Bounds.Location;
        }

        public static void DockBottom(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            form.Width = Screen.PrimaryScreen.WorkingArea.Width;
            form.Height = Screen.PrimaryScreen.WorkingArea.Height / 2;

            int xPos = Screen.PrimaryScreen.WorkingArea.X;
            int workAreaHeight = Screen.PrimaryScreen.WorkingArea.Height;
            form.Location = new Point(xPos, workAreaHeight / 2);
        }

        public static void DockTop(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            form.Width = Screen.PrimaryScreen.WorkingArea.Width;
            form.Height = Screen.PrimaryScreen.WorkingArea.Height / 2;
            form.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        public static void DockRight(this Form form)
        {
            form.WindowState = FormWindowState.Normal;
            int width = Screen.PrimaryScreen.WorkingArea.Width / 2;
            int height = Screen.PrimaryScreen.WorkingArea.Height;
            form.Size = new Size(width, height);
            int xPos = SystemInformation.PrimaryMonitorSize.Width - form.Width;
            int yPos = Screen.PrimaryScreen.WorkingArea.Y / 2;
            form.Location = new Point(xPos, yPos);
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
        /// everything else returns false
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
