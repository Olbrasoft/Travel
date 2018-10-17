using Olbrasoft.Travel.Data.Entity.Model.Geography;
using System.Collections.Generic;
using System.Data.Entity.Spatial;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class Accommodation : OwnerCreatorIdAndCreator, IHaveEanId<int>
    {
        public Accommodation()
        {
            LocalizedAccommodations = new HashSet<LocalizedAccommodation>();

            LocalizedDescriptionsOfAccommodations = new HashSet<LocalizedDescriptionOfAccommodation>();

            PhotosOfAccommodations = new HashSet<PhotoOfAccommodation>();

            TypesOfRooms = new HashSet<TypeOfRoom>();

            AccommodationsToAttributes = new HashSet<AccommodationToAttribute>();
        }

        public int SequenceNumber { get; set; }

        public decimal StarRating { get; set; }

        public string Address { get; set; }

        public string AdditionalAddress { get; set; }

        public DbGeography CenterCoordinates { get; set; }

        public int TypeOfAccommodationId { get; set; }

        public int CountryId { get; set; }

        public int? AirportId { get; set; }

        public int? ChainId { get; set; }

        public int EanId { get; set; } = int.MinValue;

        public Country Country { get; set; }

        public TypeOfAccommodation TypeOfAccommodation { get; set; }

        public Chain Chain { get; set; }

        public Airport Airport { get; set; }

        public ICollection<LocalizedAccommodation> LocalizedAccommodations { get; set; }

        public ICollection<LocalizedDescriptionOfAccommodation> LocalizedDescriptionsOfAccommodations { get; set; }

        public ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }

        public ICollection<TypeOfRoom> TypesOfRooms { get; set; }

        public ICollection<AccommodationToAttribute> AccommodationsToAttributes { get; set; }
    }
}