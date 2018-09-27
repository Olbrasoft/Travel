﻿using Olbrasoft.Data.Query;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Query;
using Olbrasoft.Travel.Data.Transfer.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Olbrasoft.Travel.Business.Facades
{
    public class AccommodationsFacade : IAccommodations
    {
        protected IProvider QueryProvider { get; }
        protected IAccommodationItemPhotoMerge Merger { get; }

        public AccommodationsFacade(IProvider queryProvider, IAccommodationItemPhotoMerge merger)
        {
            QueryProvider = queryProvider;
            Merger = merger;
        }

        public AccommodationDetail Get(int id, int languageId)
        {
            var query = GetAccommodationDetailById(id, languageId);

            return query.Execute();
        }

        public async Task<AccommodationDetail> GetAsync(int id, int languageId, CancellationToken cancellationToken = default(CancellationToken))
        {
            var query = GetAccommodationDetailById(id, languageId);

            var accommodationDetail = await query.ExecuteAsync(cancellationToken);

            var getPhotosByAccommodationId = GetPhotosByAccommodationId(id);

            var accommodationPhotos = await getPhotosByAccommodationId.ExecuteAsync(cancellationToken);

            accommodationDetail.Photos =
                accommodationPhotos.Select(p =>
                    $"https://i.travelapi.com/hotels/{p.Path}/{p.Name}{p.Extension}").ToArray();

            return accommodationDetail;
        }

        private GetPhotosByAccommodationId GetPhotosByAccommodationId(int accommodationId)
        {
            var query = QueryProvider.Create<GetPhotosByAccommodationId>();
            query.AccommodationId = accommodationId;
            return query;
        }

        public IResultWithTotalCount<AccommodationItem> Get(IPageInfo pagingSettings, int languageId, Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting)
        {
            var query = GetPagedAccommodationItems(pagingSettings, languageId, sorting);
            var accommodationItems = query.Execute();

            var getDefaultPhotosOfAccommodations = GetDefaultPhotosOfAccommodations(accommodationItems.Result.Select(p => p.Id));

            var photosOfAccommodations = getDefaultPhotosOfAccommodations.Execute();

            accommodationItems = MergePhotos(accommodationItems, photosOfAccommodations);

            return accommodationItems;
        }

        public async Task<IResultWithTotalCount<AccommodationItem>> GetAsync(
            IPageInfo pagingSettings,
            int languageId,
            Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting,
            CancellationToken cancellationToken = default(CancellationToken)
        )
        {
            var query = GetPagedAccommodationItems(pagingSettings, languageId, sorting);

            var accommodationItems = await query.ExecuteAsync(cancellationToken);

            var getDefaultPhotosOfAccommodations = GetDefaultPhotosOfAccommodations(accommodationItems.Result.Select(p => p.Id));

            var photosOfAccommodations = await getDefaultPhotosOfAccommodations.ExecuteAsync(cancellationToken);

            accommodationItems = MergePhotos(accommodationItems, photosOfAccommodations);

            return accommodationItems;
        }

        private IResultWithTotalCount<AccommodationItem> MergePhotos(IResultWithTotalCount<AccommodationItem> master, IEnumerable<AccommodationPhoto> slave)
        {
            return Merger.Merge(master, slave);
        }

        private GetPhotosOfAccommodations GetDefaultPhotosOfAccommodations(IEnumerable<int> accommodationIds)
        {
            var query = QueryProvider.Create<GetPhotosOfAccommodations>();
            query.AccommodationIds = accommodationIds;
            query.OnlyDefaultPhotos = true;
            return query;
        }

        private GetPagedAccommodationItems GetPagedAccommodationItems(
            IPageInfo pagingSettings, int languageId, Func<IQueryable<LocalizedAccommodation>, IOrderedQueryable<LocalizedAccommodation>> sorting
        )
        {
            var query = QueryProvider.Create<GetPagedAccommodationItems>();
            query.Paging = pagingSettings;
            query.LanguageId = languageId;
            query.Sorting = sorting;
            return query;
        }

        private GetAccommodationDetailById GetAccommodationDetailById(int id, int languageId)
        {
            var query = QueryProvider.Create<GetAccommodationDetailById>();

            query.Id = id;
            query.LanguageId = languageId;
            return query;
        }
    }
}