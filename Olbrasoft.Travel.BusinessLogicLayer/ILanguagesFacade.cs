using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.BusinessLogicLayer
{
    public interface ILanguagesFacade : ITravelFacade<Language>
    {
        Language Get(int id);
    }
}