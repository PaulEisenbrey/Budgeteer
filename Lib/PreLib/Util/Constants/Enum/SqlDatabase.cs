using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum SqlDatabase
{
    uninitialized = 0,
    [Description("Budgeteer")]
    budgeteer = 1,
    outofrange
}
