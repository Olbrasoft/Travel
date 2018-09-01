using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface IDescriptionsRepository : IBulkRepository<Description>, SharpRepository.Repository.ICompoundKeyRepository<Description, int, int, int>
    {
    }
}