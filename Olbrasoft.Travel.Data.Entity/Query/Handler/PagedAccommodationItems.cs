using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Query.Handler
{
    public class PagedAccommodationItems : HandlerWithDependentSource<GetPagedAccommodationItems, IQueryable<LocalizedAccommodation>, IResultWithTotalCount<AccommodationItem>>
    {
        public PagedAccommodationItems(IHaveQueryable<LocalizedAccommodation> queryableOwner) : base(queryableOwner.Queryable)
        {
        }

        public override IResultWithTotalCount<AccommodationItem> Handle(GetPagedAccommodationItems query)
        {
            var localizedAccommodations = PreHandle(Source, query);

            var accommodationItems = ProjectToAccommodationItems(localizedAccommodations);

            var result = new ResultWithTotalCount<AccommodationItem>
            {
                Result = accommodationItems.Skip(query.Paging.CalculateSkip()).Take(query.Paging.PageSize).ToArray(),

                TotalCount = accommodationItems.Count()
            };

            return result;
        }

        public override async Task<IResultWithTotalCount<AccommodationItem>> HandleAsync(GetPagedAccommodationItems query, CancellationToken cancellationToken)
        {
            var localizedAccommodations = PreHandle(Source, query);

            var accommodationItems = ProjectToAccommodationItems(localizedAccommodations);

            var result = new ResultWithTotalCount<AccommodationItem>
            {
                Result = await accommodationItems.Skip(query.Paging.CalculateSkip()).Take(query.Paging.PageSize).ToArrayAsync(cancellationToken),

                TotalCount = await accommodationItems.CountAsync(cancellationToken)
            };

            return result;
        }

        private static IQueryable<AccommodationItem> ProjectToAccommodationItems(IQueryable<LocalizedAccommodation> localizedAccommodations)
        {
            return from la in localizedAccommodations
                   select new AccommodationItem
                   {
                       Id = la.Id,
                       Address = la.Accommodation.Address,
                       Name = la.Name,
                       Location = la.Location,
                       StarRating = la.Accommodation.StarRating
                   };
        }

        private static IQueryable<LocalizedAccommodation> PreHandle(IQueryable<LocalizedAccommodation> source, GetPagedAccommodationItems query)
        {
            var localizedAccommodationQueryable = source.Include(p => p.Accommodation).Where(p => p.LanguageId == query.LanguageId);

            var localizedAccommodationOrderedQueryable = query.Sorting(localizedAccommodationQueryable);

            return localizedAccommodationOrderedQueryable;
        }
    }
}