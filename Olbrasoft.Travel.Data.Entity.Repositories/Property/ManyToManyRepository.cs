using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Entity.Repositories.Property
{
    public class ManyToManyRepository<TEntity> : OfManyToMany<TEntity>, Repository.Property.IManyToManyRepository<TEntity> where TEntity : ManyToMany 
    {
        protected new IPropertyContext Context { get; }

        public ManyToManyRepository(PropertyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}