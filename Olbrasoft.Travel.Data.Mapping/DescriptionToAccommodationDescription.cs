using AutoMapper;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;
using Olbrasoft.Travel.Data.Transfer.Object;

namespace Olbrasoft.Travel.Data.Mapping
{
    public class DescriptionToAccommodationDescription : Profile
    {
        public DescriptionToAccommodationDescription()
        {
            CreateMap<LocalizedDescriptionOfAccommodation, AccommodationDescription>();
        }
    }
}