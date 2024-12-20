using System;
using System.Collections.Generic;
using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class AnnualPercentageRate : EntityIntId
{
    public decimal Apr { get; set; } = 0.0m;

    public DateTime EffectiveDate { get; set; }

    public virtual List<AccountAprlookup> AccountAprlookups { get; set; } = new();
}
