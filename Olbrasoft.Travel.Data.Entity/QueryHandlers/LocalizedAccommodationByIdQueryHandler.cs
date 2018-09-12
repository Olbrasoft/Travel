using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using System;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.QueryHandlers
{
    public class LocalizedAccommodationByIdQueryHandler : QueryHandler<LocalizedAccommodationById, LocalizedAccommodation>
    {
        private IQueryable<LocalizedAccommodation> Queryable { get; }

        public LocalizedAccommodationByIdQueryHandler(IQueryable<LocalizedAccommodation> queryable)
        {
            Queryable = queryable;
        }
        
        private IQueryable<LocalizedAccommodation> LocalizedAccommodationsQueryable(LocalizedAccommodationById query)
        {
            return Queryable.Where(la => la.Id == query.Id && la.LanguageId == query.LanguageId);
        }

        private IQueryable<Description> DescriptionsQueryable(LocalizedAccommodationById query)
        {
            return Queryable.SelectMany(p => p.Accommodation.Descriptions)
               .Where(p => p.AccommodationId == query.Id && p.LanguageId == query.LanguageId);
        }


        public override LocalizedAccommodation Handle(LocalizedAccommodationById query)
        {
            var localizedAccommodations = LocalizedAccommodationsQueryable(query).ToArray();

            var count = localizedAccommodations.Length;

            if (count != 1) throw new Exception("Must return one record");

            var localizedAccommodation = localizedAccommodations.First();

            var descriptions = DescriptionsQueryable(query).ToArray();

            localizedAccommodation.Accommodation.Descriptions = descriptions;

            return localizedAccommodation;
        }

        public override async Task<LocalizedAccommodation> HandleAsync(LocalizedAccommodationById query, CancellationToken cancellationToken)
        {
            var localizedAccommodations = await LocalizedAccommodationsQueryable(query).ToArrayAsync(cancellationToken);

            var count = localizedAccommodations.Length;

            if (count != 1) throw new Exception("Must return one record");

            var localizedAccommodation = localizedAccommodations.First();

            var descriptions = await DescriptionsQueryable(query).ToArrayAsync(cancellationToken);

            localizedAccommodation.Accommodation.Descriptions = descriptions;

            return localizedAccommodation;
        }
    }
}