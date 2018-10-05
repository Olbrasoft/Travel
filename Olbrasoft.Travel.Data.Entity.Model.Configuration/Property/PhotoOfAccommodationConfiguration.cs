using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Property
{
    public class PhotoOfAccommodationConfiguration : Configuration.Property.CreatorConfiguration<PhotoOfAccommodation>
    {
        public PhotoOfAccommodationConfiguration()
        {
            ToTable("PhotosOfAccommodations");

            Property(p => p.FileName).HasMaxLength(50);

            HasIndex(p => new { p.PathToPhotoId, p.FileName, p.FileExtensionId }).IsUnique();

            HasRequired(poa => poa.Creator).WithMany(u => u.PhotosOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(poa => poa.PathToPhoto).WithMany(ptp => ptp.PhotosOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(poa => poa.FileExtension).WithMany(fe => fe.PhotosOfAccommodations).WillCascadeOnDelete(false);

            HasRequired(p => p.Accommodation).WithMany(p => p.PhotosOfAccommodations).HasForeignKey(p => p.AccommodationId).WillCascadeOnDelete(true);
        }
    }
}