using System.Linq;

namespace AboCodeLibrary
{
    static class StringOps
    {
        public static string TrimNumbersFromStart(this string s)
        {
            while (char.IsNumber(s[0]))
                s = s.Remove(0, 1);

            return s;
        }

        /// <summary>
        /// Expands the body string at the start and end with specified text.
        /// </summary>
        public static string ExpandString(this string body, string leftInsert, string rightInsert)
        {
            body = body.Insert(0, leftInsert);
            body = body.Insert(body.Length, rightInsert);

            return body;
        }

        /// <summary>
        /// Trims a certain amount of characters off the start and end of the string.
        /// </summary>
        public static string TrimStringApex(this string input, int amountToTrim)
        {
            if (input.Length - amountToTrim * 2 >= 0)
            {
                input = input.Remove(0, amountToTrim);
                input = input.Remove(input.Length - amountToTrim, amountToTrim);
            }
            else
            {
                input = string.Empty;
            }

            return input;
        }

        /// <summary>
        /// Same thing as contains, just with multiple search instances.
        /// </summary>
        public static bool HasStringInstance(string lookIn, string[] instances, bool matchCase)
        {
            foreach (string s in instances)
            {
                lookIn = (matchCase) ? lookIn : lookIn.ToLower();
                if (lookIn.Contains(s)) return true;
            }

            return false;
        }

        /// <summary>
        /// Removes all letters from the passed in string.
        /// </summary>
        public static string IsolateNumbers(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                while (i < s.Length && i >= 0 && !char.IsNumber(s[i]))
                {
                    s = s.Remove(i, 1);
                }
            }

            return s;
        }

        /// <summary>
        /// Removes all numbers from the passed in string.
        /// </summary>
        public static string IsolateLetters(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                while (i < s.Length && i >= 0 && !char.IsLetter(s[i]))
                {
                    s = s.Remove(i, 1);
                }
            }

            return s;
        }

        /// <summary>
        /// Removes all non number and letter characters from the passed in string.
        /// </summary>
        public static string IsolateAlphanumerics(this string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                while (i < s.Length && i >= 0 && !char.IsLetter(s[i]) && !char.IsNumber(s[i]))
                {
                    s = s.Remove(i, 1);
                }
            }

            return s;
        }

        /// <summary>
        /// Determines whether or not the string has an instance of paired curly braces.
        /// </summary>
        public static bool StringHasParenthesis(this string s)
        {
            bool hasOpening = false;
            bool hasClosing = false;

            foreach (char c in s)
            {
                if (c == '(') hasOpening = true;

                // Make sure closing string is after opening
                if (hasOpening)
                {
                    if (c == ')') hasClosing = true;
                }
            }

            return (hasOpening && hasClosing);
        }

        /// <summary>
        /// Finds the first occurrence of content between curly braces
        /// and returns the contents with or without the braces.
        /// </summary>
        public static string IsolateParenthesis(this string s, bool includeBraces)
        {
            int openIndex = -1;
            int endIndex = -1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(') openIndex = i;
                else if (s[i] == ')') endIndex = i;
            }

            if (openIndex > -1 && endIndex > -1 && openIndex < endIndex)
            {
                if (includeBraces)
                {
                    return s.Substring(openIndex, endIndex - openIndex + 1);
                }

                return s.Substring(openIndex + 1, endIndex - openIndex);
            }

            return s;
        }

        /// <summary>
        /// If the string array contains the specified instance, the method returns true.
        /// </summary>
        public static bool ArrayContains(string[] array, string instance)
        {
            return array.Any(s => s.Contains(instance));
        }

        /// <summary>
        /// Gets the number count for the specified string.
        /// </summary>
        public static int NumberCount(this string s)
        {
            return s.Count(char.IsNumber);
        }

        /// <summary>
        /// Gets the letter count for the specified string.
        /// </summary>
        public static int LetterCount(this string s)
        {
            return s.Count(char.IsLetter);
        }

        /// <summary>
        /// If the string consists of all numbers, method returns true, other wise it returns false.
        /// </summary>
        public static bool IsAllNumbers(this string s)
        {
            return s.All(char.IsNumber);
        }

        /// <summary>
        /// If the string consists of all letters, method returns true, other wise it returns false.
        /// </summary>
        public static bool IsAllLetters(this string s)
        {
            return s.All(char.IsLetter);
        }
    }
}
