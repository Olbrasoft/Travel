﻿using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Pagination;

namespace Olbrasoft.Travel.Data.Transfer.Object
{
    public class AccommodationItemPhotoMerge : IAccommodationItemPhotoMerge
    {
        public IResultWithTotalCount<AccommodationItem> Merge(IResultWithTotalCount<AccommodationItem> master, IEnumerable<AccommodationPhoto> slave)
        {
            foreach (var photo in slave)
            {
                master.Result.First(p => p.Id == photo.AccommodationId).Photo = $"https://i.travelapi.com/hotels/{photo.Path}/{photo.Name}{photo.Extension}";
            }

            return master;
        }
    }
}