using Olbrasoft.Collections.Generic;
using Olbrasoft.Pagination;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Data.Entity
{
    public static class QueryableExtensions
    {
        public static Task<PagedList<TSource>> ToPagedListAsync<TSource>(this IQueryable<TSource> source, IPageInfo paging)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (paging == null)
                throw new ArgumentNullException(nameof(paging));

            return source.ToPagedListAsync(paging, default(CancellationToken));
        }


        public static async Task<PagedList<TSource>> ToPagedListAsync<TSource>(this IQueryable<TSource> source, IPageInfo paging, CancellationToken cancellationToken)
        {
            if (source == null)
                throw new ArgumentNullException(nameof(source));

            if (paging == null)
                throw new ArgumentNullException(nameof(paging));

            if (cancellationToken==null)
                throw new ArgumentNullException(nameof(cancellationToken));

            var countWithOutPaging = await source.CountAsync(cancellationToken);

            var sourceArray = await source.Skip(paging.CalculateSkip())
                .Take(paging.PageSize).ToArrayAsync(cancellationToken);

            return new PagedList<TSource>(sourceArray, paging.NumberOfSelectedPage, paging.PageSize, countWithOutPaging);

         
        }

        public static async Task<IPagedList<TSource>> AsPagedListAsync<TSource>(this IQueryable<TSource> source, IPageInfo paging, CancellationToken cancellationToken)
        {
            //if (source == null)
            //    throw new ArgumentNullException(nameof(source));

            //if (paging == null)
            //    throw new ArgumentNullException(nameof(paging));

            //if (cancellationToken == null)
            //    throw new ArgumentNullException(nameof(cancellationToken));

            //var countWithOutPaging = await source.CountAsync(cancellationToken);

            //var sourceArray = await source.Skip(paging.CalculateSkip())
            //    .Take(paging.PageSize).ToArrayAsync(cancellationToken);

           //return new PagedList<TSource>(sourceArray, paging.NumberOfSelectedPage, paging.PageSize, countWithOutPaging);

            return await source.ToPagedListAsync(paging, cancellationToken);
        }

        

    }
}