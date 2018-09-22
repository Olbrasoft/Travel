using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ILocalizedCaptionsRepository : ILocalizedRepository<LocalizedCaption>
    {
        IReadOnlyDictionary<string, int> GetLocalizedCaptionsTextsToIds(int languageId);
    }
}