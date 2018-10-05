using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model.Property;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IDescriptionsRepository : IRepository<Description>, SharpRepository.Repository.ICompoundKeyRepository<Description, int, int, int>
    {
    }
}