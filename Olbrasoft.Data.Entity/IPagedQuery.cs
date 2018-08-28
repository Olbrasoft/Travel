using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared.Pagination;
using X.PagedList;

namespace Olbrasoft.Data.Entity
{
    public interface IPagedQuery<out T> : IQuery<IPagedList<T>>, IPagedQuery
    {
        IPagedList<T> Execute(IPageInfo pageInfo);
    }

    public interface IPagedQuery
    {
    }
}