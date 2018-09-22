using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.Data.Repository;


namespace Olbrasoft.Travel.Data.Entity.Repositories
{
    public class LogsOfRegionsRepository: BaseRepository<LogOfImport>,ILogsOfImportsRepository
    {
        public LogsOfRegionsRepository(TravelContext context) : base(context)
        {
        }
    }
}