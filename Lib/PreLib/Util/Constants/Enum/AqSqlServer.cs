using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum AqSqlServer
{
    uninitialized = 0,
    [Description("tcp:dev-vis-weu-sql.database.windows.net")]
    development,
    [Description("tcp:uat-vis-weu-sql.database.windows.net")]
    UAT,
    [Description("uat-vis-weu-sql.database.windows.net")]
    production,
    outofrange
}
