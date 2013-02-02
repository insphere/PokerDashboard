using System.Collections.Generic;

namespace PokerDashboard.Repository
{
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
            return new List<PlayerRating>();
        }
    }
}