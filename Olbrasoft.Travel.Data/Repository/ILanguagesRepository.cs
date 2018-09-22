using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ILanguagesRepository : IBaseRepository<Language>
    {
        IReadOnlyDictionary<string, int> EanLanguageCodesToIds { get; }
    }
}