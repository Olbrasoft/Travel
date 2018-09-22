using System.Linq;

namespace Olbrasoft.Travel.Data.Entities
{
    public interface IHaveLocalizedAccommodations
    {
        IQueryable<LocalizedAccommodation> LocalizedAccommodations { get; }
    }
}