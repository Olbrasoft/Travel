﻿
using Olbrasoft.Travel.Data.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using Olbrasoft.Travel.Data.Entity.Model.Routing;
using Olbrasoft.Travel.Data.Repository.Routing;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    public class PathsExtensionsCaptionsImporter : Importer
    {
        private IReadOnlyDictionary<int, int> _accommodationsEanIdsToIds;

        private IReadOnlyDictionary<int, int> AccommodationsEanIdsToIds
        {
            get =>
            _accommodationsEanIdsToIds ?? (_accommodationsEanIdsToIds =
            FactoryOfRepositories.MappedProperties<Accommodation>().EanIdsToIds);
            set => _accommodationsEanIdsToIds = value;
        }

        protected HashSet<string> Paths = new HashSet<string>();
        protected HashSet<string> Extensions = new HashSet<string>();
        protected HashSet<string> Captions = new HashSet<string>();

        public PathsExtensionsCaptionsImporter(IProvider provider, IFactoryOfRepositories factoryOfRepositories,
            SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, factoryOfRepositories, sharedProperties, logger)
        {
        }

        public override void Import(string path)
        {
            LoadData(path);

            ImportPathsToPhotos(Paths, FactoryOfRepositories.PathsToPhotos(), CreatorId);

            ImportFilesExtensions(Extensions, FactoryOfRepositories.FilesExtensions(), CreatorId);

            ImportLocalizedCaptions(Captions, FactoryOfRepositories.LocalizedCaptions(), DefaultLanguageId, CreatorId);
        }

        private void ImportPathsToPhotos(IEnumerable<string> paths, IPathsToPhotosRepository repository, int creatorId)
        {
            LogBuild<PathToPhoto>();
            var pathsToPhotos = paths.Select(p => new PathToPhoto { Path = p, CreatorId = creatorId }).ToArray();
            var count = pathsToPhotos.Length;
            LogAssembled(count);

            if (count <= 0) return;
            LogSave<PathToPhoto>();
            repository.BulkSave(pathsToPhotos);
            LogSaved<PathToPhoto>();
        }

        private void ImportFilesExtensions(IEnumerable<string> extensions, IFilesExtensionsRepository repository,
            int creatorId)
        {
            LogBuild<FileExtension>();
            var filesExtensions = extensions.Select(p => new FileExtension { Extension = p, CreatorId = creatorId })
                .ToArray();
            var count = filesExtensions.Length;
            LogAssembled(count);

            if (count <= 0) return;
            LogSave<FileExtension>();
            repository.Save(filesExtensions);
            LogSaved<FileExtension>();
        }

        private void ImportLocalizedCaptions(IEnumerable<string> captions, IOfLocalizedCaptions repository,
            int languageId, int creatorId)
        {
            LogBuild<LocalizedCaption>();
            var localizedCaptions = captions
                .Select(p => new LocalizedCaption() { Text = p, LanguageId = languageId, CreatorId = creatorId })
                .ToArray();
            var count = localizedCaptions.Length;
            LogAssembled(count);

            if (count <= 0) return;
            LogSave<LocalizedCaption>();
            repository.BulkSave(localizedCaptions);
            LogSaved<LocalizedCaption>();
        }

        protected override void RowLoaded(string[] items)
        {
            var eanHotelId = int.Parse(items[0]);

            if (!AccommodationsEanIdsToIds.ContainsKey(eanHotelId)) return;

            var caption = items[1];

            if (!string.IsNullOrEmpty(caption) && !Captions.Contains(caption)) Captions.Add(caption);

            var url = items[2];

            var path = ParsePath(url);

            if (!Paths.Contains(path)) Paths.Add(path);

            var extension = RemoveDots(Path.GetExtension(url)?.ToLower());

            if (!Extensions.Contains(extension)) Extensions.Add(extension);
        }

        public override void Dispose()
        {
            AccommodationsEanIdsToIds = null;
            Paths = null;
            Extensions = null;
            Captions = null;

            GC.SuppressFinalize(this);
            base.Dispose();
        }
    }
}