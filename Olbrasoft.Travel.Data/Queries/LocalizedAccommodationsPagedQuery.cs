using Olbrasoft.Data;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Queries
{
    public class LocalizedAccommodationsPagedQuery : BaseQuery<LocalizedAccommodation, IPagedList<LocalizedAccommodation>>, ILocalizedAccommodationsPagedQuery
    {
        public int LanguageId { get; set; }
    }
}  