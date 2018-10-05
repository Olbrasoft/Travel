

using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface ILanguagesFacade : ITravelFacade<Language>
    {
        Language Get(int id);
    }
}