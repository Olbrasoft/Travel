using Olbrasoft.Travel.Data.Entity.Model.Geography;

namespace Olbrasoft.Travel.Data.Entity.Model.Globalization
{
    public class LocalizedRegion : Localized
    {
        public virtual string Name { get; set; }

        public string LongName { get; set; }

        public virtual Region Region { get; set; }
    }
}