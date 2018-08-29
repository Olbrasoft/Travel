using Olbrasoft.Data.Entity;
using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;
using X.PagedList;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public class AccommodationsFacade : IAccommodationsFacade
    {

        protected ILocalizedPagedQuery<Accommodation> Accommodations { get; }


        public AccommodationsFacade(ILocalizedPagedQuery<Accommodation> accommodations)
        {
            Accommodations = accommodations;
        }
        
        public IPagedList<AccommodationDataTransferObject> AccommodationDataTransferObjects(IPageInfo pageInfo)
        {
            var accommodations = Accommodations.Execute(pageInfo);

            var accommodationDataTransferObjects = Map(accommodations);

            return accommodationDataTransferObjects;
        }


        protected virtual IPagedList<AccommodationDataTransferObject> Map(IPagedList<Accommodation> pagedList)
        {
            return new PagedCollection<AccommodationDataTransferObject>(new AccommodationDataTransferObject[0],
                new PageInfo(), 0);
        }




    }
}