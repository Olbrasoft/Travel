using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Repository.Property;

namespace Olbrasoft.Travel.Data.Entity.Repository.Property
{
    public class ManyToManyRepository<TEntity> : OfManyToMany<TEntity>,  IManyToManyRepository<TEntity> where TEntity : ManyToMany 
    {
        protected new IPropertyContext Context { get; }

        public ManyToManyRepository(PropertyDatabaseContext context) : base(context)
        {
            Context = context;
        }
    }
}