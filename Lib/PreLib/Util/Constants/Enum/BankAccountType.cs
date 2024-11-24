using System.ComponentModel;

namespace Utilities.Constants.Enum;

public enum BankAccountType
{
    [Description("BankAccTypeChecking")]
    Checking = 1,

    [Description("BankAccTypeSavings")]
    Saving
}
