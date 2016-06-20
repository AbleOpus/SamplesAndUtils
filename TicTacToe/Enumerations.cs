namespace TicTacToe
{
    /// <summary>
    /// Specifies the tic-tac-toe team.
    /// </summary>
    public enum Team
    {
        /// <summary>
        /// The team has been undetermined.
        /// </summary>
        Undetermined,
        /// <summary>
        /// The team is X.
        /// </summary>
        X,
        /// <summary>
        /// The team is O.
        /// </summary>
        O
    }

    /// <summary>
    /// Specifes the opponent move mode. How the opponent behaves.
    /// </summary>
    public enum OpponentMoveMode
    {
        /// <summary>
        /// The opponent will make moves without logic.
        /// </summary>
        Random,
        /// <summary>
        /// The opponent will make logical moves.
        /// </summary>
        Logical
    }
}
