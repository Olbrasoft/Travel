using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Query.Handler
{
    public class AccommodationDetailById : HandlerWithDependentSource<GetAccommodationDetailById, IQueryable<LocalizedAccommodation>, AccommodationDetail>
    {
        public AccommodationDetailById(IHaveQueryable<LocalizedAccommodation> queryableOwner) : base(queryableOwner.Queryable)
        {
        }

        public override AccommodationDetail Handle(GetAccommodationDetailById query)
        {
            var accommodationDetail = ProjectToAccommodationsDetails(Source, query).First();

            var defaultDescription = ProjectToAccommodationDescriptions(Source, query)
                .FirstOrDefault(p => p.TypeOfDescriptionId == 1)?
                .Text;

            accommodationDetail.Description = defaultDescription;

            return accommodationDetail;
        }

        public override async Task<AccommodationDetail> HandleAsync(GetAccommodationDetailById query, CancellationToken cancellationToken)
        {
            var accommodationDetail = await ProjectToAccommodationsDetails(Source, query).FirstAsync(cancellationToken);

            var defaultDescription = (await ProjectToAccommodationDescriptions(Source, query)
                .FirstOrDefaultAsync(p => p.TypeOfDescriptionId == 1, cancellationToken))?.Text;

            accommodationDetail.Description = defaultDescription;

            return accommodationDetail;
        }

        private static IQueryable<AccommodationDescription> ProjectToAccommodationDescriptions(IQueryable<LocalizedAccommodation> source, GetAccommodationDetailById query)
        {
            return source
                .SelectMany(p => p.Accommodation.Descriptions)
                .Where(p => p.AccommodationId == query.Id && p.LanguageId == query.LanguageId)
                .Select(des => new AccommodationDescription
                {
                    TypeOfDescriptionId = des.TypeOfDescriptionId,
                    Text = des.Text
                });
        }

        private static IQueryable<AccommodationDetail> ProjectToAccommodationsDetails(IQueryable<LocalizedAccommodation> source, GetAccommodationDetailById query)
        {
            return from la in source.Include(p => p.Accommodation).Where(la => la.Id == query.Id && la.LanguageId == query.LanguageId)
                   select new AccommodationDetail
                   {
                       Id = la.Id,
                       Name = la.Name,
                       Address = la.Accommodation.Address,
                       Location = la.Location,
                       Latitude = (double)la.Accommodation.CenterCoordinates.Latitude,
                       Longitude = (double)la.Accommodation.CenterCoordinates.Longitude,
                       StarRating = la.Accommodation.StarRating
                   };
        }
    }
}