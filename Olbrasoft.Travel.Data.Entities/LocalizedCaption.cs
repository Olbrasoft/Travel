using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Entities
{
    public class LocalizedCaption : Localized
    {
        [Required]
        [StringLength(255)]
        public string Text { get; set; }
        
        public Caption Caption { get; set; }
    }
}