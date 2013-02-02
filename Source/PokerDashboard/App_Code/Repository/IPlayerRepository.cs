namespace PokerDashboard.Repository
{
    using System.Collections.Generic;

    using PokerDashboard.Models;

    /// <summary>
    /// Describes the repository for <see cref="Player"/> model.
    /// </summary>
    public interface IPlayerRepository
    {
        /// <summary>
        /// Gets a player by the specified ID.
        /// </summary>
        /// <param name="playerId">The player id.</param>
        /// <returns>The <see cref="Player"/> instance.</returns>
        Player Get(int playerId);

        /// <summary>
        /// Gets the list of players by the specified IDs.
        /// </summary>
        /// <param name="playerIds">The IDs of players to get.</param>
        /// <returns>The <see cref="List{Player}"/>.</returns>
        List<Player> Get(IEnumerable<int> playerIds);

        /// <summary>
        /// Creates or updates the specified player in the data context.
        /// </summary>
        /// <param name="player">The player to create or update.</param>
        /// <returns>The created or updated <see cref="Player"/> instance.</returns>
        Player Save(Player player);

        /// <summary>
        /// Removes the specified player from the data context.
        /// </summary>
        /// <param name="player">The player to remove.</param>
        void Remove(Player player);
    }
}