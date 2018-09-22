﻿using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Repository;
using Olbrasoft.Travel.Expedia.Affiliate.Network;
using Olbrasoft.Travel.Expedia.Affiliate.Network.Data.Transfer.Object.Geography;
using System.Collections.Generic;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class TrainMetroStationsImporter : Importer<TrainMetroStationCoordinates>
    {
        public TrainMetroStationsImporter(IProvider provider, IParserFactory parserFactory, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, parserFactory, factoryOfRepositories, sharedProperties, logger)
        {
        }

        public override void Import(string path)
        {
            LoadData(path);

            var eanIdsToIds = ImportRegions(EanDataTransferObjects, FactoryOfRepositories.Regions(), CreatorId);

            ImportLocalizedRegions(EanDataTransferObjects, FactoryOfRepositories.Localized<LocalizedRegion>(), eanIdsToIds,
                DefaultLanguageId, CreatorId);

            ImportRegionsToTypes(EanDataTransferObjects, FactoryOfRepositories.RegionsToTypes(), eanIdsToIds,
                FactoryOfRepositories.BaseNames<TypeOfRegion>().GetId("Train Station"),
                FactoryOfRepositories.BaseNames<SubClass>().GetId("train"), CreatorId);

            EanDataTransferObjects = null;
        }

        private void ImportRegionsToTypes(
            IEnumerable<TrainMetroStationCoordinates> trainsMetroStationCoordinateses,
            IRegionsToTypesRepository repository,
            IReadOnlyDictionary<long, int> eanIdsToIds,
            int typeOfRegionTrainStationId,
            int subClassTrainId,
            int creatorId
            )
        {
            LogBuild<RegionToType>();

            var regionsToTypes = BuildRegionsToTypes(trainsMetroStationCoordinateses, eanIdsToIds,
                typeOfRegionTrainStationId, subClassTrainId, creatorId);

            var count = regionsToTypes.Length;

            LogBuilded(count);

            if (count <= 0) return;

            LogSave<RegionToType>();
            repository.BulkSave(regionsToTypes);
            LogSaved<RegionToType>();
        }

        //private void ImportLocalizedRegions(
        //    IEnumerable<TrainMetroStationCoordinates> trainsMetroStationCoordinateses,
        //    ILocalizedRepository<LocalizedRegion> repository,
        //    IReadOnlyDictionary<long, int> eanIdsToIds,
        //    int languageId,
        //    int creatorId

        //    )
        //{
        //    LogBuild<LocalizedRegion>();
        //    var localizedRegions = BuildLocalizedRegions(trainsMetroStationCoordinateses, eanIdsToIds, languageId, creatorId);
        //    var count = localizedRegions.Length;
        //    LogBuilded(count);

        //    if (count <= 0) return;
        //    LogSave<LocalizedRegion>();
        //    repository.BulkSave(localizedRegions, count);
        //    LogSaved<LocalizedRegion>();
        //}

        private IReadOnlyDictionary<long, int> ImportRegions(
            IEnumerable<TrainMetroStationCoordinates> trainsMetroStationCoordinateses,
            IRegionsRepository repository,
            int creatorId
            )
        {
            LogBuild<Region>();
            var regions = BuildRegions(trainsMetroStationCoordinateses, creatorId);
            var count = regions.Length;
            LogBuilded(count);

            if (count <= 0) return repository.EanIdsToIds;

            LogSave<Region>();
            repository.BulkSave(regions, r => r.Coordinates);
            LogSaved<Region>();

            return repository.EanIdsToIds;
        }
    }
}