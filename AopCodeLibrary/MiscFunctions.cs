using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace AboCodeLibrary
{
    static class MiscFunctions
    {
        /// <summary>
        /// Gets a int array with a randomized number array
        /// </summary>
        public static int[] GetRandomNumberArray(int length, int min, int max)
        {
            if (max - min <= length)
            {
                const string MSG = "Not enough numbers in the range to encompass array length.";
                throw new ArgumentOutOfRangeException(nameof(length), MSG);
            }

            int[] intArray = new int[length];

            for (int i = 0; i < length; i++)
            {
                Random random = new Random(i);

                while (true)
                {
                    int randomNum = random.Next(min, max);

                    if (!intArray.Contains(randomNum))
                    {
                        intArray[i] = randomNum;
                        break;
                    }
                }
            }

            return intArray;
        }

        public static void CreateShortcut(string saveLocation, string targetPath, string description)
        {
            WshShellClass wshShell = new WshShellClass();
            object tempObj = wshShell.CreateShortcut(saveLocation);
            IWshShortcut shortcut = (IWshShortcut)tempObj;
            shortcut.TargetPath = targetPath;
            shortcut.Description = description;
            shortcut.Save();
        }

        public static Rectangle GetScreenRectsCombined()
        {
            Rectangle rect = new Rectangle();

            foreach (Screen screen in Screen.AllScreens)
            {
                rect = Rectangle.Union(rect, screen.Bounds);
            }

            return rect;
        }

        /// <summary>
        /// Deletes all top-level files in a specified directory.
        /// </summary>
        /// <exception cref="System.Security.SecurityException"></exception>
        /// <exception cref="System.UnauthorizedAccessException"></exception>
        /// <exception cref="System.IO.DirectoryNotFoundException"></exception>
        /// <exception cref="System.IO.IOException"></exception>
        public static void ClearDirectory(string directory)
        {
                DirectoryInfo dirInfo = new DirectoryInfo(directory);
                FileInfo[] fileInfo = dirInfo.GetFiles();

                foreach (FileInfo file in fileInfo)
                {
                    file.Delete();
                }
        }

        private static void IterateDirectory(string directory)
        {
            IEnumerable<string> subDirs = Directory.EnumerateDirectories(directory);
            var enumerator = subDirs.GetEnumerator();

            while (enumerator.MoveNext())
            {
                IterateDirectory(enumerator.Current);
            }
        }

        /// <summary>
        /// Gets how many syllables are in a word.
        /// </summary>
        public static int GetSylableCount(string word)
        {
            char[] letters = word.ToLower().ToCharArray();
            int count = 0;

            //Loop through characters and check for vowels.
            for (int i = 0; i < letters.Length; i++)
            {
                if (!letters[i].IsVowel() && i != 0 && letters[i - 1].IsVowel())
                    count++;
            }

            if (letters[letters.Length - 1].IsVowel()) count++;
            if (letters[letters.Length - 1] == 'y') count++;
            // A word has at least one syllable.
            if (count == 0) count = 1;
            return count;
        }
    }
}
