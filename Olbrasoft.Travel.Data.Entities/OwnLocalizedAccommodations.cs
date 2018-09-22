using System.Linq;

namespace Olbrasoft.Travel.Data.Entities
{
    public class OwnLocalizedAccommodations : IHaveLocalizedAccommodations
    {
        public IQueryable<LocalizedAccommodation> LocalizedAccommodations { get; }

        public OwnLocalizedAccommodations(ITravelContext travelContext)
        {
            LocalizedAccommodations = travelContext.LocalizedAccommodations;
        }
    }
}