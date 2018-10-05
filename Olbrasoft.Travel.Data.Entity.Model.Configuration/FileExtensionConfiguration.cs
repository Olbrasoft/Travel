namespace Olbrasoft.Travel.Data.Entity.Model.Configuration
{
    public class FileExtensionConfiguration : CreatorConfiguration<FileExtension>
    {
        public FileExtensionConfiguration()
        {
            ToTable("FilesExtensions");

            HasIndex(fe => fe.Extension).IsUnique();

            Property(p => p.Extension).HasMaxLength(50).IsRequired();
        }
    }
}