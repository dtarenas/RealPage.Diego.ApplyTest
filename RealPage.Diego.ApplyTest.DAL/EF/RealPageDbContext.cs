#nullable disable

namespace RealPage.Diego.ApplyTest.DAL.EF
{
    using Microsoft.EntityFrameworkCore;
    using RealPage.Diego.ApplyTest.BL.Utils;
    using RealPage.Diego.ApplyTest.Core.Models;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Real Page Db Context
    /// </summary>
    /// <seealso cref="Microsoft.EntityFrameworkCore.DbContext" />
    public partial class RealPageDbContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RealPageDbContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public RealPageDbContext(DbContextOptions<RealPageDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Gets or sets the users.
        /// </summary>
        /// <value>
        /// The users.
        /// </value>
        public virtual DbSet<User> Users { get; set; }

        /// <summary>
        /// Override this method to further configure the model that was discovered by convention from the entity types
        /// exposed in <see cref="T:Microsoft.EntityFrameworkCore.DbSet`1" /> properties on your derived context. The resulting model may be cached
        /// and re-used for subsequent instances of your derived context.
        /// </summary>
        /// <param name="modelBuilder">The builder being used to construct the model for this context. Databases (and other extensions) typically
        /// define extension methods on this object that allow you to configure aspects of the model that are specific
        /// to a given database.</param>
        /// <remarks>
        /// If a model is explicitly set on the options for this context (via <see cref="M:Microsoft.EntityFrameworkCore.DbContextOptionsBuilder.UseModel(Microsoft.EntityFrameworkCore.Metadata.IModel)" />)
        /// then this method will not be run.
        /// </remarks>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.FirstName).IsUnicode(false);

                entity.Property(e => e.LastName).IsUnicode(false);

                entity.Property(e => e.Password).IsUnicode(false);

                entity.Property(e => e.RecordStatus).HasDefaultValueSql("((1))");

                entity.Property(e => e.Role).HasDefaultValueSql("((2))");

                entity.Property(e => e.UserName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        /// <summary>
        /// <para>
        /// Saves all changes made in this context to the database.
        /// </para>
        /// <para>
        /// This method will automatically call <see cref="M:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.DetectChanges" /> to discover any
        /// changes to entity instances before saving to the underlying database. This can be disabled via
        /// <see cref="P:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.AutoDetectChangesEnabled" />.
        /// </para>
        /// <para>
        /// Multiple active operations on the same context instance are not supported.  Use 'await' to ensure
        /// that any asynchronous operations have completed before calling another method on this context.
        /// </para>
        /// </summary>
        /// <param name="acceptAllChangesOnSuccess">Indicates whether <see cref="M:Microsoft.EntityFrameworkCore.ChangeTracking.ChangeTracker.AcceptAllChanges" /> is called after the changes have
        /// been sent successfully to the database.</param>
        /// <param name="cancellationToken">A <see cref="T:System.Threading.CancellationToken" /> to observe while waiting for the task to complete.</param>
        /// <returns>
        /// A task that represents the asynchronous save operation. The task result contains the
        /// number of state entries written to the database.
        /// </returns>
        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            this.CreateLog();
            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        /// <summary>
        /// Sets the auditory.
        /// </summary>
        private void CreateLog()
        {
            var modified = ChangeTracker.Entries()
                                        .Where(x => x.State == EntityState.Added
                                                 || x.State == EntityState.Modified
                                                 || x.State == EntityState.Deleted);

            foreach (var item in modified)
            {
                LogHelper.Add(item);
            }
        }
    }
}