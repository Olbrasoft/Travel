﻿
using Olbrasoft.Travel.Data.Repository;
using System;
using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using Attribute = Olbrasoft.Travel.Data.Entity.Model.Property.Attribute;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    public class LocalizedAttributesDefaultLanguageImporter : Importer
    {
        private IReadOnlyDictionary<int, int> _attributesEanIdsToIds;

        protected IReadOnlyDictionary<int, int> AttributesEanIdsToIds
        {
            get => _attributesEanIdsToIds ?? (_attributesEanIdsToIds =
                       FactoryOfRepositories.MappedProperties<Attribute>().EanIdsToIds);

            set => _attributesEanIdsToIds = value;
        }

        protected HashSet<LocalizedAttribute> LocalizedAttributes = new HashSet<LocalizedAttribute>();

        public LocalizedAttributesDefaultLanguageImporter(IProvider provider, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, factoryOfRepositories, sharedProperties, logger)
        {
        }

        protected override void RowLoaded(string[] items)
        {
            if (!int.TryParse(items[0], out var attributeEanId) ||
                !AttributesEanIdsToIds.TryGetValue(attributeEanId, out var id)) return;

            var localizedAttribute = new LocalizedAttribute
            {
                Id = id,
                LanguageId = DefaultLanguageId,
                Description = items[2],
                CreatorId = CreatorId
            };

            LocalizedAttributes.Add(localizedAttribute);
        }

        public override void Import(string path)
        {
            LoadData(path);
            AttributesEanIdsToIds = null;

            if (LocalizedAttributes.Count <= 0) return;

            LogSave<LocalizedAttribute>();
            FactoryOfRepositories.OfLocalized<LocalizedAttribute>().BulkSave(LocalizedAttributes);
            LocalizedAttributes = null;
            LogSaved<LocalizedAttribute>();
        }

        public override void Dispose()
        {
            GC.SuppressFinalize(this);
            base.Dispose();
        }
    }
}