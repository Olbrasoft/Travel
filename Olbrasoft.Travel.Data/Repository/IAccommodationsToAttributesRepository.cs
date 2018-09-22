using System.Collections.Generic;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IAccommodationsToAttributesRepository : SharpRepository.Repository.ICompoundKeyRepository<AccommodationToAttribute, int, int, int>
    {
        void BulkSave(IEnumerable<AccommodationToAttribute> accommodationsToAttributes);
    }
}