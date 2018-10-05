using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class FileExtension : CreatorInfo
    {
        public string Extension { get; set; }

        public virtual ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
    }
}