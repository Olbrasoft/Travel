using System.Collections.Generic;
using Olbrasoft.DataAccessLayer;
using Olbrasoft.Shared;
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
        

        public IEnumerable<AccommodationDataTransferObject> Get(PageInfo pageInfo)
        {
            throw new System.NotImplementedException();
        }
    }
}