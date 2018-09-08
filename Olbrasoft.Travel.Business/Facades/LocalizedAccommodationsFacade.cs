using Olbrasoft.Data;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;
using LocalizedAccommodationsPagedQuery = Olbrasoft.Travel.Data.Queries.LocalizedAccommodationsPagedQuery;

namespace Olbrasoft.Travel.Business.Facades
{
    public class LocalizedAccommodationsFacade : ILocalizedAccommodationsFacade
    {
        protected IQueryProcessor QueryProcessor { get; }

        protected IMapper<LocalizedAccommodation, AccommodationDetailDto> Mapper { get; }

        protected ILanguageService LanguageService { get; }

        public LocalizedAccommodationsFacade(
            ILanguageService languageService,
           IQueryProcessor queryProcessor, IMapper<LocalizedAccommodation, AccommodationDetailDto> mapper)
        {
            QueryProcessor = queryProcessor;
            Mapper = mapper;
            LanguageService = languageService;
        }

        public virtual IPagedList<AccommodationDto> Get(IPageInfo pageInfo)
        {
            var localizedPagedQuery =
                BuildLocalizedAccommodationsPagedQuery(pageInfo, LanguageService.CurrentLanguageId);

            var pagedListOfLocalizedAccommodation = QueryProcessor.Execute(localizedPagedQuery);

            var pagedListOfAccommodationDto = Mapper.Map(pagedListOfLocalizedAccommodation);

            return pagedListOfAccommodationDto;
        }

        public AccommodationDetailDto Get(int id)
        {
            var localizedAccommodationByIdQuery =
                BuildLocalizedAccommodationByIdQuery(id, LanguageService.CurrentLanguageId);

            var localizedAccommodation = QueryProcessor.Execute(localizedAccommodationByIdQuery);

            var localizedAccommodationDetailDto = Mapper.Map(localizedAccommodation);

            return localizedAccommodationDetailDto;
        }

        private LocalizedAccommodationByIdQuery BuildLocalizedAccommodationByIdQuery(int id, int languageId)
        {
            var localizedAccommodationByIdQuery = new LocalizedAccommodationByIdQuery { Id = id, LanguageId = languageId };

            return localizedAccommodationByIdQuery;
        }

        protected virtual LocalizedAccommodationsPagedQuery BuildLocalizedAccommodationsPagedQuery(
            IPageInfo pageInfo, int languageId)
        {
            var localizedAccommodationsPagedQuery = new LocalizedAccommodationsPagedQuery { LanguageId = languageId, Paging = pageInfo };

            localizedAccommodationsPagedQuery.AddSorting(p => p.Accommodation.SequenceNumber);
            localizedAccommodationsPagedQuery.AddSorting(p => p.Id);

            return localizedAccommodationsPagedQuery;
        }
    }
}