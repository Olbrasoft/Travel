using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class PhotoOfAccommodationToTypeOfRoomConfiguration : ManyToManyConfiguration<PhotoOfAccommodationToTypeOfRoom>
    {
        public PhotoOfAccommodationToTypeOfRoomConfiguration()
        {
            ToTable("PhotosOfAccommodationsToTypesOfRooms");

            HasRequired(p => p.Creator).WithMany(u => u.PhotosOfAccommodationsToTypesOfRooms).WillCascadeOnDelete(false);

            HasRequired(p => p.TypeOfRoom).WithMany(tor => tor.PhotosOfAccommodationsToTypesOfRooms).HasForeignKey(p => p.ToId).WillCascadeOnDelete(false);
        }
    }
}