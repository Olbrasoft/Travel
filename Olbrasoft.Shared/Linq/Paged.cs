using System.Collections.Generic;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Shared.Linq
{
    public static class Paged
    {
        /// <summary>Returns the input typed as <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
        /// <param name="source">The sequence to type as <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The input sequence typed as <see cref="T:System.Collections.Generic.IEnumerable`1" />.</returns>
        public static IPagedEnumerable<TSource> AsPagedEnumerable<TSource>(this IEnumerable<TSource> source)
        {
            return new PagedEnumerable<TSource>(source);
        }
        
        public static IPagedEnumerable<TSource> AsPagedEnumerable<TSource>(this IEnumerable<TSource> source,
            IPagination pagination) => new PagedEnumerable<TSource>(source, pagination);


        public static IPagedList<TSource> AsPagedList<TSource>(this IPagedEnumerable<TSource> source)
        {
            return new PagedList<TSource>(source, source.Pagination.PageInfo,
                source.Pagination.CountWithOutPaging());
        }

    }
}
