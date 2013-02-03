using System.Collections.Generic;
using System.Linq;
using PokerDashboard.Data;
using PokerDashboard.Models;

namespace PokerDashboard.Repository
{
    /// <summary>
    /// Performs CRUD operations for <see cref="GameEntry"/> view model.
    /// </summary>
    public class GameEntryRepository : IViewModelRepository<GameEntry>
    {
        /// <summary>
        /// Gets all the player ratings.
        /// </summary>
        /// <returns>The <see cref="List{PlayerRating}"/>.</returns>
        public List<GameEntry> Get()
        {
            using (PokerDashboardDB context = PokerDashboardDB.Create())
            {
                return
                   (from player in context.Players
                    join gamePlayer in context.GamePlayers on player.Id equals gamePlayer.PlayerId
                    join game in context.Games on gamePlayer.GameId equals game.Id
                    group game by
                        new
                        {
                            Game = game,
                            PlayerCount = game.GamePlayers.Count()
                        }
                        into games
                        orderby games.Key.Game.Date descending
                        select games).AsEnumerable()
                    .Select(game =>
                            new GameEntry
                            {
                                Id = (int)game.Key.Game.Id,
                                Date = game.Key.Game.Date,
                                PlayerCount = game.Key.PlayerCount,
                                WinnerHand = game.Key.Game.WinnerHand,
                                WinnerId = (int)game.Key.Game.GamePlayers.FirstOrDefault(gp => gp.Rank == 1).PlayerId,
                                WinnerName = game.Key.Game.GamePlayers.FirstOrDefault(gp => gp.Rank == 1).Player.Name
                            }).ToList();
            }
        }
    }
}