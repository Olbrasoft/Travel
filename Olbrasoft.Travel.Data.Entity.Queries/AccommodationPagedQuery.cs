﻿using System.Data.Entity;
using System.Linq;
using Olbrasoft.Data.Entity;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Shared;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.Queries
{
    public class AccommodationPagedQuery : LocalizedPagedQuery<Accommodation>
    {
        public AccommodationPagedQuery(IQueryable<Accommodation> queryable, IPageInfo pageInfo, ILanguageService languageService) : base(queryable, pageInfo, languageService)
        {
        }

        public AccommodationPagedQuery(IQueryable<Accommodation> queryable, ILanguageService languageService) : base(queryable, languageService)
        {
        }

        public override IPagedList<Accommodation> Execute( ) 
        {
            var localizedAccommodations = Queryable.SelectMany(p => p.LocalizedAccommodations);

            localizedAccommodations = localizedAccommodations
                .Where(
                    la =>
                        (Queryable
                             .OrderBy(a => a.SequenceNumber)
                             .Select(a => a.Id)
                             .Skip<int>(Skip)
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
            return new Pagination.Pagination(PageInfo, Queryable.Count);
        }
    }
}