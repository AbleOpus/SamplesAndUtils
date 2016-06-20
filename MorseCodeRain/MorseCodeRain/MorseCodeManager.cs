using System;
using System.Linq;
using System.Windows.Forms;

namespace MorseCodeRain
{
    public enum MorseCodeType { Any, Number, Letter }

    static class MorseCodeManager
    {
        private static readonly MorseCode[] MorseCodes =
        {
                new MorseCode(Keys.A, "•-"),
                new MorseCode(Keys.B, "-•••"),
                new MorseCode(Keys.C, "-•-•"),
                new MorseCode(Keys.D, "-••"),
                new MorseCode(Keys.E, "•"),
                new MorseCode(Keys.F, "••-•"),
                new MorseCode(Keys.G, "--•"),
                new MorseCode(Keys.H, "••••"),
                new MorseCode(Keys.I, "••"),
                new MorseCode(Keys.J, "•---"),
                new MorseCode(Keys.K, "-•-"),
                new MorseCode(Keys.L, "•-••"),
                new MorseCode(Keys.M, "--"),
                new MorseCode(Keys.N, "-•"),
                new MorseCode(Keys.O, "---"),
                new MorseCode(Keys.P, "•--•"),
                new MorseCode(Keys.Q, "--•-"),
                new MorseCode(Keys.R, "•-•"),
                new MorseCode(Keys.S, "•••"),
                new MorseCode(Keys.T, "-"),
                new MorseCode(Keys.U, "••-"),
                new MorseCode(Keys.V, "•••-"),
                new MorseCode(Keys.W, "•--"),
                new MorseCode(Keys.X, "-••-"),
                new MorseCode(Keys.Y, "-•--"),
                new MorseCode(Keys.Z, "••--"),

                new MorseCode('1', Keys.D1, "•----"),
                new MorseCode('2', Keys.D2, "••---"),
                new MorseCode('3', Keys.D3, "•••--"),
                new MorseCode('4', Keys.D4, "••••-"),
                new MorseCode('5', Keys.D5, "•••••"),
                new MorseCode('6', Keys.D6, "-••••"),
                new MorseCode('7', Keys.D7, "--•••"),
                new MorseCode('8', Keys.D8, "---••"),
                new MorseCode('9', Keys.D9, "----•"),
                new MorseCode('0', Keys.D0, "-----")
        };

        /// <summary>
        /// Gets a MorseCode by its character from the alphanumeric array.
        /// </summary>
        public static MorseCode GetMoreCode(char c)
        {
            foreach (MorseCode code in MorseCodes.Where(code => code.Character.Equals(c)))
            {
                return code;
            }

            return MorseCode.Empty;
        }

        /// <summary>
        /// Gets a MorseCode by its morse from the alphanumeric array.
        /// </summary>
        public static MorseCode GetMoreCode(string morse)
        {
            foreach (MorseCode code in MorseCodes)
            {
                if (code.Code.Equals(morse))
                    return code;
            }

            return MorseCode.Empty;
        }

        /// <summary>
        /// Gets a MorseCode by its key from the alphanumeric array.
        /// </summary>
        public static MorseCode GetMoreCode(Keys key)
        {
            foreach (MorseCode code in MorseCodes)
            {
                if (code.Key.Equals(key))
                    return code;
            }

            return MorseCode.Empty;
        }

        private static MorseCode ToPeriodMorseCode(MorseCode code)
        {
            return new MorseCode(code.Character, code.Key, code.Code.Replace('•', '.'));
        }

        /// <summary>
        /// Gets a random MorseCode from the alphanumeric array.
        /// </summary>
        public static MorseCode GetRandomMorseCode(MorseCodeType morseType, bool useBullets)
        {
            Random random = new Random();

            if (morseType == MorseCodeType.Any)
            {
                int num = random.Next(0, MorseCodes.Length);
                if (useBullets) return MorseCodes[num];
                return ToPeriodMorseCode(MorseCodes[num]);
            }

            if (morseType == MorseCodeType.Number)
            {
                var numberCodes =
                from code in MorseCodes
                where char.IsNumber(code.Character)
                select code;

                int num = random.Next(0, numberCodes.Count());
                if (useBullets) return numberCodes.ElementAt(num);
                return ToPeriodMorseCode(numberCodes.ElementAt(num));
            }
            else
            {
                var letterCodes =
                from code in MorseCodes
                where !char.IsNumber(code.Character)
                select code;

                int num = random.Next(0, letterCodes.Count());
                if (useBullets) return letterCodes.ElementAt(num);
                return ToPeriodMorseCode(letterCodes.ElementAt(num));
            }
        }
    }
}
