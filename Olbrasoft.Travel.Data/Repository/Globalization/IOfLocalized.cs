using Olbrasoft.Data.Repository.Bulk;
using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository.Globalization
{
    public interface IOfLocalized<T> : IRepository<T>, IBaseRepository<T, int, int>
        where T : Localized
    {
        //bool Exists(int languageId);
        //IEnumerable<int> FindIds(int languageId);
    }
}