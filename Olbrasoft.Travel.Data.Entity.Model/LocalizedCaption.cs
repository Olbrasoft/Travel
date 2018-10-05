using System.ComponentModel.DataAnnotations;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class LocalizedCaption : Localized
    {
        [Required]
        [StringLength(255)]
        public string Text { get; set; }
        
        public Caption Caption { get; set; }
    }
}