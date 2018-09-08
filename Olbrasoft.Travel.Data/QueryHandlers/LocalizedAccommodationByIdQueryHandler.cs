using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Queries;
using System;
using System.Linq;

namespace Olbrasoft.Travel.Data.QueryHandlers
{
    public class LocalizedAccommodationByIdQueryHandler : IQueryHandler<LocalizedAccommodationByIdQuery, LocalizedAccommodation>
    {
        protected IQueryable<LocalizedAccommodation> Queryable { get; }

        public LocalizedAccommodationByIdQueryHandler(IQueryable<LocalizedAccommodation> queryable)
        {
            Queryable = queryable;
        }

        public LocalizedAccommodation Handle(LocalizedAccommodationByIdQuery query)
        {
            var queryable = Queryable;

            queryable = queryable.Where(la => la.Id == query.Id && la.LanguageId == query.LanguageId);

            var localizedAccommodations = queryable.ToArray();

            var count = localizedAccommodations.Length;

            if (count != 1) throw new Exception("Must return one record");

            var localizedAccommodation = localizedAccommodations.First();

            var descriptionsQueryable = Queryable.SelectMany(p => p.Accommodation.Descriptions);

            var descriptions = descriptionsQueryable.Where(p => p.AccommodationId == query.Id && p.LanguageId == query.LanguageId).ToArray();

            localizedAccommodation.Accommodation.Descriptions = descriptions;

            return localizedAccommodation;
        }
    }
}