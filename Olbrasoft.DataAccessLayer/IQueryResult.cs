using System.Collections.Generic;

namespace Olbrasoft.DataAccessLayer
{
    public interface IQueryResult<out T>
    {
        IEnumerable<T> Items { get; }
        int TotalNumberOfItemsWithoutPaging { get; }
    }
}
