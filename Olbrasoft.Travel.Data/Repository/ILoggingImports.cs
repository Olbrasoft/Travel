using Olbrasoft.Travel.Data.Entity.Model;

namespace Olbrasoft.Travel.Data.Repository
{
    public interface ILoggingImports
    {
        void LogIn(LogOfImport log);

        void Log(string textForLogging);
    }
}