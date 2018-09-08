using Olbrasoft.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Olbrasoft.Data
{
    public interface IQuery
    {
        IPageInfo Paging { set; }

        /// <summary>
        /// Adds a specified sort criteria to the query.
        /// </summary>
        void AddSorting(string fieldName, SortDirection direction = SortDirection.Ascending);

        /// <summary>
        /// Resets the list of sort criteria.
        /// </summary>
        void ClearSorting();
    }

    public interface IQuery<TResult>
    {
    }

    public interface IQuery<T, TResult> : IQuery<TResult>
    {
        /// <summary>
        /// Gets a list of sort criteria applied on this query.
        /// </summary>
        IList<Func<IQueryable<T>, IOrderedQueryable<T>>> Sorting { get; }

        /// <summary>
        /// Adds a specified sort criteria to the query.
        /// </summary>
        void AddSorting<TKey>(Expression<Func<T, TKey>> field, SortDirection direction = SortDirection.Ascending);
    }
}