using System.ComponentModel.DataAnnotations.Schema;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class DescriptionConfiguration : PropertyConfiguration<Description>
    {
        public DescriptionConfiguration()
        {
            ToTable("Descriptions");

            Property(p => p.Text).IsRequired();

            HasKey(p => new {p.AccommodationId, p.TypeOfDescriptionId, p.LanguageId});

            HasRequired(d => d.Creator).WithMany(u => u.Descriptions).WillCascadeOnDelete(false);

            HasRequired(d => d.Language).WithMany(l => l.Descriptions).WillCascadeOnDelete(false);

            HasRequired(d => d.Accommodation).WithMany(a => a.Descriptions).WillCascadeOnDelete(true);

            HasRequired(d => d.TypeOfDescription).WithMany(tod => tod.Descriptions).WillCascadeOnDelete(false);

            Property(p => p.DateAndTimeOfCreation).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}