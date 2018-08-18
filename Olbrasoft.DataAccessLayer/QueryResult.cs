using System;
using System.Collections.Generic;
using System.Linq;

namespace Olbrasoft.DataAccessLayer
{
    public class QueryResult<T> : IQueryResult<T>
    {
        public IEnumerable<T> Items { get; }

        public int TotalNumberOfItemsWithoutPaging { get; }

        public QueryResult(IEnumerable<T> someItems, int totalNumberOfItemsWithoutPaging)
        {
            var someItemsArray = someItems as T[] ?? someItems.ToArray();
            if (someItemsArray.Length > totalNumberOfItemsWithoutPaging) throw new ArgumentOutOfRangeException(nameof(totalNumberOfItemsWithoutPaging));
            Items = someItemsArray;
            TotalNumberOfItemsWithoutPaging = totalNumberOfItemsWithoutPaging;
        }

    }
}