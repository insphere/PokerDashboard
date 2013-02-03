﻿using System;

namespace PokerDashboard.Models
{
    /// <summary>
    /// Describes a single entry on the game history list.
    /// </summary>
    public class GameEntry
    {
        /// <summary>
        /// The date when the game happened.
        /// </summary>
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