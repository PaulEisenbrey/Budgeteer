using System;
using System.Collections.Generic;
using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class Institution : EntityIntId
{
    public int? AddressId { get; set; }

    public string Name { get; set; } = string.Empty;

    public string Nickname { get; set; } = string.Empty;

    public string AccountNumber { get; set; } = string.Empty;

    public string PhoneNumber { get; set; } = string.Empty;

    public string Url { get; set; } = string.Empty;

    public virtual Address Address { get; set; } = new();

    public virtual List<InstitutionAccountsLookup> InstitutionAccountsLookups { get; set; } = new();

    public bool IsActive { get; set; }
}
