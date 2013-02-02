namespace PokerDashboard.Repository
{
    using System;
    using System.Collections.Generic;

    using PokerDashboard.Models;

    /// <summary>
    /// Performes CRUD operations for <see cref="Player"/> model.
    /// </summary>
    public class PlayerRepository : IPlayerRepository
    {
        /// <summary>
        /// Gets a player by the specified ID.
        /// </summary>
        /// <param name="playerId">The player id.</param>
        /// <returns>The <see cref="Player"/> instance.</returns>
        public Player Get(int playerId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the list of players by the specified IDs.
        /// </summary>
        /// <param name="playerIds">The IDs of players to get.</param>
        /// <returns>The <see cref="List{Player}"/>.</returns>
        public List<Player> Get(IEnumerable<int> playerIds)
        {
            throw new NotImplementedException();
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
        }


        /// <summary>
        /// Creates the specified player in the data context.
        /// </summary>
        /// <param name="player">The player to create.</param>
        /// <returns>The created <see cref="Player"/> instance.</returns>
        private Player CreatePlayer(Player player)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Updates the specified player in the data context.
        /// </summary>
        /// <param name="player">The player to update.</param>
        /// <returns>The updated <see cref="Player"/> instance.</returns>
        private Player UpdatePlayer(Player player)
        {
            throw new System.NotImplementedException();
        }
    }
}