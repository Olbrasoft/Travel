using System;
using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;


namespace Olbrasoft.Shared.Linq
{
    public static class Paged
    {

        /// <summary>Returns the input typed as <see cref="T:System.Collections.Generic.IEnumerable`1" />.</summary>
        /// <param name="source">The sequence to type as <see cref="T:System.Collections.Generic.IEnumerable`1" />.</param>
        /// <param name="pagination"></param>
        /// <typeparam name="TSource">The type of the elements of <paramref name="source" />.</typeparam>
        /// <returns>The input sequence typed as <see cref="T:Olbrasoft.Collections.Generic.IPagedList`1" />.</returns>
        public static IPagedList<TSource> AsPagedList<TSource>(this IEnumerable<TSource> source, IPagination pagination)
        {
            return new PagedList<TSource>(source, pagination.PageInfo, pagination.CountWithOutPaging());
        }
        
        public static IPagedList<TSource> AsPagedList<TSource>(this IEnumerable<TSource> source)
        {
            var enumerable = source as TSource[] ?? source.ToArray();
           
            IPagination pagination = new Pagination.Pagination(new PageInfo(enumerable.Length), enumerable.Count);

            return enumerable.AsPagedList(pagination);
        }

        public static IPagination AsPagination<TSource>(this IPagedList<TSource> sources) =>
            new Pagination.Pagination(new PageInfo(sources.PageSize, sources.PageNumber), () => sources.TotalItemCount);

    }
    
   
}
