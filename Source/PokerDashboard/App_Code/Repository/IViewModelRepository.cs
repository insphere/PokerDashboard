namespace PokerDashboard.Repository
{
    using System.Collections.Generic;

    /// <summary>
    /// Describes the repository for view model.
    /// </summary>
    public interface IViewModelRepository<T>
    {
        /// <summary>
        /// Gets all the view models.
        /// </summary>
        /// <returns>The list of view models.</returns>
        List<T> Get();
    }
}