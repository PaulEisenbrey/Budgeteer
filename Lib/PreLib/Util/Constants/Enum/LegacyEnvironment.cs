using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum LegacyEnvironment
{
    uninitialized = 0,

    [Description("Dev")]
    dev,
    [Description("Development")]
    development,
    [Description("Test")]
    test,
    [Description("Production")]
    production,

    outofrange
}
