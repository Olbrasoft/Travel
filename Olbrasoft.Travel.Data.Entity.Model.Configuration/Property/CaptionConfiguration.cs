using Olbrasoft.Travel.Data.Entity.Model.Property;
using System.ComponentModel.DataAnnotations.Schema;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class CaptionConfiguration : PropertyConfiguration<Caption>
    {

        public CaptionConfiguration()
        {
            ToTable("Captions");
            Property(caption => caption.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}