using System;
using System.ComponentModel.DataAnnotations;

namespace Olbrasoft.Travel.Data.Entities
{
    public interface ILocalizedAccommodation
    {
        string Name { get; set; }
        string Location { get; set; }
        string CheckInTime { get; set; }
        string CheckOutTime { get; set; }
        Accommodation Accommodation { get; set; }
        int LanguageId { get; set; }
        Language Language { get; set; }
        int CreatorId { get; set; }
        User Creator { get; set; }
        int Id { get; set; }
        DateTime DateAndTimeOfCreation { get; set; }
    }

    public class LocalizedAccommodation : Localized, ILocalizedAccommodation
    {
        
        [Required]
        [StringLength(70)]
        public string Name { get; set; }

        [StringLength(80)]
        public string Location { get; set; }

        [StringLength(10)]
        public string CheckInTime { get; set; }

        [StringLength(10)]
        public string CheckOutTime { get; set; }

        public virtual Accommodation Accommodation { get; set; }
    }
}
