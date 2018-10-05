

using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Geography
{
    public class SubClassConfiguration: NameConfiguration<SubClass>
    {
        public SubClassConfiguration()
        {
            ToTable("SubClasses").HasIndex(p => p.Name).IsUnique();
        }
    }
}