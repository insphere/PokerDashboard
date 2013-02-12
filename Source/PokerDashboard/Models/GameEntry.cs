using System;
using System.ComponentModel.DataAnnotations;

namespace PokerDashboard.Models
{
    /// <summary>
    /// Describes a single entry on the game history list.
    /// </summary>
    public class GameEntry
    {
        /// <summary>
        /// Id of the game.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The date when the game happened.
        /// </summary>
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime Date { get; set; }

        /// <summary>
        /// Id of the player who won.
        /// </summary>
        public int WinnerId { get; set; }

        /// <summary>
        /// Name of the player who won.
        /// </summary>
        public string WinnerName { get; set; }

        /// <summary>
        /// Cards the player won with.
        /// </summary>
        public string WinnerHand { get; set; }

        /// <summary>
        /// Number of players in the game.
        /// </summary>
        public int PlayerCount { get; set; }
    }
}