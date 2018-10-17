﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Olbrasoft.Travel.Data.Entity.Model.Routing;
using Olbrasoft.Travel.Data.Repository.Routing;

namespace Olbrasoft.Travel.Data.Entity.Repository.Routing
{
    public class PathsToPhotosRepository : RoutingRepository<PathToPhoto>, IPathsToPhotosRepository

    {
        private IReadOnlyDictionary<string, int> _pathsToIds;

        public IReadOnlyDictionary<string, int> PathsToIds
        {
            get
            {
                return _pathsToIds ?? (_pathsToIds = AsQueryable().Select(ptp => new { ptp.Path, ptp.Id })
                     .ToDictionary(k => k.Path, v => v.Id));
            }

            private set => _pathsToIds = value;
        }

        private HashSet<string> _paths;

        public HashSet<string> Paths
        {
            get { return _paths ?? (_paths = new HashSet<string>(AsQueryable().Select(ptp => ptp.Path))); }

            private set => _paths = value;
        }

        public PathsToPhotosRepository(RoutingDatabaseContext context) : base(context)
        {
        }

        public void BulkSave(IEnumerable<PathToPhoto> entities, int batchSize,
            params Expression<Func<PathToPhoto, object>>[] ignorePropertiesWhenUpdating)
        {
            BulkInsert(entities.Where(ptp => ptp.Id == 0 && !Paths.Contains(ptp.Path)), batchSize);
        }

        public void BulkSave(IEnumerable<PathToPhoto> entities, params Expression<Func<PathToPhoto, object>>[] ignorePropertiesWhenUpdating)
        {
            BulkSave(entities, 90000, ignorePropertiesWhenUpdating);
        }

        public override void ClearCache()
        {
            Paths = null;
            PathsToIds = null;
            base.ClearCache();
        }
    }
}