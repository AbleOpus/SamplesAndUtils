using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using FullscreenShot.Properties;

namespace FullscreenShot
{
    static class Program
    {
        private static NotifyIcon notifyIcon;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // We need to dispose here, or the icon will not remove until the 
            // system tray is updated.
            Application.ApplicationExit += delegate
            {
                notifyIcon.Dispose();
            };
            CreateNotifyIcon();
            Application.Run();
        }

        /// <summary>
        /// Creates the icon that sits in the system tray.
        /// </summary>
        private static void CreateNotifyIcon()
        {
            notifyIcon = new NotifyIcon
            {
                Icon = Resources.AppIcon,
                ContextMenu = GetContextMenu(),
                Visible = true
            };
        }

        /// <summary>
        /// Gets a predefined <see cref="ContextMenu"/> for executing code.
        /// </summary>
        private static ContextMenu GetContextMenu()
        {
            ContextMenu menu = new ContextMenu();
            menu.MenuItems.Add("Take Screenshot", delegate { TakeFullScreenShot(); });
            menu.MenuItems.Add("Exit", delegate { Application.Exit(); });
            return menu;
        }

        /// <summary>
        /// Take a screenshot of the entire screen and save it as a .PNG.
        /// </summary>
        private static void TakeFullScreenShot()
        {
            int width = Screen.PrimaryScreen.Bounds.Width;
            int height = Screen.PrimaryScreen.Bounds.Height;

            using (Bitmap screenshot = new Bitmap(width, height, PixelFormat.Format32bppArgb))
            {
                using (Graphics graphics = Graphics.FromImage(screenshot))
                {
                    Point origin = new Point(0, 0);
                    Size screenSize = Screen.PrimaryScreen.Bounds.Size;
                    //Copy Entire screen to entire bitmap.
                    graphics.CopyFromScreen(origin, origin, screenSize);
                }

                //Check to see if the file exists, if it does, append.
                int append = 1;

                while (File.Exists($"Screenshot{append}.png"))
                    append++;

                string fileName = $"Screenshot{append}.png";
                screenshot.Save(fileName, ImageFormat.Png);
            }
        }
    }
}
