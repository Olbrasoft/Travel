using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository.Geography
{
    public interface IManyToManyRepository<TEntity> : IOfManyToMany<TEntity> where TEntity : ManyToMany
    {
    }
}