using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Globalization
{
    public class LocalizedTypeOfRoomConfiguration : LocalizedConfiguration<LocalizedTypeOfRoom>
    {
        public LocalizedTypeOfRoomConfiguration()
        {
            ToTable("LocalizedTypesOfRooms");

            Property(p => p.Name).HasMaxLength(200).IsRequired();

            HasRequired(localizedTypeOfRoom => localizedTypeOfRoom.Creator).WithMany(u => u.LocalizedTypesOfRooms).WillCascadeOnDelete(false);

            HasRequired(localizedTypeOfRoom => localizedTypeOfRoom.Language).WithMany(l => l.LocalizedTypesOfRooms).WillCascadeOnDelete(false);
        }
    }
}