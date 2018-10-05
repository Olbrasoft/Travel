using System.ComponentModel.DataAnnotations.Schema;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class CaptionConfiguration : CreatorConfiguration<Caption>
    {
        public CaptionConfiguration()
        {
            Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}