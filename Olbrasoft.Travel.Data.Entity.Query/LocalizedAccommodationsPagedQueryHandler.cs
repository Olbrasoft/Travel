using Olbrasoft.Data;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Query
{
    public class LocalizedAccommodationsPagedQueryHandler : QueryHandler<ILocalizedAccommodationsPagedQuery, IQueryable<LocalizedAccommodation>, IPagedList<LocalizedAccommodation>>
    {
        public LocalizedAccommodationsPagedQueryHandler(IQueryable<LocalizedAccommodation> source) : base(source)
        {
        }

        public override IPagedList<LocalizedAccommodation> Handle(ILocalizedAccommodationsPagedQuery query)
        {
            return PreProcessQuery(query);
        }

        public override async Task<IPagedList<LocalizedAccommodation>> HandleAsync(ILocalizedAccommodationsPagedQuery query, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }

        private IPagedList<LocalizedAccommodation> PreProcessQuery(ILocalizedAccommodationsPagedQuery query)
        {
            var localizedAccommodationQueryable = Source.Include(p => p.Accommodation).Where(p => p.LanguageId == query.LanguageId);

            var localizedAccommodationOrderedQueryable = query.Sorting(localizedAccommodationQueryable);

            return localizedAccommodationOrderedQueryable.AsPagedList(query.Paging);
        }
    }
}