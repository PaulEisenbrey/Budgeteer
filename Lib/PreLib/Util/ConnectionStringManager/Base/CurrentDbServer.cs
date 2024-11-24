using Utilities.ArgumentEvaluation;
using Utilities.Constants.Enum;
using Utilities.Extension;
using Utilities.Extension.StringExtension;

namespace Utilities.ConnectionStringManager.Base;

public class CurrentDbServer : Singleton<CurrentDbServer>
{
    private SqlServer server = SqlServer.test;  // safe default

    public void SetServer(SqlServer server)
    {
        EvaluateArgument.Execute(server, 
            fn => SqlServer.uninitialized != server && SqlServer.outofrange != server, 
            $"Must set server to a valid SqlServer. {server.Description()} isn't one.");

        this.server = server;
    }

    public string ServerName() => this.server.Description().NullIfEmpty() ?? "";

    public SqlServer CurrentServer => this.server;
}
