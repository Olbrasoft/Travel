using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface ILanguagesRepository : IBaseRepository<Language>
    {
        IReadOnlyDictionary<string, int> EanLanguageCodesToIds { get; }
    }
}