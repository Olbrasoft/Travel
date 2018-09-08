using System.Linq;
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
            
            CreateMap<LocalizedAccommodation, AccommodationDetailDto>()
                .ForMember(d => d.Address, opt => opt.MapFrom(src => src.Accommodation.Address))
                .ForMember(d=> d.Description, opt=>opt.MapFrom(src=>src.Accommodation.Descriptions.FirstOrDefault(p => p.TypeOfDescriptionId==1).Text))
                
                ;
        }


    }
}