using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Queries
{
    public class LocalizedAccommodationsPagedQuery : QueryWithSorting<LocalizedAccommodation, IPagedList<LocalizedAccommodation>>, ILocalizedAccommodationsPagedQuery
    {
        public int LanguageId { get; set; }
    }
}  