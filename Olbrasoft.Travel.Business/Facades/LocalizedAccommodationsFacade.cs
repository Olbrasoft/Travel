using Olbrasoft.Business;
using Olbrasoft.Data;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;
using System;
using System.Linq;

namespace Olbrasoft.Travel.Business.Facades
{
    public class LocalizedAccommodationsFacade : BaseFacade<LocalizedAccommodation>, ILocalizedAccommodationsFacade
    {
        protected ILanguageService LanguageService { get; }

        public virtual IPagedList<AccommodationDto> Get(IPageInfo pageInfo, Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting)
        {
            var localizedPagedQuery = Build<ILocalizedAccommodationsPagedQuery>(p => p.LanguageId, LanguageService.CurrentLanguageId)
                .SetAndReturn(p => p.Paging, pageInfo)
                .SetAndReturn(p => p.Sorting, sorting)
                ;

            var pagedListOfLocalizedAccommodation = Execute(localizedPagedQuery);

            var pagedListOfAccommodationDto = Mapper.Map<AccommodationDto>(pagedListOfLocalizedAccommodation);

            return pagedListOfAccommodationDto;
        }

        public AccommodationDetailDto Get(int id)
        {
            var localizedAccommodationByIdQuery = Build<ILocalizedAccommodationByIdQuery>(p => p.Id, id)
                .SetAndReturn(p => p.LanguageId, LanguageService.CurrentLanguageId);

            var localizedAccommodation = Execute(localizedAccommodationByIdQuery);

            var localizedAccommodationDetailDto = Mapper.Map<AccommodationDetailDto>(localizedAccommodation);

            return localizedAccommodationDetailDto;
        }

        public LocalizedAccommodationsFacade(IQueryManager queryManager, IMapper<LocalizedAccommodation> mapper, ILanguageService languageService) : base(queryManager, mapper)
        {
            LanguageService = languageService;
        }
    }
}