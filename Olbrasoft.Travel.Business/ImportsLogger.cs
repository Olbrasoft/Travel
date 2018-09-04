﻿using Olbrasoft.Travel.Data.Entities;
using Olbrasoft.Travel.DataAccessLayer;

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