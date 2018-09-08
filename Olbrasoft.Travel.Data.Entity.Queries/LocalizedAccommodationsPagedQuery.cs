using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Pagination.Collections.Generic;
using Olbrasoft.Pagination.Linq;
using Olbrasoft.Travel.Data.Entities;
using System.Data.Entity;
using System.Linq;

namespace Olbrasoft.Travel.Data.Entity.Queries
{
    public class LocalizedAccommodationsPagedQuery : IQuery<ILocalizedPagedQueryArgument, IPagedList<LocalizedAccommodation>>
    {
        protected IQueryable<LocalizedAccommodation> Queryable { get; }

        public LocalizedAccommodationsPagedQuery(IQueryable<LocalizedAccommodation> queryable)
        {
            Queryable = queryable;
        }

        public IPagedList<LocalizedAccommodation> Execute(ILocalizedPagedQueryArgument pagedQueryArgument)
        {
            return Queryable
                .Include(localizedAccommodation => localizedAccommodation.Accommodation)
                .Where(localizedAccommodation => localizedAccommodation.LanguageId == pagedQueryArgument.LanguageId)
                .OrderBy(localizedAccommodation => localizedAccommodation.Accommodation.SequenceNumber).ThenBy(p => p.Id)
                .AsPagedList(pagedQueryArgument.PageInfo);
        }
    }
}