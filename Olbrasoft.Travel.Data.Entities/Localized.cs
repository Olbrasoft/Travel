using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Olbrasoft.Data;
using Olbrasoft.Globalization;

namespace Olbrasoft.Travel.Data.Entities
{
    public class Localized : CreatorInfo, ILocalized
    {
        [Key, Column(Order = 2)]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}