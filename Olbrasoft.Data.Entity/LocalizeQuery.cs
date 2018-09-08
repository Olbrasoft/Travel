using Olbrasoft.Design.Pattern.Behavior;
using Olbrasoft.Shared;

namespace Olbrasoft.Data.Entity
{
    public abstract class LocalizeQuery<T> : Olbrasoft.Design.Pattern.Behavior.Query<T>
    {
        protected ILanguageService LanguageService { get; }

        protected int LanguageId => LanguageService.CurrentLanguageId;

        protected LocalizeQuery(ILanguageService languageService)
        {
            LanguageService = languageService;
        }
    }
}