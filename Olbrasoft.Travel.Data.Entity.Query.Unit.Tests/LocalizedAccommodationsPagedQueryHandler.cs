using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Data.Entity;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Unit.Tests;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Query.Unit.Tests
{
    public class LocalizedAccommodationsPagedQueryHandler : QueryHandler<ILocalizedAccommodationsPagedQuery,
        IQueryable<LocalizedAccommodation>, IPagedList<LocalizedAccommodation>>
    {
        public LocalizedAccommodationsPagedQueryHandler(IQueryable<LocalizedAccommodation> source) : base(source)
        {
        }

        public override IPagedList<LocalizedAccommodation> Handle(ILocalizedAccommodationsPagedQuery query)
        {
            return PreHandle(query).AsPagedList(query.Paging);
        }

        public override Task<IPagedList<LocalizedAccommodation>> HandleAsync(
            ILocalizedAccommodationsPagedQuery query, CancellationToken cancellationToken)
        {
            return PreHandle(query).AsPagedListAsync(query.Paging, cancellationToken);
        }

        private IQueryable<LocalizedAccommodation> PreHandle(ILocalizedAccommodationsPagedQuery query)
        {
            var localizedAccommodationQueryable =
                Source.Include(p => p.Accommodation).Where(p => p.LanguageId == query.LanguageId);

            var localizedAccommodationOrderedQueryable = query.Sorting(localizedAccommodationQueryable);

            return localizedAccommodationOrderedQueryable;
        }
    }
}