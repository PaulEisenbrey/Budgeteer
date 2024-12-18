using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum SqlServer
{
    uninitialized = 0,

    [Description("VILLALOBOS\\MSSQL")]
    development,

    [Description("VILLALOBOS\\MSSQL")]
    test,

    [Description("VILLALOBOS\\MSSQL")]
    production,

    outofrange
}