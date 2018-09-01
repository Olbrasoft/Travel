using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IAccommodationsFacade : IFacade
    {
        IPagedList<AccommodationDto> AccommodationDataTransferObjects(IPageInfo pageInfo);
    }
}