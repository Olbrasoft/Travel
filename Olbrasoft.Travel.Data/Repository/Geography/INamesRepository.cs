using Olbrasoft.Data.Entity;

namespace Olbrasoft.Travel.Data.Repository.Geography
{
    public interface INamesRepository<TEntity> : IOfName<TEntity> where TEntity : class, IHaveName
    {

    }
}