
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Olbrasoft.Travel.Data.Repository;
using Olbrasoft.Travel.Data.Repository.Globalization;

namespace Olbrasoft.Travel.Business.Facades
{
    public class LanguagesFacade : TravelFacade<Language>, ILanguagesFacade
    {
        protected new readonly ILanguagesRepository Repository;

        public LanguagesFacade(ILanguagesRepository repository) : base(repository)
        {
            Repository = repository;
        }

        public Language Get(int id)
        {
            return Repository.Get(id);
        }
    }
}