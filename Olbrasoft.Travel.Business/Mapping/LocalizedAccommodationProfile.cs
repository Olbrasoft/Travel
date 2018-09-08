using AutoMapper;
using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Transfer.Objects;

namespace Olbrasoft.Travel.Business.Mapping
{
    public class LocalizedAccommodationProfile : Profile
    {
        public LocalizedAccommodationProfile()
        {
            CreateMap<LocalizedAccommodation, AccommodationDto>()
                .ForMember(d => d.Address, opt => opt.MapFrom(src => src.Accommodation.Address))
                ;
        }


    }
}