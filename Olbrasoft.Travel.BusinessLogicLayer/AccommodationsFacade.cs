
using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Shared.Pagination.Web.Mvc;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public class AccommodationsFacade : IAccommodationsFacade
    {
        private readonly IQuery<Accommodation> _accommodationQuery;

        public AccommodationsFacade(IQuery<Accommodation> accommodationQuery)
        {
            _accommodationQuery = accommodationQuery;
        }

        public IPageModel<AccommodationDataTransferObject> Get(IPageInfo pageInfo)
        {
            var data = new AccommodationDataTransferObject[0];
            return new PageModel<AccommodationDataTransferObject>(data, new Paging(3, 2));
        }




    }
}