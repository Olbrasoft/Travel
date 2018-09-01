using Olbrasoft.Travel.Data.Entities;
using System;
using System.Linq.Expressions;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface ITypesOfRegionsFacade : ITravelFacade<TypeOfRegion>
    {
        TypeOfRegion Get(string name, params Expression<Func<TypeOfRegion, object>>[] includeProperties);
    }
}