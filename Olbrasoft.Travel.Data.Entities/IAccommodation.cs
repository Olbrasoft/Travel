using System;
using System.Collections.Generic;
using System.Data.Entity.Spatial;

namespace Olbrasoft.Travel.Data.Entities
{
    public interface IAccommodation : IHaveEanId<int>
    {
        int SequenceNumber { get; set; }
        decimal StarRating { get; set; }
        string Address { get; set; }
        string AdditionalAddress { get; set; }
        DbGeography CenterCoordinates { get; set; }
        int TypeOfAccommodationId { get; set; }
        int CountryId { get; set; }
        int? AirportId { get; set; }
        int? ChainId { get; set; }
        Country Country { get; set; }
        TypeOfAccommodation TypeOfAccommodation { get; set; }
        Chain Chain { get; set; }
        Airport Airport { get; set; }
        ICollection<LocalizedAccommodation> LocalizedAccommodations { get; set; }
        ICollection<Description> Descriptions { get; set; }
        ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }
        ICollection<TypeOfRoom> TypesOfRooms { get; set; }
        ICollection<AccommodationToAttribute> AccommodationsToAttributes { get; set; }
        int CreatorId { get; set; }
        User Creator { get; set; }
        int Id { get; set; }
        DateTime DateAndTimeOfCreation { get; set; }
    }
}