using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Data.Entity
{
    public interface IPagedQuery<T> : IQuery<PagedCollection<T>>, IPagedQuery
    {
        
    }

    public interface IPagedQuery
    {  
        
      
    }

}