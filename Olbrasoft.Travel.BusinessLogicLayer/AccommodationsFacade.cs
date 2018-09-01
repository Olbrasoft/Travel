using Olbrasoft.Data.Entity;
using Olbrasoft.Shared.Collections.Generic;
using Olbrasoft.Shared.Pagination;
using Olbrasoft.Travel.Data.Entity;
using Olbrasoft.Travel.DataTransferObject;
using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Shared.Linq;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public class AccommodationsFacade : IAccommodationsFacade
    {
        protected ILocalizedPagedQuery<Accommodation> LocalizedPagedQueryOfAccommodation { get; }

        public AccommodationsFacade(ILocalizedPagedQuery<Accommodation> localizedPagedQueryOfAccommodation)
        {
            LocalizedPagedQueryOfAccommodation = localizedPagedQueryOfAccommodation;
        }


        public IPagedList<AccommodationDataTransferObject> AccommodationDataTransferObjects(IPageInfo pageInfo)
        {
            var accommodations = LocalizedPagedQueryOfAccommodation.Execute(pageInfo);

            var pagedListOfAccommodationDataTransferObject = Map(accommodations);

            return pagedListOfAccommodationDataTransferObject;
        }
       
        
        protected virtual IPagedList<AccommodationDataTransferObject> Map(IPagedList<Accommodation> pagedListOfAccommodation)
        {
            var queueOfAccommodationDataTransferObject = new Queue<AccommodationDataTransferObject>();

            foreach (var accommodation in pagedListOfAccommodation)
            {
                var adto = new AccommodationDataTransferObject
                {
                    Id = accommodation.Id,
                    Address = accommodation.Address,
                    Name = accommodation.LocalizedAccommodations.FirstOrDefault()?.Name,
                    Location = accommodation.LocalizedAccommodations.FirstOrDefault()?.Location
                };

                queueOfAccommodationDataTransferObject.Enqueue(adto);
            }
            
           return queueOfAccommodationDataTransferObject.AsPagedList(pagedListOfAccommodation.AsPagination());
        }
    }
}