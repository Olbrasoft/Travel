using System.Collections.Generic;
using Olbrasoft.Shared.Pagination.Web.Mvc;

namespace Olbrasoft.Shared.Pagination
{
    public class PageModel<T> : EnumerableItems<T>, IPageModel<T>
    {
        public PageModel(IEnumerable<T> items, IPaging paging) : base(items)
        {
            Paging = paging;
        }

        public IPaging Paging { get; }
    }
}