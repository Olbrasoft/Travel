using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface IManyToManyRepository<T> : IBulkRepository<T>, IBaseRepository<T, int, int> where T : ManyToMany
    {
    }
}