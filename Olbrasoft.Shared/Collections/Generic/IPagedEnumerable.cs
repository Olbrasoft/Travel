using System.Collections.Generic;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Shared.Collections.Generic
{
    public interface IPagedEnumerable<out T> : IEnumerable<T>
    {
        IPagination Pagination { get; }
    }

}
