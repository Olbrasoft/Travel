using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Entities
{
    public class LogOfImport : CreationInfo
    {
        [Required]
        [StringLength(255)]
        public string Log { get; set; }

    }
}
