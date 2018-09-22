using System;
using System.Linq;
using Olbrasoft.Data.Query;

namespace Olbrasoft.Data
{
    public interface IQueryWithSorting<T, TResult> : IQuery<TResult>
    {
        /// <summary>
        /// Gets a sort criteria applied on this query.
        /// </summary>
        Func<IQueryable<T>, IOrderedQueryable<T>> Sorting { get; set; }
    }
}