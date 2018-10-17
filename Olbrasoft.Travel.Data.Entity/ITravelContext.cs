using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface ITravelContext
    {
        //IDbSet<LocalizedAccommodation> LocalizedAccommodations { get; set; }
        //IDbSet<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }

        //IDbSet<User> Users { get; set; }
        //IDbSet<LogLevel> LogLevels { get; set; }

        DbSet<T> Set<T>() where T : class;

    }
}