using System.Collections.Generic;
using PokerDashboard.Models;

namespace PokerDashboard.Repository
{
    /// <summary>
    /// Performes CRUD operations for <see cref="Game"/> model.
    /// </summary>
    public class GameRepository : IModelRepository<Game>
    {
        /// <summary>
        /// Gets a game by the specified ID.
        /// </summary>
        /// <param name="gameId">The game id.</param>
        /// <returns>The <see cref="Game"/> instance.</returns>
        public Game Get(int gameId)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Gets the list of games by the specified IDs.
        /// </summary>
        /// <param name="gameIds">The IDs of games to get.</param>
        /// <returns>The <see cref="List{Game}"/>.</returns>
        public List<Game> Get(IEnumerable<int> gameIds)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Creates or updates the specified game in the data context.
        /// </summary>
        /// <param name="game">The game to create or update.</param>
        /// <returns>The game or updated <see cref="Game"/> instance.</returns>
        public Game Save(Game game)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// Removes the specified game from the data context.
        /// </summary>
        /// <param name="game">The game to remove.</param>
        public void Remove(Game game)
        {
            throw new System.NotImplementedException();
        }
    }
}