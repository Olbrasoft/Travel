﻿using Olbrasoft.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Geography;
using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;
using Region = Olbrasoft.Travel.Data.Entity.Model.Geography.Region;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public class User : User<int>
    {
        #region Child Properties

        public virtual ICollection<LogLevel> LogLevels { get; set; }

        public virtual ICollection<Log> Logs { get; set; }

        public virtual ICollection<TypeOfRegion> TypesOfRegions { get; set; }

        /// <summary>
        /// Regions created by the User.
        /// </summary>
        public virtual ICollection<Region> Regions { get; set; }

        /// <summary>
        /// SubClasses created by the User.
        /// </summary>
        public virtual ICollection<SubClass> SubClasses { get; set; }

        /// <summary>
        /// Languages created by the User.
        /// </summary>
        public virtual ICollection<Language> Languages { get; set; }

        ///// <summary>
        ///// Linking Regions to (TypesOfRegions and SubClasses)
        ///// Example Prague is Region and District and City
        ///// </summary>
        //public virtual ICollection<RegionToType> RegionsToTypes { get; set; }

        ///// <summary>
        ///// LocalizedRegions created by the User.
        ///// </summary>
        //public virtual ICollection<Region> LocalizedRegions { get; set; }

        ///// <summary>
        ///// Linking Regions To Regions created by the User.
        ///// Example Country to Continent or City to Country.
        ///// </summary>
        //public virtual ICollection<RegionToRegion> RegionsToRegions { get; set; }

        ///// <summary>
        ///// Countries created by the User.
        ///// </summary>
        //public virtual ICollection<Country> Countries { get; set; }

        ///// <summary>
        ///// Airports created by the User.
        ///// </summary>
        //public ICollection<Airport> Airports { get; set; }

        ///// <summary>
        ///// TypesOfAccommodations created by the User.
        ///// </summary>
        //public virtual ICollection<TypeOfAccommodation> TypesOfAccommodations { get; set; }

        ///// <summary>
        ///// LocalizedTypesOfAccommodations created by the User.
        ///// </summary>
        //public virtual ICollection<LocalizedTypeOfAccommodation> LocalizedTypesOfAccommodations { get; set; }

        ///// <summary>
        ///// Chains created by the User.
        ///// </summary>
        //public virtual ICollection<Chain> Chains { get; set; }

        ///// <summary>
        ///// Accommodations created by the User.
        ///// </summary>
        //public virtual ICollection<Accommodation> Accommodations { get; set; }

        /////// <summary>
        /////// LocalizedAccommodations created by the User.
        /////// </summary>
        ////public virtual ICollection<LocalizedAccommodation> LocalizedAccommodations { get; set; }

        ///// <summary>
        ///// Types of LocalizedDescriptionsOfAccommodations created by the User.
        ///// </summary>
        //public virtual ICollection<TypeOfDescription> TypesOfDescriptions { get; set; }

        ///// <summary>
        ///// LocalizedDescriptionsOfAccommodations Of Accommodations is Localized and Categorized
        ///// </summary>
        //public virtual ICollection<LocalizedDescriptionOfAccommodation> LocalizedDescriptionsOfAccommodations { get; set; }

        ///// <summary>
        ///// Paths of Photos created by the User
        ///// </summary>
        //public virtual ICollection<PathToPhoto> PathsOfPhotos { get; set; }

        ///// <summary>
        ///// Files Extensions created by the User.
        ///// </summary>
        //public virtual ICollection<FileExtension> FilesExtensions { get; set; }

        ///// <summary>
        ///// Captions created by the User.
        ///// </summary>
        //public virtual ICollection<Caption> Captions { get; set; }

        ///// <summary>
        ///// Localized Captions created by the User.
        ///// </summary>
        //public virtual ICollection<LocalizedCaption> LocalizedCaptions { get; set; }

        ///// <summary>
        ///// Photos of Accommodations created by the User.
        ///// </summary>
        //public virtual ICollection<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }

        ///// <summary>
        ///// Rooms created by the User.
        ///// </summary>
        //public virtual ICollection<TypeOfRoom> TypesOfRooms { get; set; }

        ///// <summary>
        ///// Localized Types of Rooms created by the User.
        ///// </summary>
        //public virtual ICollection<LocalizedTypeOfRoom> LocalizedTypesOfRooms { get; set; }

        ///// <summary>
        ///// Photos of Accommodations to Types of Rooms created by the User.
        ///// </summary>
        //public virtual ICollection<PhotoOfAccommodationToTypeOfRoom> PhotosOfAccommodationsToTypesOfRooms { get; set; }

        ///// <summary>
        ///// Types of Attributes created by the User.
        ///// </summary>
        //public virtual ICollection<TypeOfAttribute> TypesOfAttributes { get; set; }

        ///// <summary>
        ///// Sub Types Of Attributes created by the User.
        ///// </summary>
        //public virtual ICollection<SubTypeOfAttribute> SubTypesOfAttributes { get; set; }

        ///// <summary>
        ///// Attributes created by the User.
        ///// </summary>
        //public virtual ICollection<Attribute> Attributes { get; set; }

        ///// <summary>
        ///// Localized Attributes created by the User.
        ///// </summary>
        //public virtual ICollection<LocalizedAttribute> LocalizedAttributes { get; set; }

        ///// <summary>
        ///// Accommodations to Attributes created by the User.
        ///// </summary>
        //public virtual ICollection<AccommodationToAttribute> AccommodationsToAttributes { get; set; }

        ///// <summary>
        ///// LocalizedAccommodations created by the User.
        ///// </summary>
        //public ICollection<LocalizedAccommodation> LocalizedAccommodations { get; set; }

        #endregion Child Properties
    }
}