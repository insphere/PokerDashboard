using System.Collections.Generic;
using PokerDashboard.Models;

namespace PokerDashboard.Repository
{
    /// <summary>
    ///     Describes the repository for a model.
    /// </summary>
    public interface IModelRepository<T>
    {
        /// <summary>
        ///     Gets a model by the specified ID.
        /// </summary>
        /// <param name="modelId">The model id.</param>
        /// <returns>
        ///     The <see cref="Player" /> instance.
        /// </returns>
        T Get(int modelId);

        /// <summary>
        ///     Gets the list of models by the specified IDs.
        /// </summary>
        /// <param name="modelIds">The IDs of models to get.</param>
        /// <returns>The list of models.</returns>
        List<T> Get(IEnumerable<int> modelIds);

        /// <summary>
        ///     Creates or updates the specified model in the data context.
        /// </summary>
        /// <param name="player">The model to create or update.</param>
        /// <returns>The created or updated model instance.</returns>
        T Save(T player);

        /// <summary>
        ///     Removes the specified model from the data context.
        /// </summary>
        /// <param name="player">The model to remove.</param>
        void Remove(T player);
    }
}