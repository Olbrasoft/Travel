namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public abstract class GeographyRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        protected new IGeographyContext Context { get; }

        protected GeographyRepository(Entity.GeographyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}