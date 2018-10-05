using Olbrasoft.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Property;


namespace Olbrasoft.Travel.Data.Unit.Tests
{
    public interface ILocalizedAccommodationsPagedQuery : IPagedQuery<LocalizedAccommodation, IPagedList<LocalizedAccommodation>>
    {
        int LanguageId { get; set; }
    }
}