using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Routing
{
    public class PathToPhoto : OwnerCreatorIdAndCreator
    {
        public string Path { get; set; }

        public virtual ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
    }
}