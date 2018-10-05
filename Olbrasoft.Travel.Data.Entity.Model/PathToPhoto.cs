using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class PathToPhoto : CreatorInfo
    {
        [Required]
        [StringLength(300)]

        public string Path { get; set; }

       public virtual ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
    }
    
}
