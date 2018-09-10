using Olbrasoft.Data;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.Facades
{
    public class LocalizedAccommodationsFacade : ILocalizedAccommodationsFacade
    {
        protected virtual IQueryBuilder QueryBuilder { get; }

        protected virtual IQueryProcessor QueryProcessor { get; }

        protected virtual IMapper<LocalizedAccommodation> Mapper { get; }

        protected ILanguageService LanguageService { get; }

        public LocalizedAccommodationsFacade(
            ILanguageService languageService,
            IQueryBuilder queryBuilder, IQueryProcessor queryProcessor, IMapper<LocalizedAccommodation> mapper)
        {
            LanguageService = languageService;
            QueryBuilder = queryBuilder;
            QueryProcessor = queryProcessor;
            Mapper = mapper;
        }

        public virtual IPagedList<AccommodationDto> Get(IPageInfo pageInfo)
        {
           
            var localizedPagedQuery = QueryBuilder
                .Build<ILocalizedAccommodationsPagedQuery>(p => p.LanguageId, LanguageService.CurrentLanguageId)
                .SetAndReturn(p => p.Paging, pageInfo);

            var pagedListOfLocalizedAccommodation = QueryProcessor.Execute(localizedPagedQuery);

            var pagedListOfAccommodationDto = Mapper.Map<AccommodationDto>(pagedListOfLocalizedAccommodation);

            return pagedListOfAccommodationDto;
        }
        
        public AccommodationDetailDto Get(int id)
        {
            var localizedAccommodationByIdQuery = QueryBuilder.Build<ILocalizedAccommodationByIdQuery>(p => p.Id, id)
                .SetAndReturn(p => p.LanguageId, LanguageService.CurrentLanguageId);
            
            var localizedAccommodation = QueryProcessor.Execute(localizedAccommodationByIdQuery);

            var localizedAccommodationDetailDto = Mapper.Map<AccommodationDetailDto>(localizedAccommodation);

            return localizedAccommodationDetailDto;
        }
        

    }
}