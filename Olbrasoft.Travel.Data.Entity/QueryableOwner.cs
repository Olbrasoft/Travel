
using System.Linq;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entity.Model;

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