using System;
using System.Collections.Generic;

namespace Database.POCO.Budgeteer;

public partial class AnnualPercentageRate
{
    public int Id { get; set; }

    public int AccountDatumId { get; set; }

    public decimal APR { get; set; }

    public DateTime EffectiveDate { get; set; }

    public virtual AccountDatum AccountDatum { get; set; } = null!;
}
