using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using Olbrasoft.Travel.Data.Transfer.Objects;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Query
{
    public class GetAccommodationByIdQueryHandler : QueryHandler<GetAccommodationDetailById, IQueryable<LocalizedAccommodation>, AccommodationDetail>
    {
        public GetAccommodationByIdQueryHandler(IQueryable<LocalizedAccommodation> source) : base(source)
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
                   };
        }
    }
}