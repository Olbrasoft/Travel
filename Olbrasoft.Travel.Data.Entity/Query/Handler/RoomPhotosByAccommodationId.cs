﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Entity.Query.Handler
{
    public class RoomPhotosByAccommodationId : AsyncHandlerWithDependentSource<GetRoomPhotosByAccommodationId, PhotoOfAccommodation, IEnumerable<RoomPhoto>>
    {
        public RoomPhotosByAccommodationId(IHaveQueryable<PhotoOfAccommodation> ownerQueryable, IProjection projector) : base(ownerQueryable, projector)
        {
        }

        public override async Task<IEnumerable<RoomPhoto>> HandleAsync(GetRoomPhotosByAccommodationId query, CancellationToken cancellationToken)
        {
            return await ProjectionToRoomPhotos(Source, query, Projector).ToArrayAsync(cancellationToken);
        }

        protected IQueryable<RoomPhoto> ProjectionToRoomPhotos(IQueryable<PhotoOfAccommodation> photosOfAccommodations, GetRoomPhotosByAccommodationId query, IProjection projector)
        {
            var photosOfRooms = Source.SelectMany(p => p.ToTypesOfRooms).Select(p => p.Id);

            photosOfAccommodations = photosOfAccommodations
                .Include(p => p.ToTypesOfRooms)
                .Where(p => p.AccommodationId == query.AccommodationId)
                .Where(p => photosOfRooms.Contains(p.Id));

            return projector.ProjectTo<RoomPhoto>(photosOfAccommodations);
        }
    }
}