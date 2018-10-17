using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class TypeOfRoom : OwnerCreatorIdAndCreator, IHaveEanId<int>
    {
        public int AccommodationId { get; set; }
        public int EanId { get; set; } = int.MinValue;
        public virtual Accommodation Accommodation { get; set; }
        public virtual ICollection<LocalizedTypeOfRoom> LocalizedTypesOfRooms { get; set; }
        public virtual ICollection<PhotoOfAccommodationToTypeOfRoom> PhotosOfAccommodationsToTypesOfRooms { get; set; }
    }
}