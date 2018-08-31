﻿using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface IAccommodationsFacade : IFacade
    {
        IPagedEnumerable<AccommodationDataTransferObject> AccommodationDataTransferObjects(IPageInfo pageInfo);
    }
}