using System.Windows.Forms;

namespace MorseCodeRain
{
    struct MorseCode
    {
        /// <summary>
        /// Represents the an empty MorseCode instance with a null char, no code and no keys.
        /// </summary>
        public static readonly MorseCode Empty = new MorseCode('\0', Keys.None, string.Empty); 

        /// <summary>
        /// Gets the morse code sequence.
        /// </summary>
        public string Code { get; private set; }

        /// <summary>
        /// Gets the letter or number.
        /// </summary>
        public char Character { get; private set; }

        /// <summary>
        /// Get the key that corresponds to the character.
        /// </summary>
        public Keys Key { get; private set; }

        public MorseCode(Keys key, string code)
            : this()
        {
            Code = code;
            Character = key.ToString()[0];
            Key = key;
        }

        public MorseCode(char c, Keys key, string code)
            : this()
        {
            Code = code;
            Character = c;
            Key = key;
        }
    }
}