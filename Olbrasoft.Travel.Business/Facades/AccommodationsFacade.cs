using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.Facades
{
    public class AccommodationsFacade : IAccommodations
    {
        public AccommodationsFacade(IQueryFactory queryFactory)
        {
            QueryFactory = queryFactory;
        }

        protected IQueryFactory QueryFactory { get; }

        public AccommodationDetail Get(int id, int languageId)
        {
            var query = GetAccommodationDetailById(id, languageId);

            return query.Execute();
        }

        public IPagedList<AccommodationItem> Get(IPageInfo pagingSettings, int languageId, Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting)
        {
            var query = GetPagedAccommodationItems(pagingSettings, languageId, sorting);

            return query.Execute();
        }

        private GetPagedAccommodationItems GetPagedAccommodationItems(
            IPageInfo pagingSettings, int languageId, Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting
        )
        {
            var query = QueryFactory.Create<GetPagedAccommodationItems>();
            query.Paging = pagingSettings;
            query.LanguageId = languageId;
            query.Sorting = sorting;
            return query;
        }

        public Task<AccommodationDetail> GetAsync(int id, int languageId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var query = GetAccommodationDetailById(id, languageId);

            return query.ExecuteAsync(cancellationToken);
        }

        //public Task<AccommodationDetail> GetAsync(int id, int languageId)
        //{
        //    return GetAsync(id, languageId, default(CancellationToken));
        //}

        public Task<IPagedList<AccommodationItem>> GetAsync(
            IPageInfo pagingSettings,
            int languageId,
            Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting,
            CancellationToken cancellationToken = default(CancellationToken)
        )
        {
            var query = GetPagedAccommodationItems(pagingSettings, languageId, sorting);
            return query.ExecuteAsync(cancellationToken);
        }

        //public Task<IPagedList<AccommodationItem>> GetAsync(
        //    IPageInfo pagingSettings,
        //    int languageId,
        //    Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting
        //)
        //{
        //    return GetAsync(pagingSettings, languageId, sorting, default(CancellationToken));
        //}

        private GetAccommodationDetailById GetAccommodationDetailById(int id, int languageId)
        {
            var query = QueryFactory.Create<GetAccommodationDetailById>();

            query.Id = id;
            query.LanguageId = languageId;
            return query;
        }
    }
}