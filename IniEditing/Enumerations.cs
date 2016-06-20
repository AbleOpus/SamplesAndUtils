namespace IniEditing
{
    /// <summary>
    /// Specifies a single type (like boolean) or something loosely defined.
    /// </summary>
    public enum GeneralType
    {
        /// <summary>
        /// There was no value to process.
        /// </summary>
        Unknown,
        /// <summary>
        /// There were values, non resembled either of the below, so assume a string like type.
        /// </summary>
        Text,
        /// <summary>
        /// A true or false type.
        /// </summary>
        Boolean,
        /// <summary>
        /// Assume a signed integer.
        /// </summary>
        WholeNumber,
        /// <summary>
        /// A number with more than zero decimal places.
        /// </summary>
        PreciseNumber
    }
}
