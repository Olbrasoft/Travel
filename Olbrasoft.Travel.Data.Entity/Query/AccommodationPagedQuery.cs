using System.Data.Entity;
using System.Linq;
using Olbrasoft.Data.Entity;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Travel.Data.Entity.Query
{
    public class AccommodationPagedQuery : PagedQuery<Accommodation>
    {
        protected IQueryable<Accommodation> Accommodations { get; }

        protected ILanguageService LanguageService { get; }

        protected int LanguageId => LanguageService.CurrentLanguageId;

        protected int TotalItemCount => Queryable.Count();

        public AccommodationPagedQuery(IQueryable<Accommodation> queryable, IPageInfo pageInfo, ILanguageService languageService)
            : base(queryable, pageInfo)
        {
            LanguageService = languageService;

            Accommodations = Queryable;
        }

        public override PagedCollection<Accommodation> Execute()
        {
           var localizedAccommodations = Queryable.SelectMany(p => p.LocalizedAccommodations);

            localizedAccommodations = localizedAccommodations
                .Where(
                    la =>
                        (Accommodations
                             .OrderBy(a => a.SequenceNumber)
                             .Select(a => a.Id)
                             .Skip(Skip)
                             .Take(Take)
                             .Contains(la.Id) &&
                         (la.LanguageId == LanguageId)
                        )
                ).Include(p => p.Accommodation);

            var accommodations = localizedAccommodations.AsEnumerable().Select(la => la.Accommodation);

            return new PagedCollection<Accommodation>(accommodations, PageInfo, TotalItemCount);
        }
    }


}