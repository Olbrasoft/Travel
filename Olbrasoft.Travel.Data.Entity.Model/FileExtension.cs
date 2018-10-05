using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class FileExtension : CreatorInfo
    {
        [Required]
        [StringLength(50)]
        public string Extension { get; set; }

        public virtual ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
    }
}
