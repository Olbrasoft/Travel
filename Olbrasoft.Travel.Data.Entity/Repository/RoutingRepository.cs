namespace Olbrasoft.Travel.Data.Entity.Repository
{
    public abstract class RoutingRepository<TEntity>: BaseRepository<TEntity> where TEntity : class
    {
        protected new IRoutingContext Context { get; }

        protected RoutingRepository(RoutingDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}