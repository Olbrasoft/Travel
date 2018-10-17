﻿using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Repository.Geography;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Olbrasoft.Travel.Data.Entity.Repositories.Geography
{
    public class AdditionalRegionsInfoRepository<T> : GeographyRepository<T>, IAdditionalRegionsInfoRepository<T>
        where T : OwnerCreatorIdAndCreator, IAdditionalRegionInfo
    {
        private IEnumerable<int> _ids;

        protected IEnumerable<int> Ids
        {
            get { return _ids ?? (_ids = GetAll(p => p.Id)); }

            private set => _ids = value;
        }

        private IReadOnlyDictionary<string, int> _codesToIds;

        public IReadOnlyDictionary<string, int> CodesToIds
        {
            get
            {
                return _codesToIds ??
                       (_codesToIds = GetAll(c => new {c.Code, c.Id}).ToDictionary(k => k.Code, v => v.Id));
            }

            private set => _codesToIds = value;
        }

        public void BulkSave(IEnumerable<T> additionalRegionsInfo, int batchSize, params Expression<Func<T, object>>[] ignorePropertiesWhenUpdating)
        {
            var forInsert = new Queue<T>();
            var forUpdate = new Queue<T>();
            var ids = new HashSet<int>(Ids);

            foreach (var item in additionalRegionsInfo)
            {
                if (ids.Contains(item.Id))
                {
                    forUpdate.Enqueue(item);
                }
                else
                {
                    forInsert.Enqueue(item);
                }
            }

            if (forInsert.Count > 0) BulkInsert(forInsert, batchSize);

            if (forUpdate.Count > 0) BulkUpdate(forUpdate, batchSize, ignorePropertiesWhenUpdating);
        }

        public void BulkSave(IEnumerable<T> additionalRegionsInfo, params Expression<Func<T, object>>[] ignorePropertiesWhenUpdating)
        {
            BulkSave(additionalRegionsInfo, 90000, ignorePropertiesWhenUpdating);
        }

        public override void ClearCache()
        {
            Ids = null;
            CodesToIds = null;
            base.ClearCache();
        }

        public AdditionalRegionsInfoRepository(Entity.GeographyDatabaseContext context) : base(context)
        {
        }
    }
}