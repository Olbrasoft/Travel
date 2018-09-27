using AutoMapper;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Mapping.LocalizedAccommodation
{
    public class ToAccommodationDetail : Profile
    {
        public ToAccommodationDetail()
        {
            CreateMap<Entities.LocalizedAccommodation, AccommodationDetail>()
                .ForMember(d => d.Address, opt => opt.MapFrom(src => src.Accommodation.Address))
                .ForMember(d => d.StarRating, opt => opt.MapFrom(src => src.Accommodation.StarRating))
                .ForMember(d => d.Latitude, opt => opt.MapFrom(src => src.Accommodation.CenterCoordinates.Latitude))
                .ForMember(d => d.Longitude, opt => opt.MapFrom(src => src.Accommodation.CenterCoordinates.Longitude))
                ;
        }
    }
}