using Olbrasoft.Travel.Data.Entity.Model.Routing;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface IRoutingContext
    {
        IDbSet<PathToPhoto> PathsToPhotos { get; set; }
        IDbSet<FileExtension> FilesExtensions { get; set; }
    }
}