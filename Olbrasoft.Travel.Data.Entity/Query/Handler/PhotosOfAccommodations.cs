using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data.Mapping;

namespace Olbrasoft.Travel.Data.Entity.Query.Handler
{
    public class PhotosOfAccommodations : HandlerWithDependentSource<GetPhotosOfAccommodations,
        IQueryable<PhotoOfAccommodation>, IEnumerable<AccommodationPhoto>>
    {
        public PhotosOfAccommodations(IHaveQueryable<PhotoOfAccommodation> source, IProjection projector) : base(source.Queryable, projector)
        {
        }
        
        public override IEnumerable<AccommodationPhoto> Handle(GetPhotosOfAccommodations query)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return projection;
        }

        private IQueryable<AccommodationPhoto> ProjectToQueryableOfAccommodationPhoto(IQueryable<PhotoOfAccommodation> source, GetPhotosOfAccommodations query)
        {
            var photoOfAccommodations = source.Include(p => p.PathToPhoto).Include(p => p.FileExtension);

            photoOfAccommodations = from p in photoOfAccommodations
                                    where query.AccommodationIds.Contains(p.AccommodationId)
                                    select p;

            if (query.OnlyDefaultPhotos) photoOfAccommodations = photoOfAccommodations.Where(p => p.IsDefault);

            return ProjectTo<AccommodationPhoto>(photoOfAccommodations);
        }

        public override async Task<IEnumerable<AccommodationPhoto>> HandleAsync(GetPhotosOfAccommodations query, CancellationToken cancellationToken)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return await projection.ToArrayAsync(cancellationToken);
        }

    }
}