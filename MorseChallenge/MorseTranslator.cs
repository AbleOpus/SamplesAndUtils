using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MorseChallenge
{
    /// <summary>
    /// Translates more code to and from English.
    /// </summary>
    static class MorseTranslator
    {
        private static readonly Dictionary<char, string> codes = new Dictionary<char, string>();

        static MorseTranslator()
        {
            codes.Add('a', ".-");
            codes.Add('b', "-...");
            codes.Add('c', "-.-.");
            codes.Add('d', "-..");
            codes.Add('e', ".");
            codes.Add('f', "..-.");
            codes.Add('g', "--.");
            codes.Add('h', "....");
            codes.Add('i', "..");
            codes.Add('j', ".---");
            codes.Add('k', "-.-");
            codes.Add('l', ".-..");
            codes.Add('m', "--");
            codes.Add('n', "-.");
            codes.Add('o', "---");
            codes.Add('p', ".--.");
            codes.Add('q', "--.-");
            codes.Add('r', ".-.");
            codes.Add('s', "...");
            codes.Add('t', "-");
            codes.Add('u', "..-");
            codes.Add('v', "...-");
            codes.Add('w', ".--");
            codes.Add('x', "-..-");
            codes.Add('y', "-.--");
            codes.Add('z', "--..");
            codes.Add('1', ".----");
            codes.Add('2', "..---");
            codes.Add('3', "...--");
            codes.Add('4', "....-");
            codes.Add('5', ".....");
            codes.Add('6', "-....");
            codes.Add('7', "--...");
            codes.Add('8', "---..");
            codes.Add('9', "----.");
            codes.Add('0', "-----");
        }

        public static string EnglishToMorse(string text, bool useBullet)
        {
            StringBuilder SB = new StringBuilder();
            text = text.ToLower(); // Case insensitive

            foreach (char c in text)
            {
                string temp;
                bool success = codes.TryGetValue(c, out temp);

                if (success)
                {
                    SB.Append(temp);

                    if (c == ' ')
                        SB.Append("      "); // Six spaces

                    SB.Append(' ');
                }
            }

            string result = SB.ToString();
            return useBullet ? result.Replace('.', '•') : result;
        }
    }
}
