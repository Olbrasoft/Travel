using System.Collections.Generic;
using Olbrasoft.Shared;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IAccommodationsFacade
    {
        IEnumerable<AccommodationDataTransferObject> Get(PageInfo pageInfo);

    }
}