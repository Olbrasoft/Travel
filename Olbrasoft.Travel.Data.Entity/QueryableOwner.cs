using Olbrasoft.Data;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity
{
    public abstract class QueryableOwner<TEntity> : IHaveQueryable<TEntity> where TEntity : class
    {


        protected QueryableOwner(ITravelContext context)
        {
            Queryable = context.Set<TEntity>();
        }

        public IQueryable<TEntity> Queryable { get; }
    }
}