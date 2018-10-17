using Olbrasoft.Globalization;
using Language = Olbrasoft.Travel.Data.Entity.Model.Globalization.Language;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class Localized : OwnerCreatorIdAndCreator, ILocalized
    {
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}