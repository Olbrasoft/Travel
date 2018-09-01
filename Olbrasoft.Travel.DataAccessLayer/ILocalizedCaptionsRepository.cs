using Olbrasoft.Travel.Data.Entities;
using System.Collections.Generic;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface ILocalizedCaptionsRepository : ILocalizedRepository<LocalizedCaption>
    {
        IReadOnlyDictionary<string, int> GetLocalizedCaptionsTextsToIds(int languageId);
    }
}