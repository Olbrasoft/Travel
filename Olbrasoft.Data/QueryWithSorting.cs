using Olbrasoft.Pagination;
using System;
using System.Linq;

namespace Olbrasoft.Data
{
    public abstract class QueryWithSorting<T, TResult> : IQueryWithSorting<T, TResult>
    {
        public IPageInfo Paging { get; set; }

        /// <summary>
        ///     Gets a list of sort criteria applied on this query.
        /// </summary>
        public Func<IQueryable<T>, IOrderedQueryable<T>> Sorting { get; set; }

        
    }
}