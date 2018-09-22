using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IDescriptionsRepository : IRepository<Description>, SharpRepository.Repository.ICompoundKeyRepository<Description, int, int, int>
    {
    }
}