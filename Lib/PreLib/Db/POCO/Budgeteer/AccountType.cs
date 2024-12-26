using System;
using System.Collections.Generic;

namespace Database.POCO.Budgeteer;

public partial class AccountType
{
    public int Id { get; set; }

    public string? Description { get; set; }

    public virtual ICollection<AccountDatum> AccountData { get; set; } = new List<AccountDatum>();
}
