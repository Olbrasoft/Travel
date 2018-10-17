
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using Olbrasoft.Travel.Data.Repository;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class RegionsTypesOfCitiesImporter : RegionsTypesOfCitiesAndNeighborhoodsImporter
    {
        public RegionsTypesOfCitiesImporter(IProvider provider, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, factoryOfRepositories, sharedProperties, logger)
        {
            TypeOfRegionId = FactoryOfRepositories.GeographyNamesRepository<TypeOfRegion>().GetId("City");
            SubClassId = FactoryOfRepositories.GeographyNamesRepository<SubClass>().GetId("city");
        }
    }
}