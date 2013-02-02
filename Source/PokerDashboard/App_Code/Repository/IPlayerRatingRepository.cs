namespace PokerDashboard.Repository
{
    using System.Collections.Generic;

    using PokerDashboard.Models;

    /// <summary>
    /// Describes the repository for <see cref="PlayerRating"/> model.
    /// </summary>
    public interface IPlayerRatingRepository
    {
        /// <summary>
        /// Gets all the player ratings.
        /// </summary>
        /// <returns>The <see cref="List{PlayerRating}"/>.</returns>
        List<PlayerRating> Get();
    }
}