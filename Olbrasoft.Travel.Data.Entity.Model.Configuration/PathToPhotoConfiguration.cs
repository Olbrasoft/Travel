namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class PathToPhotoConfiguration : CreatorConfiguration<PathToPhoto>
    {
        public PathToPhotoConfiguration()
        {
            ToTable("PathsToPhotos");

            HasIndex(pathToPhoto => pathToPhoto.Path).IsUnique();

            Property(p => p.Path).HasMaxLength(300).IsRequired();
        }
    }
}