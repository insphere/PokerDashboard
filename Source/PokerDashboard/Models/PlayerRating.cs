namespace PokerDashboard.Models
{
    using System.ComponentModel;

    /// <summary>
    /// The view-model for player rating view.
    /// </summary>
    public class PlayerRating
    {
        public int Id { get; set; }
        
        public string Name { get; set; }

        public int Rank { get; set; }

        public int Balance { get; set; }

        [DisplayName("Games Played")]
        public int GamesPlayed { get; set; }

        [DisplayName("1st Places")]
        public int GamesFirstPlace { get; set; }

        [DisplayName("2nd Places")]
        public int GamesSecondPlace { get; set; }

        [DisplayName("3rd Places")]
        public int GamesThirdPlace { get; set; }
    }
}