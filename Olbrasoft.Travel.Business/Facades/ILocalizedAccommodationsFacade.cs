using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface ILocalizedAccommodationsFacade : IFacade
    {
        IPagedList<AccommodationDto> Get(IPageInfo pageInfo);
        
    }
}