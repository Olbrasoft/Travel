﻿using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataAccessLayer;

namespace Olbrasoft.Travel.ExpediaAffiliateNetwork.Import
{
    internal class RegionsTypesOfCitiesImporter : RegionsTypesOfCitiesAndNeighborhoodsImporter
    {
        public RegionsTypesOfCitiesImporter(IProvider provider, IFactoryOfRepositories factoryOfRepositories, SharedProperties sharedProperties, ILoggingImports logger) 
            : base(provider, factoryOfRepositories, sharedProperties, logger)
        {
            TypeOfRegionId = FactoryOfRepositories.BaseNames<TypeOfRegion>().GetId("City");
            SubClassId = FactoryOfRepositories.BaseNames<SubClass>().GetId("city");
        }
    }
}