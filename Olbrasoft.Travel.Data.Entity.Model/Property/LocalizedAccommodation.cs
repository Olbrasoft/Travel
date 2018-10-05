using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class LocalizedAccommodation : Localized
    {
        public string Name { get; set; }

        public string Location { get; set; }

        public string CheckInTime { get; set; }

        public string CheckOutTime { get; set; }

        public virtual Accommodation Accommodation { get; set; }
    }
}