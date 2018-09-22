using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ILoggingImports
    {
        void LogIn(LogOfImport log);

        void Log(string textForLogging);
    }
}