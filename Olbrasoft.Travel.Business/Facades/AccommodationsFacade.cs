using System.Collections.Generic;
using System.Linq;
using Olbrasoft.Data.Entity;
using Olbrasoft.Pagination;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Business.Mapping;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.Facades
{
    public class AccommodationsFacade : IAccommodationsFacade
    {
        protected ILocalizedPagedQuery<Accommodation> LocalizedPagedQueryOfAccommodation { get; } 
        protected IPagedListMapper<Accommodation,AccommodationDto> Mapper { get; }

        public AccommodationsFacade(ILocalizedPagedQuery<Accommodation> localizedPagedQueryOfAccommodation, IPagedListMapper<Accommodation, AccommodationDto> mapper)
        {
            LocalizedPagedQueryOfAccommodation = localizedPagedQueryOfAccommodation;
            Mapper = mapper;
        }

        public IPagedList<AccommodationDto> Get(IPageInfo pageInfo)
        {
            var pagedListOfAccommodation = PagedList(pageInfo);

            var pagedListOfAccommodationDto = Map(pagedListOfAccommodation);

            return pagedListOfAccommodationDto;
        }

       


        protected virtual IPagedList<Accommodation> PagedList(IPageInfo pageInfo)
        {
            return LocalizedPagedQueryOfAccommodation.Execute(pageInfo);
        }


        protected virtual IPagedList<AccommodationDto> Map(IPagedList<Accommodation> pagedListOfAccommodation)
        {

            return Mapper.Map(pagedListOfAccommodation);

            //var queueOfAccommodationDataTransferObject = new Queue<AccommodationDto>();

            //foreach (var accommodation in pagedListOfAccommodation)
            //{
            //    var adto = new AccommodationDto
            //    {
            //        Id = accommodation.Id,
            //        Address = accommodation.Address,
            //        Name = accommodation.LocalizedAccommodations.FirstOrDefault()?.Name,
            //        Location = accommodation.LocalizedAccommodations.FirstOrDefault()?.Location
            //    };

            //    queueOfAccommodationDataTransferObject.Enqueue(adto);
            //}

            //return queueOfAccommodationDataTransferObject.AsPagedList(pagedListOfAccommodation.AsPagination());
        }
    }
}