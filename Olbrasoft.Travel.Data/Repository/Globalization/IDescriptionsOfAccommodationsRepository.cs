using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model.Globalization;

namespace Olbrasoft.Travel.Data.Repository.Globalization
{
    public interface IDescriptionsOfAccommodationsRepository : IRepository<LocalizedDescriptionOfAccommodation>, SharpRepository.Repository.ICompoundKeyRepository<LocalizedDescriptionOfAccommodation, int, int, int>
    {
    }
}