using System.Linq;
using AutoMapper;
using Olbrasoft.Travel.Data;

using Accommodation = Olbrasoft.Travel.Data.Entity.Model.Property.Accommodation;

namespace Olbrasoft.Travel.Business.Unit.Tests
{
    public class AccommodationProfile : Profile
    {
        public AccommodationProfile()
        {
            CreateMap<Accommodation, AccommodationDto>()

                .ForMember(d => d.Location, opt => opt.MapFrom(src => src.LocalizedAccommodations.FirstOrDefault().Location))
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.LocalizedAccommodations.FirstOrDefault().Name))
                ;


        }
    }
}