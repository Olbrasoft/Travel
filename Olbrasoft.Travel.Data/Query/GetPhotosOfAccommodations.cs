using System;
using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Query
{
    public class GetPhotosOfAccommodations : QueryWithDependentDispatcher<IEnumerable<AccommodationPhoto>>
    {
        public IEnumerable<int> AccommodationIds { get; set; }
        public bool OnlyDefaultPhotos { get; set; }

        public GetPhotosOfAccommodations(IDispatcher queryDispatcher) : base(queryDispatcher)
        {
        }
    }
}