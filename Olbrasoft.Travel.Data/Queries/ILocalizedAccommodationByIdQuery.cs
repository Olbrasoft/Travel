using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Queries
{
    public interface ILocalizedAccommodationByIdQuery : IQuery<LocalizedAccommodation> 
    {
        int Id { get; set; }
        int LanguageId { get; set; }
    }
}