using Olbrasoft.Travel.Data.Entity.Model.Routing;

namespace Olbrasoft.Travel.Data.Entity.Model.Configuration.Routing
{
    public class FileExtensionConfiguration : RoutingConfiguration<FileExtension>
    {
        public FileExtensionConfiguration()
        {
            ToTable("FilesExtensions");

            HasIndex(fe => fe.Extension).IsUnique();

            Property(p => p.Extension).HasMaxLength(50).IsRequired();
        }
    }
}