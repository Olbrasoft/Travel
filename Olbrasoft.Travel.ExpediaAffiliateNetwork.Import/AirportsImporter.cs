﻿using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Repository;
using Olbrasoft.Travel.Data.Repository.Geography;
using Olbrasoft.Travel.Expedia.Affiliate.Network;
using Olbrasoft.Travel.Expedia.Affiliate.Network.Data.Transfer.Object.Geography;
using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Repository.Globalization;
using Country = Olbrasoft.Travel.Data.Entity.Model.Geography.Country;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class AirportsImporter : Importer<AirportCoordinates>
    {
        public AirportsImporter(IProvider provider, IParserFactory parserFactory, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, parserFactory, factoryOfRepositories, sharedProperties, logger)
        {
        }

        public override void Import(string path)
        {
            LoadData(path);

            var airportsCoordinates = EanDataTransferObjects.ToArray();
            EanDataTransferObjects = null;

            var regionsEanIdsToIds =
                ImportRegions(airportsCoordinates, FactoryOfRepositories.Regions(), CreatorId);

            ImportLocalizedRegions(airportsCoordinates, FactoryOfRepositories.OfLocalized<LocalizedRegion>(), regionsEanIdsToIds, DefaultLanguageId, CreatorId);

            ImportAirports(airportsCoordinates, FactoryOfRepositories.AdditionalRegionsInfo<Airport>(), regionsEanIdsToIds, CreatorId);

            ImportRegionsToTypes(airportsCoordinates, FactoryOfRepositories.RegionsToTypes(), regionsEanIdsToIds,
                FactoryOfRepositories.GeographyNamesRepository<TypeOfRegion>().GetId("Airport"),
                FactoryOfRepositories.GeographyNamesRepository<SubClass>().GetId("airport"));

            ImportRegionsToRegions(airportsCoordinates, FactoryOfRepositories.GeographyManyToMany<RegionToRegion>(),
                regionsEanIdsToIds, FactoryOfRepositories.AdditionalRegionsInfo<Country>().CodesToIds,
                CreatorId);
        }

        private void ImportRegionsToRegions(
            IEnumerable<AirportCoordinates> airportsCoordinates,
            IOfManyToMany<RegionToRegion> repository,
            IReadOnlyDictionary<long, int> regionsEanIdsToIds,
            IReadOnlyDictionary<string, int> eanCountryCodeToIds,
            int creatorId
        )
        {
            LogBuild<RegionToRegion>();
            var regionsToRegions = BuildRegionsToRegions(airportsCoordinates, regionsEanIdsToIds,
                eanCountryCodeToIds, creatorId);
            var count = regionsToRegions.Length;
            LogAssembled(count);

            if (count <= 0) return;
            LogSave<RegionToRegion>();
            repository.BulkSave(regionsToRegions, count);
            LogSaved<RegionToRegion>();
        }

        private RegionToRegion[] BuildRegionsToRegions(IEnumerable<AirportCoordinates> eanAirportsCoordinates,
            IReadOnlyDictionary<long, int> eanRegionIdsToIds,
            IReadOnlyDictionary<string, int> eanCountryCodeToIds,
            int creatorId
        )
        {
            var regionToRegions = new Queue<RegionToRegion>();

            foreach (var eanAirport in eanAirportsCoordinates)
            {
                if (!eanRegionIdsToIds.TryGetValue(eanAirport.AirportID, out var id))
                {
                    WriteLog($"Not found AirportID {eanAirport.AirportID}");
                    continue;
                }

                if (eanAirport.MainCityID != null)
                {
                    var cityId = (long)eanAirport.MainCityID;

                    if (eanRegionIdsToIds.TryGetValue(cityId, out var toId))
                    {
                        var regionToRegion = new RegionToRegion
                        {
                            Id = id,
                            ToId = toId,
                            CreatorId = creatorId
                        };

                        regionToRegions.Enqueue(regionToRegion);
                    }
                    else
                    {
                        WriteLog($"Not found MainCityID {eanAirport.AirportID}");
                    }
                }

                if (!eanCountryCodeToIds.TryGetValue(eanAirport.CountryCode, out var toId1)) continue;
                {
                    var regionToRegion = new RegionToRegion
                    {
                        Id = id,
                        ToId = toId1,
                        CreatorId = creatorId
                    };

                    regionToRegions.Enqueue(regionToRegion);
                }
            }

            return regionToRegions.ToArray();
        }

        private void ImportRegionsToTypes(
            IEnumerable<AirportCoordinates> airportsCoordinates,
            IRegionsToTypesRepository repository,
            IReadOnlyDictionary<long, int> eanIdsToIds,
            int typeOfRegionAirportId, int subClassAirportId)
        {
            LogBuild<RegionToType>();
            var regionsToTypes =
                BuildRegionsToTypes(airportsCoordinates, eanIdsToIds, typeOfRegionAirportId, subClassAirportId, CreatorId);
            var count = regionsToTypes.Length;
            LogAssembled(count);

            if (count <= 0) return;

            LogSave<RegionToType>();
            repository.BulkSave(regionsToTypes);
            LogSaved<RegionToType>();
        }

        private static RegionToType[] BuildRegionsToTypes(IEnumerable<AirportCoordinates> eanAirportsCoordinates,
            IReadOnlyDictionary<long, int> eanAirportIdsToIds,
            int typeOfRegionAirportId,
            int subClassAirportId,
            int creatorId
        )
        {
            var regionsToTypes = new Queue<RegionToType>();

            foreach (var entity in eanAirportsCoordinates)
            {
                if (!eanAirportIdsToIds.TryGetValue(entity.AirportID, out var id)) continue;

                var regionToType = new RegionToType
                {
                    Id = id,
                    ToId = typeOfRegionAirportId,
                    SubClassId = subClassAirportId,
                    CreatorId = creatorId
                };

                regionsToTypes.Enqueue(regionToType);
            }
            return regionsToTypes.ToArray();
        }

        private void ImportAirports(
            IEnumerable<AirportCoordinates> airportsCoordinates,
            IAdditionalRegionsInfoRepository<Airport> repository,
            IReadOnlyDictionary<long, int> eanIdsToIds,
            int creatorId

        )
        {
            LogBuild<Airport>();
            var airports = BuildAirports(airportsCoordinates, eanIdsToIds, creatorId);
            var count = airports.Length;
            LogAssembled(count);

            if (count <= 0) return;

            LogSave<Airport>();
            repository.BulkSave(airports, count);
            LogSaved<Airport>();
        }

        private static Airport[] BuildAirports(
            IEnumerable<AirportCoordinates> eanAirportsCoordinates,
            IReadOnlyDictionary<long, int> eanAirportIdsToIds,
            int creatorId
        )
        {
            var airports = new Queue<Airport>();

            foreach (var eanAirport in eanAirportsCoordinates)
            {
                if (!eanAirportIdsToIds.TryGetValue(eanAirport.AirportID, out var id)) continue;

                var airport = new Airport()
                {
                    Id = id,
                    Code = eanAirport.AirportCode,
                    CreatorId = creatorId
                };

                airports.Enqueue(airport);
            }

            return airports.ToArray();
        }

        private void ImportLocalizedRegions(
            IEnumerable<AirportCoordinates> airportsCoordinates,
            IOfLocalized<LocalizedRegion> repository,
            IReadOnlyDictionary<long, int> eanIdsToIds,
            int languageId,
            int creatorId
        )
        {
            LogBuild<LocalizedRegion>();
            var localizedRegions = BuildLocalizedRegions(airportsCoordinates, eanIdsToIds,
                languageId, creatorId);
            var count = localizedRegions.Length;
            LogAssembled(count);

            if (count <= 0) return;

            LogSave<LocalizedRegion>();
            repository.BulkSave(localizedRegions, count);
            LogSaved<LocalizedRegion>();
        }

        private static LocalizedRegion[] BuildLocalizedRegions(
            IEnumerable<AirportCoordinates> airportsCoordinates,
            IReadOnlyDictionary<long, int> eanAirportIdsToIds,
            int languageId,
            int creatorId
        )
        {
            var localizedRegions = new Queue<LocalizedRegion>();

            foreach (var eanAirport in airportsCoordinates)
            {
                if (!eanAirportIdsToIds.TryGetValue(eanAirport.AirportID, out var id)) continue;

                var localizedRegion = new LocalizedRegion()
                {
                    Id = id,
                    LanguageId = languageId,
                    Name = eanAirport.AirportName,
                    CreatorId = creatorId
                };

                localizedRegions.Enqueue(localizedRegion);
            }

            return localizedRegions.ToArray();
        }

        private IReadOnlyDictionary<long, int> ImportRegions(
            IEnumerable<AirportCoordinates> airportsCoordinates,
            IRegionsRepository repository,
            int creatorId)
        {
            LogBuild<Region>();
            var regions = BuildRegions(airportsCoordinates, creatorId);
            var count = regions.Length;
            LogAssembled(count);

            if (count <= 0) return repository.EanIdsToIds;

            LogSave<Region>();
            repository.BulkSave(regions, r => r.Coordinates, r => r.EanId);
            LogSaved<Region>();

            return repository.EanIdsToIds;
        }

        private static Region[] BuildRegions(IEnumerable<AirportCoordinates> eanAirportCoordinates,
            int creatorId
        )
        {
            var regions = new Queue<Region>();

            foreach (var eanAirport in eanAirportCoordinates)
            {
                var region = new Region
                {
                    CenterCoordinates = CreatePoint(eanAirport.Latitude, eanAirport.Longitude),
                    EanId = eanAirport.AirportID,
                    CreatorId = creatorId
                };

                regions.Enqueue(region);
            }

            return regions.ToArray();
        }
    }
}