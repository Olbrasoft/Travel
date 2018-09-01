using Olbrasoft.Data.Entity;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Linq;
using Olbrasoft.Shared.Pagination;
using System.Data.Entity;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity.Query
{
    public class AccommodationPagedQuery : LocalizedPagedQuery<Accommodation>
    {
        public AccommodationPagedQuery(IQueryable<Accommodation> queryable, IPageInfo pageInfo, ILanguageService languageService) : base(queryable, pageInfo, languageService)
        {
        }

        public AccommodationPagedQuery(IQueryable<Accommodation> queryable, ILanguageService languageService) : base(queryable, languageService)
        {
        }

        public override IPagedList<Accommodation> Execute()
        {
            var localizedAccommodations = Queryable.SelectMany(p => p.LocalizedAccommodations);

            localizedAccommodations = localizedAccommodations
                .Where(
                    la =>
                        (Queryable
                             .OrderBy(a => a.SequenceNumber)
                             .Select(a => a.Id)
                             .Skip(Skip)
                             .Take(Take)
                             .Contains(la.Id) &&
                         (la.LanguageId == LanguageId)
                        )
                ).Include(p => p.Accommodation);

            var accommodations = localizedAccommodations.AsEnumerable().Select(la => la.Accommodation);

            return accommodations.AsPagedList(CreatePagination());
        }

        private IPagination CreatePagination()
        {
            return new Pagination(PageInfo, Queryable.Count);
        }

       
    }
}