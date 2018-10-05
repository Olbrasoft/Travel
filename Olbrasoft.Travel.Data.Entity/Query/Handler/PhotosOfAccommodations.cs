using Olbrasoft.Data.Query;

using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data;
using Olbrasoft.Data.Mapping;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Query.Handler
{
    public class PhotosOfAccommodations : HandlerWithDependentSource<GetPhotosOfAccommodations,
       PhotoOfAccommodation, IEnumerable<AccommodationPhoto>>
    {
        public PhotosOfAccommodations(IHaveQueryable<PhotoOfAccommodation> ownerQueryable, IProjection projector) : base(ownerQueryable, projector)
        {
        }
        
        public override IEnumerable<AccommodationPhoto> Handle(GetPhotosOfAccommodations query)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return projection;
        }
        

        public override async Task<IEnumerable<AccommodationPhoto>> HandleAsync(GetPhotosOfAccommodations query, CancellationToken cancellationToken)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return await projection.ToArrayAsync(cancellationToken);
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
    }
}