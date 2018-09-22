using System.ComponentModel.DataAnnotations;
using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Entities
{
    public class LogOfImport : CreationInfo<int>
    {
        [Required]
        [StringLength(255)]
        public string Log { get; set; }

    }
}
