using Olbrasoft.Collections.Generic;
using Olbrasoft.Data.Unit.Tests;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Data.Unit.Tests
{
    public interface IPagedListOfAccommodationItemLocalizedQuery : ILocalizedQuery<IPagedList<IAccommodationItem>>, IPagedQuery<ILocalizedAccommodation, IPagedList<IAccommodationItem>>
    {
    }
}