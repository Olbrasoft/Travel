using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class LocalizedAttribute : Localized
    {
        public string Description { get; set; }

        public Attribute Attribute { get; set; }
    }
}
