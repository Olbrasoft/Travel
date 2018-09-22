using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entities
{
    public interface ITravelContext
    {
        IDbSet<LocalizedAccommodation> LocalizedAccommodations { get; set; }
    }
}