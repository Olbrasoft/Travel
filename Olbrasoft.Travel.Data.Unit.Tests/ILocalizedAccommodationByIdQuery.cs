using Olbrasoft.Data;
using Olbrasoft.Data.Query;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Entity.Model.Property;


namespace Olbrasoft.Travel.Data.Unit.Tests
{
    public interface ILocalizedAccommodationByIdQuery : IQuery<LocalizedAccommodation>
    {
        int Id { get; set; }
        int LanguageId { get; set; }
    }
}