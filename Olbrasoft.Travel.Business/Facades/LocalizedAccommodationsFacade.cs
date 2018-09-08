using Olbrasoft.Data;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Entity.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;
using LocalizedAccommodationsPagedQuery = Olbrasoft.Travel.Data.Queries.LocalizedAccommodationsPagedQuery;

namespace Olbrasoft.Travel.Business.Facades
{
    public class LocalizedAccommodationsFacade : ILocalizedAccommodationsFacade
    {
        protected Design.Pattern.Behavior.IQuery<ILocalizedPagedQueryArgument, IPagedList<LocalizedAccommodation>> LocalizedAccommodationPagedQuery { get; }

        protected IQueryProcessor QueryProcessor { get; }

        protected IPagedListMapper<LocalizedAccommodation, AccommodationDto> PagedListMapper { get; }

        protected ILanguageService LanguageService { get; }

        public LocalizedAccommodationsFacade(Design.Pattern.Behavior.IQuery<ILocalizedPagedQueryArgument,
            IPagedList<LocalizedAccommodation>> localizedAccommodationPagedQuery,
            ILanguageService languageService,
            IPagedListMapper<LocalizedAccommodation, AccommodationDto> pagedListMapper, IQueryProcessor queryProcessor)
        {
            LocalizedAccommodationPagedQuery = localizedAccommodationPagedQuery;
            PagedListMapper = pagedListMapper;
            QueryProcessor = queryProcessor;
            LanguageService = languageService;
        }

        public virtual IPagedList<AccommodationDto> Get(IPageInfo pageInfo)
        {
            var getLocalizedPagedQuery =
                BuildGetLocalizedAccommodationsPagedQuery(pageInfo, LanguageService.CurrentLanguageId);

            var pagedListOfLocalizedAccommodation = QueryProcessor.Execute(getLocalizedPagedQuery);
             
            var pagedListOfAccommodationDto = PagedListMapper.Map(pagedListOfLocalizedAccommodation);

            return pagedListOfAccommodationDto;
        }


        protected virtual LocalizedAccommodationsPagedQuery BuildGetLocalizedAccommodationsPagedQuery(
            IPageInfo pageInfo, int languageId)
        {
            var localizedAccommodationsPagedQuery = new LocalizedAccommodationsPagedQuery {LanguageId = languageId, Paging = pageInfo};

            localizedAccommodationsPagedQuery.AddSorting(p=>p.Accommodation.SequenceNumber);
            localizedAccommodationsPagedQuery.AddSorting(p => p.Id);


            return localizedAccommodationsPagedQuery;
        }
    }
}