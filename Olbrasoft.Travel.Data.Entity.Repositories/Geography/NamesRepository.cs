using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Repository.Geography;

namespace Olbrasoft.Travel.Data.Entity.Repositories.Geography
{
    public class NamesRepository<TEntity> : OfName<TEntity>, INamesRepository<TEntity> where TEntity : CreationInfo<int>, IHaveName
    {
        protected new IGeographyContext Context { get; }

        public NamesRepository(Entity.GeographyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}