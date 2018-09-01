using AutoMapper;
using Olbrasoft.Travel.Data.Dto;
using Olbrasoft.Travel.Data.Entity;
using System.Linq;

namespace Olbrasoft.Travel.BusinessLogicLayer.Mapping
{
    public class AccommodationProfile : Profile
    {
        public AccommodationProfile()
        {
            CreateMap<Accommodation, AccommodationDto>()
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.LocalizedAccommodations.FirstOrDefault().Name));
        }
    }
}