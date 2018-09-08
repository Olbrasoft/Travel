using Olbrasoft.Pagination;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace Olbrasoft.Data
{
    public abstract class BaseQuery<T,TResult> : IQuery, IQuery<T,TResult>
    {
       
        public IPageInfo Paging { get; set; }

        /// <summary>
        ///     Gets a list of sort criteria applied on this query.
        /// </summary>
        public IList<Func<IQueryable<T>, IOrderedQueryable<T>>> Sorting { get; }

        protected BaseQuery()
        {
            Sorting = new List<Func<IQueryable<T>, IOrderedQueryable<T>>>();
        }

        private void AddSortingCore<TKey>(Expression<Func<T, TKey>> sortExpression, SortDirection direction)
        {
            if (direction == SortDirection.Ascending)
                Sorting.Add(x => x.OrderBy(sortExpression));
            else
                Sorting.Add(x => x.OrderByDescending(sortExpression));
        }

        /// <summary>
        ///     Adds a specified sort criteria to the query.
        /// </summary>
        public void AddSorting(string fieldName, SortDirection direction = SortDirection.Ascending)
        {
            // create the expression
            var prop = typeof(T).GetTypeInfo().GetProperty(fieldName);
            var param = Expression.Parameter(typeof(T), "i");
            var expr = Expression.Lambda(Expression.Property(param, prop), param);

            // call the method
            typeof(BaseQuery<T,TResult>).GetTypeInfo().GetMethod(nameof(AddSortingCore),
                    BindingFlags.Instance | BindingFlags.NonPublic).MakeGenericMethod(prop.PropertyType)
                .Invoke(this, new object[] { expr, direction });
        }

        public void AddSorting<TKey>(Expression<Func<T, TKey>> field, SortDirection direction = SortDirection.Ascending)
        {
            AddSortingCore(field, direction);
        }



        public void ClearSorting()
        {
            Sorting.Clear();
        }
    }
}