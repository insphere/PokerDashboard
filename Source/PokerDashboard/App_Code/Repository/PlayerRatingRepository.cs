using System.Collections.Generic;

namespace PokerDashboard.Repository
{
    using System.Linq;
    using PokerDashboard.Data;
    using PokerDashboard.Models;

    /// <summary>
    /// Performs CRUD operations for <see cref="PlayerRating"/> model.
    /// </summary>
    public class PlayerRatingRepository : IPlayerRatingRepository
    {
        /// <summary>
        /// Gets all the player ratings.
        /// </summary>
        /// <returns>The <see cref="List{PlayerRating}"/>.</returns>
        public List<PlayerRating> Get()
        {
            using (PokerDashboardDB context = new PokerDashboardDB())
            {
                return
                   (from player in context.Players
                    join gamePlayer in context.GamePlayers on player.Id equals gamePlayer.PlayerId
                    join game in context.Games on gamePlayer.GameId equals game.Id
                    group player by 
                        new
                        {
                            player.Id,
                            player.Name,
                            Balance = player.GamePlayers.Sum(gp => gp.Prize) - player.GamePlayers.Sum(gp => gp.Game.BuyInValue),
                            GamesPlayed = player.GamePlayers.Count(),
                            GamesFirstPlace = player.GamePlayers.Count(gp => gp.Rank == 1),
                            GamesSecondPlace = player.GamePlayers.Count(gp => gp.Rank == 2),
                            GamesThirdPlace = player.GamePlayers.Count(gp => gp.Rank == 3)
                        }
                        into ratings
                        orderby ratings.Key.Balance descending
                        select ratings).AsEnumerable()
                    .Select(
                        (rating, index) =>
                            new PlayerRating
                            {
                                Id = (int)rating.Key.Id,
                                Name = rating.Key.Name,
                                GamesPlayed = rating.Key.GamesPlayed,
                                Balance = (int)rating.Key.Balance,
                                GamesFirstPlace = rating.Key.GamesFirstPlace,
                                GamesSecondPlace = rating.Key.GamesSecondPlace,
                                GamesThirdPlace = rating.Key.GamesThirdPlace,
                                Rank = index + 1
                            }).ToList();
            }
        }
    }
}