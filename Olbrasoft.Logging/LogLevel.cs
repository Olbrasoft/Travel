using System.ComponentModel;

namespace Olbrasoft.Logging
{
    /// <summary>
    /// https://github.com/nlog/NLog/wiki/Configuration-file
    /// </summary>
    public enum LogLevel
    {
        [Description("Highest level: important stuff down")]
        Fatal = 100,

        [Description("For example application crashes / exceptions.")]
        Error = 200,

        [Description("Incorrect behavior but the application can continue")]
        Warn = 300,

        [Description("Normal behavior like mail sent, user updated profile etc.")]
        Info = 400,

        [Description("Executed queries, user authenticated, session expired")]
        Debug = 500,

        [Description("Begin method X, end method X etc.")]
        Trace = 600,
    }
}