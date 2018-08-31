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
        protected ILocalizedPagedQuery<Accommodation> Accommodations { get; }

        public AccommodationsFacade(ILocalizedPagedQuery<Accommodation> accommodations)
        {
            Accommodations = accommodations;
        }


        public IPagedEnumerable<AccommodationDataTransferObject> AccommodationDataTransferObjects(IPageInfo pageInfo)
        {
            var accommodations = Accommodations.Execute(pageInfo);

            var accommodationDataTransferObjects = Map(accommodations);

            return accommodationDataTransferObjects;
        }
        
        
        protected virtual IPagedEnumerable<AccommodationDataTransferObject> Map(IPagedEnumerable<Accommodation> pagedEnumerable)
        {
            var accommodationDataTransferObjects = new Queue<AccommodationDataTransferObject>();

            foreach (var accommodation in pagedEnumerable)
            {
                var adto = new AccommodationDataTransferObject
                {
                    Id = accommodation.Id,
                    Address = accommodation.Address,
                    Name = accommodation.LocalizedAccommodations.FirstOrDefault()?.Name,
                    Location = accommodation.LocalizedAccommodations.FirstOrDefault()?.Location
                };

                accommodationDataTransferObjects.Enqueue(adto);
            }

            var pagedCollection = accommodationDataTransferObjects.AsPagedEnumerable(pagedEnumerable.Pagination);
             
            return pagedCollection;
        }
    }
}