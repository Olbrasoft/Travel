using System.Linq;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface IHaveQueryable<out T>
    {
        IQueryable<T> Queryable { get; }
    }
}