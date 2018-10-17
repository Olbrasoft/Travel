using Olbrasoft.Travel.Data.Entity.Model.Routing;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Routing
{
    public class PathToPhotoConfiguration : RoutingConfiguration<PathToPhoto>
    {
        public PathToPhotoConfiguration()
        {
            ToTable("PathsToPhotos");

            HasIndex(pathToPhoto => pathToPhoto.Path).IsUnique();

            Property(p => p.Path).HasMaxLength(300).IsRequired();
        }
    }
}