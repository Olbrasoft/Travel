using Olbrasoft.Collections.Generic;
using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Object;
using System;
using System.Linq;

namespace Olbrasoft.Travel.Data.Query
{
    public class GetPagedAccommodationItems : QueryWithDependentDispatcher<IResultWithTotalCount<AccommodationItem>>
    {
        public int LanguageId { get; set; }

        public Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> Sorting
        {
            get;
            set;
        }

        public IPageInfo Paging { get; set; }

        public GetPagedAccommodationItems(IDispatcher queryDispatcher) : base(queryDispatcher)
        {
        }
    }
}