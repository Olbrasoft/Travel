using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Unit.Tests;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Query.Unit.Tests
{
    public class LocalizedAccommodationByIdHandlerWithDependentSource : HandlerWithDependentSource<ILocalizedAccommodationByIdQuery, IQueryable<LocalizedAccommodation>, LocalizedAccommodation>
    {

        private IQueryable<LocalizedAccommodation> PreHandle(ILocalizedAccommodationByIdQuery query)
        {
            var result = from la in Source.Where(la => la.Id == query.Id && la.LanguageId == query.LanguageId)
                         select la;

            //select new LocalizedAccommodation()
            //{
            //    //Id = la.Id,
            //    //Name = la.Name,
            //    //Location = la.Location,
            //    //LanguageId = la.LanguageId,
            //    //CreatorId = la.CreatorId,
            //    //DateAndTimeOfCreation = la.DateAndTimeOfCreation,
            //    //CheckInTime = la.CheckInTime,
            //    //CheckOutTime = la.CheckOutTime

            //};
            return result;

            //return Source.Where(la => la.Id == query.Id && la.LanguageId == query.LanguageId);
        }

        private IQueryable<Description> PreHandleDescriptions(ILocalizedAccommodationByIdQuery query)
        {
            return Source.SelectMany(p => p.Accommodation.Descriptions)
               .Where(p => p.AccommodationId == query.Id && p.LanguageId == query.LanguageId);
        }

        public override LocalizedAccommodation Handle(ILocalizedAccommodationByIdQuery query)
        {
            var localizedAccommodation = PreHandle(query).First();

            var descriptions = PreHandleDescriptions(query).ToArray();

            localizedAccommodation.Accommodation.Descriptions = descriptions;

            return localizedAccommodation;
        }

        public override async Task<LocalizedAccommodation> HandleAsync(ILocalizedAccommodationByIdQuery query, CancellationToken cancellationToken)
        {
            var localizedAccommodation = await PreHandle(query).FirstAsync(cancellationToken);

            var descriptions = await PreHandleDescriptions(query).ToArrayAsync(cancellationToken);

            localizedAccommodation.Accommodation.Descriptions = descriptions;

            return localizedAccommodation;
        }

        public LocalizedAccommodationByIdHandlerWithDependentSource(IHaveQueryable<LocalizedAccommodation> source, IProjection projector) : base(source.Queryable, projector)
        {
        }
    }
}