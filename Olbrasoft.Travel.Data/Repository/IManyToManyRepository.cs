using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IManyToManyRepository<T> : IRepository<T>, IBaseRepository<T, int, int> where T : ManyToMany
    {
    }
}