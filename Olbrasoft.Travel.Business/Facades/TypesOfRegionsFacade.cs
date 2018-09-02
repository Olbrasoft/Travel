using System;
using System.Linq.Expressions;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.DataAccessLayer;

namespace Olbrasoft.Travel.Business.Facades
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