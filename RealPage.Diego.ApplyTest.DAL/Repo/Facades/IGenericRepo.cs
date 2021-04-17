namespace RealPage.Diego.ApplyTest.DAL.Repo.Facades
{
    using RealPage.Diego.ApplyTest.Core.Models.Base;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Generic Repo Facade
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    public interface IGenericRepo<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>Entity Queryable</returns>
        IQueryable<TEntity> Get();

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// Task
        /// </returns>
        Task<TEntity> AddAsync(TEntity entity);

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// Task
        /// </returns>
        Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> entities);

        /// <summary>
        /// Updates the specified author.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public TEntity Update(TEntity entity);

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>Task</returns>
        Task DeleteAsync(int id);

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void Delete(IEnumerable<TEntity> entities);

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        public Task SaveChangesAsync();

        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges();
    }
}
