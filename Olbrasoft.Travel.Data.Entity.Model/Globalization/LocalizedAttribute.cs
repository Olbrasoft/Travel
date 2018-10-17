using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Globalization
{
    public class LocalizedAttribute : Localized
    {
        public string Description { get; set; }

        public Attribute Attribute { get; set; }
    }
}
