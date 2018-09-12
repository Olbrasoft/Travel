using Olbrasoft.Data;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.QueryHandlers
{
    public class LocalizedAccommodationsQueryHandler : QueryHandler<LocalizedAccommodationsPagedQuery, IPagedList<LocalizedAccommodation>>
    {
        protected IQueryable<LocalizedAccommodation> Queryable { get; }

        public LocalizedAccommodationsQueryHandler(IQueryable<LocalizedAccommodation> queryable)
        {
            Queryable = queryable;
        }

        public override IPagedList<LocalizedAccommodation> Handle(LocalizedAccommodationsPagedQuery query)
        {
            return PreProcessQuery(query);
        }

        public override async Task<IPagedList<LocalizedAccommodation>> HandleAsync(LocalizedAccommodationsPagedQuery query, CancellationToken cancellationToken)
        {


            throw new System.NotImplementedException();
        }

        private IPagedList<LocalizedAccommodation> PreProcessQuery(LocalizedAccommodationsPagedQuery query)
        {
            var localizedAccommodationQueryable = Queryable.Include(p => p.Accommodation).Where(p => p.LanguageId == query.LanguageId);

            var localizedAccommodationOrderedQueryable = query.Sorting(localizedAccommodationQueryable);

            return localizedAccommodationOrderedQueryable.AsPagedList(query.Paging);
        }
    }
}