namespace PokerDashboard.Repository
{
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    using PokerDashboard.Data;

    using Player = PokerDashboard.Models.Player;

    /// <summary>
    /// Performs CRUD operations for <see cref="Models.Player"/> model.
    /// </summary>
    public class PlayerRepository : IModelRepository<Player>
    {
        /// <summary>
        /// The message format for player not found error.
        /// </summary>
        private const string PlayerNotFoundMessageFormat = "Player with ID '{0}' doesn't exist";

        /// <summary>
        /// Gets a player by the specified ID.
        /// </summary>
        /// <param name="playerId">The player id.</param>
        /// <returns>The <see cref="Player"/> instance.</returns>
        public Player Get(int playerId)
        {
            using (PokerDashboardDB context = PokerDashboardDB.Create())
            {
                Data.Player player = context.Players.SingleOrDefault(p => p.Id == playerId);

                if (player == null)
                {
                    throw new ObjectNotFoundException(string.Format(PlayerNotFoundMessageFormat, playerId));
                }

                return new Player
                           {
                               Email = player.Email,
                               Id = (int)player.Id,
                               Name = player.Name,
                               WindowsLogin = player.WindowsLogin
                           };
            }
        }

        /// <summary>
        /// Gets the list of players by the specified IDs.
        /// </summary>
        /// <param name="playerIds">The IDs of players to get.</param>
        /// <returns>The <see cref="List{Player}"/>.</returns>
        public List<Player> Get(IEnumerable<int> playerIds)
        {
            using (PokerDashboardDB context = PokerDashboardDB.Create())
            {
                List<Data.Player> players = 
                    context.Players.Where(p => playerIds.Contains((int)p.Id)).ToList();

                if (!players.Any())
                {
                    throw new ObjectNotFoundException("No players were found.");
                }

                return players.Select(player => new Player
                {
                    Email = player.Email,
                    Id = (int)player.Id,
                    Name = player.Name,
                    WindowsLogin = player.WindowsLogin
                }).ToList();
            }
        }

        /// <summary>
        /// Creates or updates the specified player in the data context.
        /// </summary>
        /// <param name="player">The player to create or update.</param>
        /// <returns>The created or updated <see cref="Player"/> instance.</returns>
        public Player Save(Player player)
        {
            return player.Id.HasValue 
                ? this.UpdatePlayer(player) 
                : this.CreatePlayer(player);
        }

        /// <summary>
        /// Removes the specified player from the data context.
        /// </summary>
        /// <param name="player">The player to remove.</param>
        public void Remove(Player player)
        {
            using (PokerDashboardDB context = PokerDashboardDB.Create())
            {
                Data.Player dataPlayer = context.Players.SingleOrDefault(p => p.Id == player.Id);

                if (dataPlayer == null)
                {
                    throw new ObjectNotFoundException(string.Format(PlayerNotFoundMessageFormat, player.Id));
                }

                context.Players.Remove(dataPlayer);
                context.SaveChanges();
            }
        }

        /// <summary>
        /// Creates the specified player in the data context.
        /// </summary>
        /// <param name="player">The player to create.</param>
        /// <returns>The created <see cref="Player"/> instance.</returns>
        private Player CreatePlayer(Player player)
        {
            using (PokerDashboardDB context = PokerDashboardDB.Create())
            {
                Data.Player dataPlayer = context.Players.Create();
                dataPlayer.Email = player.Email;
                dataPlayer.Name = player.Name;
                dataPlayer.WindowsLogin = player.WindowsLogin;

                context.Players.Add(dataPlayer);
                context.SaveChanges();

                player.Id = (int)dataPlayer.Id;
                return player;
            }
        }

        /// <summary>
        /// Updates the specified player in the data context.
        /// </summary>
        /// <param name="player">The player to update.</param>
        /// <returns>The updated <see cref="Player"/> instance.</returns>
        private Player UpdatePlayer(Player player)
        {
            using (PokerDashboardDB context = PokerDashboardDB.Create())
            {
                Data.Player dataPlayer = context.Players.SingleOrDefault(p => p.Id == player.Id);

                if (dataPlayer == null)
                {
                    throw new ObjectNotFoundException(string.Format(PlayerNotFoundMessageFormat, player.Id));
                }

                dataPlayer.Email = player.Email;
                dataPlayer.Name = player.Name;
                dataPlayer.WindowsLogin = player.WindowsLogin;

                context.SaveChanges();
                return player;
            }
        }
    }
}