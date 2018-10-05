using Olbrasoft.Travel.Data.Entity.Model.Configuration.Property;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class TypeOfDescriptionConfiguration : NameConfiguration<TypeOfDescription>
    {
        public TypeOfDescriptionConfiguration()
        {
            ToTable("TypesOfDescriptions");

            HasIndex(p => p.Name).IsUnique();

            HasRequired(tod => tod.Creator).WithMany(user => user.TypesOfDescriptions).WillCascadeOnDelete(true);
        }
    }
}