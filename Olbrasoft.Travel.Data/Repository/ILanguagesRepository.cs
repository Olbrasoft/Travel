using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ILanguagesRepository : IBaseRepository<Language>
    {
        IReadOnlyDictionary<string, int> EanLanguageCodesToIds { get; }
    }
}