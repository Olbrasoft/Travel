using Olbrasoft.Travel.Data.Entity.Model;
using System.Data.Entity;

namespace Olbrasoft.Travel.Data.Entity
{
    public interface IDbo
    {
        IDbSet<User> Users { get; set; }
        IDbSet<LogOfImport> LogsOfImports { get; set; }
    }
}