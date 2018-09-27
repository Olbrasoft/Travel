using Olbrasoft.Collections.Generic;
using Olbrasoft.Data.Entity;
using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Unit.Tests;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Query.Unit.Tests
{
    public class LocalizedAccommodationsPagedHandlerWithDependentSource : HandlerWithDependentSource<ILocalizedAccommodationsPagedQuery,
        IQueryable<LocalizedAccommodation>, IPagedList<LocalizedAccommodation>>
    {

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

        public LocalizedAccommodationsPagedHandlerWithDependentSource(IHaveQueryable<LocalizedAccommodation> source , IProjection projector) : base(source.Queryable, projector)
        {
        }
    }
}