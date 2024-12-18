using System.ComponentModel;

namespace Utilities.Logging;

public enum LogLevel
{
    uninitialized = 0,

    [Description("TRACE ")]
    trace,

    [Description("INFO  ")]
    info,

    [Description("WARN ")]
    warn,

    [Description("ERROR")]
    error,

    [Description("FATAL")]
    fatal,

    off,
    outofrange
}