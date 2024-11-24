namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingTaxApplication
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<TruDatBillingTaxRate> TaxRates { get; set; } = new();
}
