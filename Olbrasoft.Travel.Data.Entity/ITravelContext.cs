using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface ITravelContext
    {
        DbSet<T> Set<T>() where T : class;
    }
}