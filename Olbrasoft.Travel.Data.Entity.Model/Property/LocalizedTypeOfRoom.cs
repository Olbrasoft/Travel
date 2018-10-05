using System.ComponentModel.DataAnnotations;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class LocalizedTypeOfRoom : Localized
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        public string Description { get; set; }

        public virtual TypeOfRoom TypeOfRoom { get; set; }
    }
}
