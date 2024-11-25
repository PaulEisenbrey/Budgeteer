using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class AccountType : EntityIntId
{
    public string Description { get; set; } = string.Empty;

    public virtual List<AccountDatum> AccountData { get; set; } = new();
}
