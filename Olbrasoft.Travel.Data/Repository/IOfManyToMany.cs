using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface IOfManyToMany<T> : IRepository<T>, IBaseRepository<T, int, int> where T : ManyToMany
    {

    }
}