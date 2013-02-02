namespace PokerDashboard.Models
{
    using System;

    /// <summary>
    /// Describes a poker game.
    /// </summary>
    public class Game
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the buy-in (the game entrance fee).
        /// </summary>
        public int BuyIn { get; set; }

        /// <summary>
        /// Gets or sets the game date.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the game ID.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the cards that a winner had in the last round.
        /// </summary>
        public string WinHand { get; set; }

        #endregion
    }
}