using MyUtilities.ConnectionStringManager.Base;
using Utilities.ConnectionStringManager.Base;
using Utilities.Constants.Enum;

namespace Trupanion.Test.QaLibCore.Utilities.ConnectionStringManager.TrupanionDbs;

public class BudgeteerConnectionString : ConnectionStringBase, IConnectionString
{
    public BudgeteerConnectionString() => this.database = SqlDatabase.budgeteer;

    public string GetConnectionString()
    {
        return ConnectionString.ConstructConnectionString(this.database);
    }
}
