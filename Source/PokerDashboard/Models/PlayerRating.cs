namespace PokerDashboard.Models
{
    /// <summary>
    /// The view-model for player rating view.
    /// </summary>
    public class PlayerRating
    {
        public string Name { get; set; }

        public int Rank { get; set; }

        public int Balance { get; set; }

        public int GamesPlayed { get; set; }

        public int GamesFirstPlace { get; set; }

        public int GamesSecondPlace { get; set; }

        public int GamesThirdPlace { get; set; }
    }
}