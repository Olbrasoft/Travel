using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Globalization
{
    public class LocalizedCaption : Localized
    {
        public string Text { get; set; }

        public Caption Caption { get; set; }
    }
}