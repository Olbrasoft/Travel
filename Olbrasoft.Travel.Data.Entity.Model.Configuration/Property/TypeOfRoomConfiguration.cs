using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class TypeOfRoomConfiguration : CreatorConfiguration<TypeOfRoom>
    {
        public TypeOfRoomConfiguration()
        {
            ToTable("TypesOfRooms");

            HasRequired(tor => tor.Creator).WithMany(u => u.TypesOfRooms).WillCascadeOnDelete(false);

            HasRequired(tor => tor.Accommodation).WithMany(a => a.TypesOfRooms).WillCascadeOnDelete();
        }
    }
}