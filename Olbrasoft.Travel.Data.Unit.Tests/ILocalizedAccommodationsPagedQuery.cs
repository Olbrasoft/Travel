using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Unit.Tests
{
    public interface ILocalizedAccommodationsPagedQuery : IPagedQuery<LocalizedAccommodation, IPagedList<LocalizedAccommodation>>
    {
        int LanguageId { get; set; }
    }
}