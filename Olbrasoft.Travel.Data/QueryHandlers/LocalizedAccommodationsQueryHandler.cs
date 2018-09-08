using System.Linq;
using Olbrasoft.Data;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;

namespace Olbrasoft.Travel.Data.QueryHandlers
{
    public class LocalizedAccommodationsQueryHandler : IQueryHandler<LocalizedAccommodationsPagedQuery, IPagedList<LocalizedAccommodation>>
    {
        protected IQueryable<LocalizedAccommodation> Queryable { get; }

        public LocalizedAccommodationsQueryHandler(IQueryable<LocalizedAccommodation> queryable)
        {
            Queryable = queryable;
        } 

        public IPagedList<LocalizedAccommodation> Handle(LocalizedAccommodationsPagedQuery query)
        {
            return PreProcessQuery(query);
        }

        private IPagedList<LocalizedAccommodation> PreProcessQuery(LocalizedAccommodationsPagedQuery query)
        {
            var queryable = Queryable;

            queryable = queryable.Where(p => p.LanguageId == query.LanguageId);

            queryable = queryable.OrderBy(p => p.Accommodation.SequenceNumber).ThenBy(p => p.Accommodation.Id);

            return queryable.AsPagedList(query.Paging);
        }
    }
}