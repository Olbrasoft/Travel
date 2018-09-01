using Olbrasoft.Design.Pattern.Behavior;
using System.Linq;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;

namespace Olbrasoft.Data.Entity
{
    public abstract class PagedQuery<T> : Query<IPagedList<T>>, IPagedQuery<T> where T : class
    {
        protected IQueryable<T> Queryable { get; }

        protected IPageInfo PageInfo { get; private set; }

        protected int Take => GetTake(PageInfo);

        protected int Skip => GetSkip(PageInfo);

        protected int TotalItemCount => GetTotalItemCount(Queryable);

        private int GetTotalItemCount(IQueryable<T> queryable)
        {
            return queryable.Count();
        }

        protected PagedQuery(IQueryable<T> queryable, IPageInfo pageInfo) : this(queryable)
        {
            PageInfo = pageInfo;
        }

        protected PagedQuery(IQueryable<T> queryable)
        {
            Queryable = queryable;
        }

        protected virtual int GetSkip(IPageInfo pageInfo)
        {
            return pageInfo.PageSize * (pageInfo.NumberOfSelectedPage - 1);
        }

        protected virtual int GetTake(IPageInfo pageInfo)
        {
            return pageInfo.PageSize;
        }

        public IPagedList<T> Execute(IPageInfo pageInfo)
        {
            PageInfo = pageInfo;
            return Execute();
        }
    }
}