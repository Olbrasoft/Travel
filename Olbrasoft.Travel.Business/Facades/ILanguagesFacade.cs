using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Business.Facades
{
    public interface ILanguagesFacade : ITravelFacade<Language>
    {
        Language Get(int id);
    }
}