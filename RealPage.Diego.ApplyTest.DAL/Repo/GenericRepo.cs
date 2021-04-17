namespace RealPage.Diego.ApplyTest.DAL.Repo
{
    using Microsoft.EntityFrameworkCore;
    using RealPage.Diego.ApplyTest.Core.Models.Base;
    using RealPage.Diego.ApplyTest.DAL.EF;
    using RealPage.Diego.ApplyTest.DAL.Repo.Facades;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    /// <summary>
    /// Generic Repo
    /// </summary>
    /// <typeparam name="TEntity">The type of the entity.</typeparam>
    /// <seealso cref="RealPage.Diego.ApplyTest.DAL.Repo.Facades.IGenericRepo{TEntity}" />
    public class GenericRepo<TEntity> : IGenericRepo<TEntity> where TEntity : BaseEntity
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly RealPageDbContext _context;

        /// <summary>
        /// The database set
        /// </summary>
        public readonly DbSet<TEntity> DbSet;

        /// <summary>
        /// Initializes a new instance of the <see cref="BaseRepo{TEntity}" /> class.
        /// </summary>
        /// <param name="context">The context.</param>
        public GenericRepo(RealPageDbContext context)
        {
            this._context = context;
            this.DbSet = this._context.Set<TEntity>();
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns>
        /// Task
        /// </returns>
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            await this.DbSet.AddAsync(entity);
            return entity;
        }

        /// <summary>
        /// Adds the asynchronous.
        /// </summary>
        /// <param name="entities">The entities.</param>
        /// <returns>
        /// Task
        /// </returns>
        public async Task<IEnumerable<TEntity>> AddAsync(IEnumerable<TEntity> entities)
        {
            await this.DbSet.AddRangeAsync(entities);
            return entities;
        }

        /// <summary>
        /// Deletes the specified entities.
        /// </summary>
        /// <param name="entities">The entities.</param>
        public void Delete(IEnumerable<TEntity> entities)
        {
            this._context.RemoveRange(entities);
        }

        /// <summary>
        /// Deletes the asynchronous.
        /// </summary>
        /// <param name="id">The identifier.</param>
        public async Task DeleteAsync(int id)
        {
            var entity = await this.DbSet.FindAsync(id);
            this._context.Remove(entity);
        }

        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns>
        /// Entity Queryable
        /// </returns>
        public IQueryable<TEntity> Get()
        {
            return this.DbSet.AsQueryable();
        }

        /// <summary>
        /// Saves the changes.
        /// </summary>
        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        /// <summary>
        /// Saves the changes asynchronous.
        /// </summary>
        public async Task SaveChangesAsync()
        {
            await this._context.SaveChangesAsync();
        }

        /// <summary>
        /// Updates the specified author.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <returns></returns>
        public TEntity Update(TEntity entity)
        {
            this.DbSet.Attach(entity);
            this._context.Update(entity);
            return entity;
        }
    }
}
