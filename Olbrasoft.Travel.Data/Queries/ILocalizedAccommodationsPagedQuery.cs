using Olbrasoft.Collections.Generic;
using Olbrasoft.Data;
using Olbrasoft.Pagination;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Queries
{
    public interface ILocalizedAccommodationsPagedQuery : IQueryWithSorting<LocalizedAccommodation, IPagedList<LocalizedAccommodation>>
    {
        int LanguageId { get; set; }
        IPageInfo Paging { get; set; }
    }
}