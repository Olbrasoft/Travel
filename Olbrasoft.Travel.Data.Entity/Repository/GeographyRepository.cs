namespace Olbrasoft.Travel.Data.Entity.Repository
{
    public abstract class GeographyRepository<TEntity> : BaseRepository<TEntity> where TEntity : class
    {
        protected new IGeographyContext Context { get; }

        protected GeographyRepository(GeographyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}