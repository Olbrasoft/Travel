using Olbrasoft.DataAccessLayer;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;
using System;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public class AccommodationsFacade : IAccommodationsFacade
    {
        private readonly IQuery<Accommodation> _accommodationQuery;

        public AccommodationsFacade(IQuery<Accommodation> accommodationQuery)
        {
            _accommodationQuery = accommodationQuery;
        }

        public IPageModel<AccommodationDataTransferObject>  Get(IPageInfo    pageInfo)
        {
            return new PageModel<AccommodationDataTransferObject>(null, new Paging(3, 2));

        }



    }
}