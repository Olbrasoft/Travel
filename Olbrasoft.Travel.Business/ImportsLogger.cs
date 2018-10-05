using Olbrasoft.Travel.Data;
using Olbrasoft.Travel.Data.Entity.Model;
using Olbrasoft.Travel.Data.Repository;


namespace Olbrasoft.Travel.Business
{
    public class ImportsLogger : ILoggingImports
    {
        protected readonly ILogsOfImportsRepository Repository;

        public ImportsLogger(ILogsOfImportsRepository repository)
        {
            Repository = repository;
        }

        public void LogIn(LogOfImport log)
        {
            Repository.Add(log);
        }

        public void Log(string textForLogging)
        {
            LogIn(new LogOfImport() { Log = textForLogging });
        }
    }
}