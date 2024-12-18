using System.Diagnostics;
using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Extension;

namespace Utilities.ConnectionStringManager.Base;

public static class ConnectionString
{
    private static readonly CurrentDbServer? currentServerManager = CurrentDbServer.Instance;

    public static string ConstructConnectionString(SqlDatabase db)
    {
        EvaluateArgument.Execute(db, fn => SqlDatabase.uninitialized != db && SqlDatabase.outofrange != db, $"Invalid SqlDatabase [{db.Description()}]");

#if DEBUG
        var connStr = $"Server={currentServerManager?.ServerName()};Database={db.Description()};Integrated Security=True; Encrypt=false";
        Debug.WriteLine(connStr);
        return connStr;
#else
        return $"Server={currentServerManager?.ServerName()};Database={db.Description()};Integrated Security=True; Encrypt=false";
#endif
    }
}