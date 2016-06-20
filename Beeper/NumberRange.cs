namespace Beeper
{
    struct NumberRange
    {
        public int From { get; private set; }

        public int To { get; private set; }

        public NumberRange(int from, int to) : this()
        {
            From = from;
            To = to;
        }
    }
}
