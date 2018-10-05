using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ILocalizedCaptionsRepository : ILocalizedRepository<LocalizedCaption>
    {
        IReadOnlyDictionary<string, int> GetLocalizedCaptionsTextsToIds(int languageId);
    }
}