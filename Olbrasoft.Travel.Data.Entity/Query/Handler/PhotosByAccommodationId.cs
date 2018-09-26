using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Entity.Query.Handler
{
    public class PhotosByAccommodationId : AsyncHandlerWithDependentSource<GetPhotosByAccommodationId, IQueryable<PhotoOfAccommodation>,
        IEnumerable<AccommodationPhoto>>
    {
        public PhotosByAccommodationId(IHaveQueryable<PhotoOfAccommodation> source) : base(source.Queryable)
        {
        }

        public override async Task<IEnumerable<AccommodationPhoto>> HandleAsync(GetPhotosByAccommodationId query, CancellationToken cancellationToken)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return await projection.ToArrayAsync(cancellationToken);
        }

        private static IQueryable<AccommodationPhoto> ProjectToQueryableOfAccommodationPhoto(IQueryable<PhotoOfAccommodation> source, GetPhotosByAccommodationId query)
        {
            var photoOfAccommodations = source
                .Include(p => p.PathToPhoto)
                .Include(p => p.FileExtension)
                .Where(p => p.AccommodationId == query.AccommodationId)
                .OrderBy(p=>p.IsDefault);

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
    }
}