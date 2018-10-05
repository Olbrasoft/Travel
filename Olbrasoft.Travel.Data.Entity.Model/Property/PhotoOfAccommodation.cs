using System.Collections.Generic;

namespace Olbrasoft.Travel.Data.Entity.Model.Property
{
    public class PhotoOfAccommodation : CreatorInfo
    {
        public int AccommodationId { get; set; }

        public int PathToPhotoId { get; set; }

        public string FileName { get; set; }

        public int FileExtensionId { get; set; }

        public bool IsDefault { get; set; }

        public int? CaptionId { get; set; }

        public Property.Accommodation Accommodation { get; set; }

        public PathToPhoto PathToPhoto { get; set; }

        public FileExtension FileExtension { get; set; }

        public Caption Caption { get; set; }

        public ICollection<PhotoOfAccommodationToTypeOfRoom> ToTypesOfRooms { get; set; }
    }
}