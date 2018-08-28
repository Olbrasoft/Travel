using System.Linq;
using Olbrasoft.Shared;
using Olbrasoft.Shared.Pagination;

namespace Olbrasoft.Data.Entity
{
    public abstract class LocalizedPagedQuery<T> : PagedQuery<T>,ILocalizedPagedQuery<T> where T : class
    {
        protected ILanguageService LanguageService { get; }

        protected int LanguageId => LanguageService.CurrentLanguageId;

        protected LocalizedPagedQuery(IQueryable<T> queryable, IPageInfo pageInfo, ILanguageService languageService) : base(queryable, pageInfo)
        {
            LanguageService = languageService;
        }

        protected LocalizedPagedQuery(IQueryable<T> queryable, ILanguageService languageService) : base(queryable)
        {
            LanguageService = languageService;
        }
    }
}