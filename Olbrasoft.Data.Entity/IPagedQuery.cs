using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Pagination;

using Olbrasoft.Pagination.Collections.Generic;

namespace Olbrasoft.Data.Entity
{
    public interface IPagedQuery<out T> : Design.Pattern.Behavior.IQuery<IPagedList<T>>, IPagedQuery
    {
        IPagedList<T> Execute(IPageInfo pageInfo);
    }

    public interface IPagedQuery
    {
    }
}