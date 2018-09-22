using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Repository;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class NeighborhoodsImporter : RegionsTypesOfCitiesAndNeighborhoodsImporter
    {
        public NeighborhoodsImporter(IProvider provider, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger)
            : base(provider, factoryOfRepositories, sharedProperties, logger)
        {
            TypeOfRegionId = FactoryOfRepositories.BaseNames<TypeOfRegion>().GetId("Neighborhood");
            SubClassId = FactoryOfRepositories.BaseNames<SubClass>().GetId("neighbor");
        }
    }
}