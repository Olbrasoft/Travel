using System;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class AccommodationToAttribute
    {
        public int AccommodationId { get; set; }

        public int AttributeId { get; set; }

        public int LanguageId { get; set; }

        public int CreatorId { get; set; }

        public string Text { get; set; }

        public DateTime DateAndTimeOfCreation { get; set; }

        public User Creator { get; set; }

        public Accommodation Accommodation { get; set; }

        public Attribute Attribute { get; set; }

        public Language Language { get; set; }
    }
}