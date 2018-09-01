using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public class AccommodationsFacade : IAccommodationsFacade
    {
        protected ILocalizedPagedQuery<Accommodation> LocalizedPagedQueryOfAccommodation { get; }

        public AccommodationsFacade(ILocalizedPagedQuery<Accommodation> localizedPagedQueryOfAccommodation)
        {
            LocalizedPagedQueryOfAccommodation = localizedPagedQueryOfAccommodation;
        }


        public IPagedList<AccommodationDto> AccommodationDataTransferObjects(IPageInfo pageInfo)
        {
            var accommodations = LocalizedPagedQueryOfAccommodation.Execute(pageInfo);

            var pagedListOfAccommodationDataTransferObject = Map(accommodations);

            return pagedListOfAccommodationDataTransferObject;
        }
       
        
        protected virtual IPagedList<AccommodationDto> Map(IPagedList<Accommodation> pagedListOfAccommodation)
        {
            var queueOfAccommodationDataTransferObject = new Queue<AccommodationDto>();

            foreach (var accommodation in pagedListOfAccommodation)
            {
                var adto = new AccommodationDto
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