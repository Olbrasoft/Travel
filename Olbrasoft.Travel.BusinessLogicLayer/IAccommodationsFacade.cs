using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IAccommodationsFacade : IFacade
    {
        IPagedList<AccommodationDataTransferObject> AccommodationDataTransferObjects(IPageInfo pageInfo);
    }
}