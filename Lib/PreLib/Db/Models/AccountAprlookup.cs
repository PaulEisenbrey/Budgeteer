using Utilities.EntityBaseClasses;

namespace Database.Models;

public partial class AccountAprlookup : EntityIntId
{
    public int AccountDataId { get; set; }

    public int AnnualPercentageRateId { get; set; }

    public virtual AccountDatum AccountData { get; set; } = new();

    public virtual AnnualPercentageRate AnnualPercentageRate { get; set; } = new();
}
