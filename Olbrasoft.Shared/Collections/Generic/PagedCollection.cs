using Olbrasoft.Shared.Pagination;
using System.Collections.Generic;
using X.PagedList;

namespace Olbrasoft.Shared.Collections.Generic
{
    public class PagedCollection<T> : BasePagedList<T>
    {
        public PagedCollection(IEnumerable<T> subSet, int pageNumber, int pageSize, int totalItemCount) : base(pageNumber, pageSize, totalItemCount)
        {
            Subset.AddRange(subSet);
        }

        public PagedCollection(IEnumerable<T> subSet, IPageInfo pageInfo, int totalItemCount) : this(subSet, pageInfo.NumberOfSelectedPage, pageInfo.PageSize, totalItemCount)
        {
        }
    }
}