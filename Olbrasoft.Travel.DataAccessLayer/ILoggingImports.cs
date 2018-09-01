using Olbrasoft.Travel.Data.Entities;

namespace Olbrasoft.Travel.DataAccessLayer
{
    public interface ILoggingImports
    {
        void LogIn(LogOfImport log);

        void Log(string textForLogging);
    }
}