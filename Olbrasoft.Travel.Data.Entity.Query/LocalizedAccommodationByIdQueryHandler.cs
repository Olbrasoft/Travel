using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Query
{
    public class LocalizedAccommodationByIdQueryHandler : QueryHandler<ILocalizedAccommodationByIdQuery, IQueryable<LocalizedAccommodation>, LocalizedAccommodation>
    {
        public LocalizedAccommodationByIdQueryHandler(IQueryable<LocalizedAccommodation> source) : base(source)
        {
        }

        private IQueryable<LocalizedAccommodation> BuildLocalizedAccommodationsQueryable(ILocalizedAccommodationByIdQuery query)
        {
            return Source.Where(la => la.Id == query.Id && la.LanguageId == query.LanguageId);
        }

        private IQueryable<Description> BuildDescriptionsQueryable(ILocalizedAccommodationByIdQuery query)
        {
            return Source.SelectMany(p => p.Accommodation.Descriptions)
               .Where(p => p.AccommodationId == query.Id && p.LanguageId == query.LanguageId);
        }

        public override LocalizedAccommodation Handle(ILocalizedAccommodationByIdQuery query)
        {
            var localizedAccommodation = BuildLocalizedAccommodationsQueryable(query).First();

            var descriptions = BuildDescriptionsQueryable(query).ToArray();
       
            localizedAccommodation.Accommodation.Descriptions = descriptions;

            return localizedAccommodation;
        }

        public override async Task<LocalizedAccommodation> HandleAsync(ILocalizedAccommodationByIdQuery query, CancellationToken cancellationToken)
        {
            var localizedAccommodation = await BuildLocalizedAccommodationsQueryable(query).FirstAsync(cancellationToken);
            
            var descriptions = await BuildDescriptionsQueryable(query).ToArrayAsync(cancellationToken);

            localizedAccommodation.Accommodation.Descriptions = descriptions;

            return localizedAccommodation;
        }
    }
}