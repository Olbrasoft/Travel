using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class PathToPhoto : CreatorInfo
    {
        public string Path { get; set; }

        public virtual ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
    }
}