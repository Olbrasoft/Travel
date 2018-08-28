using System.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
using Olbrasoft.Travel.DataTransferObject;
using X.PagedList;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IAccommodationsFacade : IFacade
    {
       IPagedList<AccommodationDataTransferObject> AccommodationDataTransferObjects(IPageInfo pageInfo);
        
    }
   
}