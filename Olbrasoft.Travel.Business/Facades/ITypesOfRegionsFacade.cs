using System;
using System.Linq.Expressions;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface ITypesOfRegionsFacade : ITravelFacade<TypeOfRegion>
    {
        TypeOfRegion Get(string name, params Expression<Func<TypeOfRegion, object>>[] includeProperties);
    }
}