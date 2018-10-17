using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Repository.Geography;

namespace Olbrasoft.Travel.Data.Entity.Repositories.Geography
{
    public class ManyToManyRepository<TEntity> : OfManyToMany<TEntity>, IManyToManyRepository<TEntity> where TEntity : ManyToMany
    {
        protected new IGeographyContext Context { get; }

        public ManyToManyRepository(Entity.GeographyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}