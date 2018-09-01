using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.DataAccessLayer;
using System;
using System.Linq.Expressions;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public class TypesOfRegionsFacade : TravelFacade<TypeOfRegion>, ITypesOfRegionsFacade
    {
        public TypesOfRegionsFacade(IBaseRepository<TypeOfRegion> repository) : base(repository)
        {
        }

        public TypeOfRegion Get(string name, params Expression<Func<TypeOfRegion, object>>[] includePaths)
        {
            return Repository.Find(typeOfRegion => typeOfRegion.Name == name, includePaths);
        }
    }
}