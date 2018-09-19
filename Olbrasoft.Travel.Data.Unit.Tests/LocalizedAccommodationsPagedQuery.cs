using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Data.Unit.Tests;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Unit.Tests
{
    public class LocalizedAccommodationsPagedQuery : QueryWithSorting<LocalizedAccommodation, IPagedList<LocalizedAccommodation>>, ILocalizedAccommodationsPagedQuery
    {
        public int LanguageId { get; set; }
    }
}  