﻿using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Travel.Data.Entity.Model.Routing;
using Olbrasoft.Travel.Data.Repository.Routing;

namespace Olbrasoft.Travel.Data.Entity.Repository.Routing
{
    public class FilesExtensionsRepository : RoutingRepository<FileExtension>, IFilesExtensionsRepository
    {
        private IReadOnlyDictionary<string, int> _extensionsToIds;
        private HashSet<string> _extensions;

        public IReadOnlyDictionary<string, int> ExtensionsToIds
        {
            get
            {
                return _extensionsToIds ?? (_extensionsToIds = AsQueryable().Select(fe => new { fe.Extension, fe.Id })
                           .ToDictionary(k => k.Extension, v => v.Id));
            }

            private set => _extensionsToIds = value;
        }

        public HashSet<string> Extensions
        {
            get
            {
                if (_extensions != null) return _extensions;
                _extensions = _extensionsToIds != null ?
                    new HashSet<string>(_extensionsToIds.Keys) : new HashSet<string>(AsQueryable().Select(p => p.Extension));

                return _extensions;
            }

            private set => _extensions = value;
        }

        public FilesExtensionsRepository(RoutingDatabaseContext context) : base(context)
        {
        }

        public void Save(IEnumerable<FileExtension> filesExtensions)
        {
            var filesExtensionsArray = filesExtensions as FileExtension[] ?? filesExtensions.ToArray();

            Update(filesExtensionsArray.Where(p => p.Id != 0));

            Add(filesExtensionsArray.Where(p => p.Id == 0 && !Extensions.Contains(p.Extension)));
        }

        public override void ClearCache()
        {
            Extensions = null;
            ExtensionsToIds = null;
            base.ClearCache();
        }
    }
}