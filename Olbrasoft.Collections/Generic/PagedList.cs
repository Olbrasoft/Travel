using System.Collections.Generic;
using X.PagedList;

namespace Olbrasoft.Collections.Generic
{
    public class PagedList<T> : BasePagedList<T>, IPagedList<T>
    {
        public PagedList(IEnumerable<T> subSet, int pageNumber, int pageSize, int totalItemCount) : base(pageNumber, pageSize, totalItemCount)
        {
            Subset.AddRange(subSet);
        }

        //public PagedList(IEnumerable<T> subSet, IPageInfo pageInfo, int totalItemCount) : this(subSet, pageInfo.NumberOfSelectedPage, pageInfo.PageSize, totalItemCount)
        //{
        //}


    }
} 