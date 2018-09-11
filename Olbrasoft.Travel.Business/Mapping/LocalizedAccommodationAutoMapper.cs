using AutoMapper;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Business.Mapping
{
    public class LocalizedAccommodationAutoMapper : AutoMapper<LocalizedAccommodation>, ILocalizedAccommodationMapper
    {
        public LocalizedAccommodationAutoMapper(IMapper mapper) : base(mapper)
        {
        }
    }
}