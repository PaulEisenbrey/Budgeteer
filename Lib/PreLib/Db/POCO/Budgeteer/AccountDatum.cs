using System;
using System.Collections.Generic;

namespace Database.POCO.Budgeteer;

public partial class AccountDatum
{
    public int Id { get; set; }

    public int InstitutionId { get; set; }

    public DateTime OpenDate { get; set; }

    public int AccountTypeId { get; set; }

    public string Name { get; set; } = null!;

    public string? Nickname { get; set; }

    public string? AccountNumber { get; set; }

    public string? RoutingNumber { get; set; }

    public decimal InitialBalance { get; set; }

    public Guid AccountUniqueId { get; set; }

    public virtual AccountType AccountType { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<AnnualPercentageRate> AnnualPercentageRates { get; set; } = new List<AnnualPercentageRate>();

    public virtual Institution Institution { get; set; } = null!;

    public virtual ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
}
