using System;
using System.Collections.Generic;

namespace Database.POCO.Budgeteer;

public partial class Institution
{
    public int Id { get; set; }

    public int? AddressId { get; set; }

    public string? Name { get; set; }

    public string? Nickname { get; set; }

    public string? AccountNumber { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Url { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime? DeleteDate { get; set; }

    public virtual ICollection<AccountDatum> AccountData { get; set; } = new List<AccountDatum>();

    public virtual Address? Address { get; set; }
}
