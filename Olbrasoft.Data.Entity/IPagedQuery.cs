using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;

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