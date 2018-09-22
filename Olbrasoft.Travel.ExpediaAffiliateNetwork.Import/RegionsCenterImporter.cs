﻿using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Repository;
using Olbrasoft.Travel.Expedia.Affiliate.Network;
using Olbrasoft.Travel.Expedia.Affiliate.Network.Data.Transfer.Object.Geography;
using System.Collections.Generic;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class RegionsCenterImporter : Importer<RegionCenter>
    {
        public RegionsCenterImporter(IProvider provider, IParserFactory parserFactory, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, parserFactory, factoryOfRepositories, sharedProperties, logger)
        {
        }

        public override void Import(string path)
        {
            LoadData(path);

            var eanIdsToIds = ImportRegions(EanDataTransferObjects, FactoryOfRepositories.Regions(), CreatorId);

            ImportLocalizedRegions(EanDataTransferObjects, FactoryOfRepositories.Localized<LocalizedRegion>(), eanIdsToIds,
                DefaultLanguageId, CreatorId);

            EanDataTransferObjects = null;
        }

        private IReadOnlyDictionary<long, int> ImportRegions(
            IEnumerable<RegionCenter> regionsCenter,
            IRegionsRepository repository,
            int creatorId
        )
        {
            LogBuild<Region>();
            var regions = BuildRegions(regionsCenter, creatorId);
            var count = regions.Length;
            LogBuilded(count);

            if (count <= 0) return repository.EanIdsToIds;

            LogSave<Region>();
            repository.BulkSave(regions, r => r.Coordinates);
            LogSaved<Region>();

            return repository.EanIdsToIds;
        }

        private static Region[] BuildRegions(IEnumerable<RegionCenter> eanEntities,
            int creatorId
        )
        {
            var regions = new Queue<Region>();
            foreach (var eanEntity in eanEntities)
            {
                var region = new Region
                {
                    CenterCoordinates = CreatePoint(eanEntity.CenterLatitude, eanEntity.CenterLongitude),
                    EanId = eanEntity.RegionID,
                    CreatorId = creatorId
                };

                regions.Enqueue(region);
            }
            return regions.ToArray();
        }
    }
}