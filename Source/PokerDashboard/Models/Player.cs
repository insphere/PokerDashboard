namespace PokerDashboard.Models
{
    /// <summary>
    /// Describes a poker player.
    /// </summary>
    public class Player
    {
        #region Public Properties

        /// <summary>
        /// Gets or sets the player email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the player ID.
        /// </summary>
        public int? Id { get; set; }

        /// <summary>
        /// Gets or sets the player name.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the player windows login.
        /// </summary>
        public string WindowsLogin { get; set; }

        #endregion
    }
}