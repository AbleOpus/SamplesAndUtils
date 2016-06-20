namespace ABitOfMemory
{
    static class ExtensionMethods
    {
        /// <summary>
        /// Gets whether the number is odd.
        /// </summary>
        public static bool IsOdd(this int num)
        {
            return (num % 2 != 0);
        }
    }
}
