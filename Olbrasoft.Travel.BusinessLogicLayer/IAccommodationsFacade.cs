using System.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IAccommodationsFacade
    {
        IPageResult<AccommodationDataTransferObject> Get(IPageInfo pageInfo);
  
    }
   
}