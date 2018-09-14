using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Collections.Generic;

namespace Olbrasoft.Pagination.Linq
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
            return new PagedList<TSource>(source,pagination.PageInfo.NumberOfSelectedPage, pagination.PageInfo.PageSize, pagination.CountWithOutPaging());
        }

        public static IPagedList<TSource> AsPagedList<TSource>(this IEnumerable<TSource> source)
        {
            var enumerable = source as TSource[] ?? source.ToArray();

            IPagination pagination = new Pagination(new PageInfo(enumerable.Length), enumerable.Count);

            return enumerable.AsPagedList(pagination);
        }

        //public static Paged<T> Page<T>(this IEnumerable<T> collection, PageInfo paging)
        //{
        //    paging = paging ?? new PageInfo();
        //    return new Paged<T>
        //    {
        //        Items = collection.Skip(paging.PageIndex * paging.PageSize).Take(paging.PageSize).ToArray(),
        //        Paging = paging,
        //    };
        //}

        public static IPagedList<T> AsPagedList<T>(this IQueryable<T> collection, IPageInfo paging)
        {
            paging = paging ?? new PageInfo();

            var pagedList =  new X.PagedList.PagedList<T>(collection,paging.NumberOfSelectedPage,paging.PageSize);

            return new PagedList<T>(pagedList,pagedList.PageNumber,pagedList.PageSize,pagedList.TotalItemCount);
        }

        public static IPagination AsPagination<TSource>(this IPagedList<TSource> sources) =>
            new Olbrasoft.Pagination.Pagination(new PageInfo(sources.PageSize, sources.PageNumber), () => sources.TotalItemCount);
    }
}