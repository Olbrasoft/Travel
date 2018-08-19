using System.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IAccommodationsFacade
    {
        IPageModel<AccommodationDataTransferObject> Get(IPageInfo pageInfo);
  
    }
   
}