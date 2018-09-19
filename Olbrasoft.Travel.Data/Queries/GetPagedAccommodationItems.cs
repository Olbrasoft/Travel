using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;
using System;
using System.Linq;

namespace Olbrasoft.Travel.Data.Queries
{
    public class GetPagedAccommodationItems : QueryWithDependentQueryProcessor<IPagedList<AccommodationItem>>
    {
        public int LanguageId { get; set; }

        public Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> Sorting
        {
            get;
            set;
        }

        public IPageInfo Paging { get; set; }

        public GetPagedAccommodationItems(IQueryProcessor queryProcessor) : base(queryProcessor)
        {
        }
    }
}