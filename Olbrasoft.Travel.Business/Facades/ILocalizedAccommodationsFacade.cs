using System;
using System.Linq;
using System.Threading.Tasks;
using Olbrasoft.Business;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface ILocalizedAccommodationsFacade : IFacade<LocalizedAccommodation> 
    {
        IPagedList<AccommodationDto> Get(IPageInfo pageInfo, Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting);
        AccommodationDetailDto Get(int id);
        Task<AccommodationDetailDto> GetAsync(int id);
    }
}