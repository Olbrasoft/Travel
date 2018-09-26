using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Data.Entity.Query.Handler
{
    public class PhotosOfAccommodations : HandlerWithDependentSource<GetPhotosOfAccommodations,
        IQueryable<PhotoOfAccommodation>, IEnumerable<AccommodationPhoto>>
    {
        public PhotosOfAccommodations(IHaveQueryable<PhotoOfAccommodation> queryableOwner) : base(queryableOwner.Queryable)
        {
        }

        public override IEnumerable<AccommodationPhoto> Handle(GetPhotosOfAccommodations query)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return projection;
        }

        private static IQueryable<AccommodationPhoto> ProjectToQueryableOfAccommodationPhoto(IQueryable<PhotoOfAccommodation> source, GetPhotosOfAccommodations query)
        {
            var photoOfAccommodations = source.Include(p => p.PathToPhoto).Include(p => p.FileExtension);

            photoOfAccommodations = from p in photoOfAccommodations
                                    where query.AccommodationIds.Contains(p.AccommodationId)
                                    select p;

            if (query.OnlyDefaultPhotos) photoOfAccommodations = photoOfAccommodations.Where(p => p.IsDefault);

            var result = from p in photoOfAccommodations
                         select new AccommodationPhoto
                         {
                             AccommodationId = p.AccommodationId,
                             Path = p.PathToPhoto.Path,
                             Name = p.FileName,
                             Extension = p.FileExtension.Extension
                         };

            return result;
        }

        public override async Task<IEnumerable<AccommodationPhoto>> HandleAsync(GetPhotosOfAccommodations query, CancellationToken cancellationToken)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return await projection.ToArrayAsync(cancellationToken);
        }
    }
}