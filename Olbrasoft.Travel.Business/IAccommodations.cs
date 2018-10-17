using Olbrasoft.Collections.Generic;
using Olbrasoft.Pagination;

using Olbrasoft.Travel.Data.Transfer.Object;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Business
{
    public interface IAccommodations
    {
        AccommodationDetail Get(int id, int languageId);

        Task<AccommodationDetail> GetAsync(int id, int languageId, CancellationToken cancellationToken = default(CancellationToken));

        IResultWithTotalCount<AccommodationItem> Get(
            IPageInfo pagingSettings, int languageId, Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting
        );

        Task<IResultWithTotalCount<AccommodationItem>> GetAsync(
            IPageInfo pagingSettings,
            int languageId,
            Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting,
            CancellationToken cancellationToken = default(CancellationToken)
        );

        //Task<IPagedList<AccommodationItem>> GetAsync(
        //    IPageInfo pagingSettings,
        //    int languageId,
        //    Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting
        //);
    }
}