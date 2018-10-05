using System.Data.Entity;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Entity.Model
{
    public interface ITravelContext
    {
        IDbSet<LocalizedAccommodation> LocalizedAccommodations { get; set; }
        IDbSet<PhotoOfAccommodation> PhotosOfAccommodations { get; set; }

        DbSet<T> Set<T>() where T : class;

    }
}