using System.Collections.Generic;

namespace Olbrasoft.Shared.Pagination
{
    public class PageResult<T> : Result<T>, IPageResult<T>
    {
        public PageResult(IEnumerable<T> items, IPaging paging) : base(items)
        {
            Paging = paging;
        }

        public IPaging Paging { get; }
    }
}