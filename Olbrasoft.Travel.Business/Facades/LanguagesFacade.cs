﻿using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.DataAccessLayer;

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