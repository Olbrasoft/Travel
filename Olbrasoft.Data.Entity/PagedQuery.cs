using System.Linq;
using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Data.Entity
{
    public abstract class PagedQuery<T> : Query<PagedCollection<T>>, IPagedQuery<T>  where T : class
    {
        protected PagedQuery(IQueryable<T> queryable, IPageInfo pageInfo)
        {
            PageInfo = pageInfo;
            Queryable = queryable;
        }

        protected IQueryable<T> Queryable { get; }

        protected IPageInfo PageInfo { get; }

        protected int Take => GetTake(PageInfo);

        protected int Skip => GetSkip(PageInfo);


        protected virtual int GetSkip(IPageInfo pageInfo)
        {
            return pageInfo.PageSize * (pageInfo.NumberOfSelectedPage - 1);
        }

        protected virtual int GetTake(IPageInfo pageInfo)
        {
            return pageInfo.PageSize;
        }
    }
}