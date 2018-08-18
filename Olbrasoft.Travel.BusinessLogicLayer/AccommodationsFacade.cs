using System;
using Olbrasoft.DataAccessLayer;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public class AccommodationsFacade: IAccommodationsFacade
    {
        private readonly IQuery<Accommodation> _accommodationQuery;

        public AccommodationsFacade(IQuery<Accommodation> accommodationQuery)
        {
            _accommodationQuery = accommodationQuery;
        }
        

        public IPageResult<AccommodationDataTransferObject> Get(IPageInfo pageInfo)
        {
            throw new NotImplementedException();
        }
    }
}