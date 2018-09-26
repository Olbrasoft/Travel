using Olbrasoft.Travel.Data.Entities;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity
{
    public class QueryableOwner<T> : IHaveQueryable<T> where T : class
    {
        public QueryableOwner(ITravelContext context)
        {
            Queryable = context.Set<T>();
        }

        public IQueryable<T> Queryable { get; }
    }
}