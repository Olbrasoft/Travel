using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Entity.ModelConfiguration
{
    public class SubClassConfiguration: ConfigurationGeography<SubClass>
    {
        public SubClassConfiguration()
        {
            ToTable("SubClasses").HasIndex(p => p.Name).IsUnique();
        }
    }
}