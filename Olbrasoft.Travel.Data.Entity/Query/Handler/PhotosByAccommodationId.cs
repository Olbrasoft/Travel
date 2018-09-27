using Olbrasoft.Data.Mapping;
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
    public class PhotosByAccommodationId : AsyncHandlerWithDependentSource<GetPhotosByAccommodationId,
        IQueryable<PhotoOfAccommodation>,
        IEnumerable<AccommodationPhoto>>
    {
        public PhotosByAccommodationId(IHaveQueryable<PhotoOfAccommodation> source, IProjection projector) : base(source.Queryable, projector)
        {
        }

        public override async Task<IEnumerable<AccommodationPhoto>> HandleAsync(GetPhotosByAccommodationId query,
            CancellationToken cancellationToken)
        {
            var projection = ProjectToQueryableOfAccommodationPhoto(Source, query);

            return await projection.ToArrayAsync(cancellationToken);
        }

        private IQueryable<AccommodationPhoto> ProjectToQueryableOfAccommodationPhoto(
            IQueryable<PhotoOfAccommodation> source, GetPhotosByAccommodationId query)
        {
            var photoOfAccommodations = source
                .Include(p => p.PathToPhoto)
                .Include(p => p.FileExtension)
                .Where(p => p.AccommodationId == query.AccommodationId)
                .OrderBy(p => p.IsDefault);

            return ProjectTo<AccommodationPhoto>(photoOfAccommodations);
        }
    }
}