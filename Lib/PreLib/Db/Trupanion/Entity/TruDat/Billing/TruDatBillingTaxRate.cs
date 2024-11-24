            namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingTaxRate
{
    public int Id { get; set; }
    public int TaxApplicationId { get; set; }
    public int EntityId { get; set; }
    public decimal Rate { get; set; }
    public string? TaxDesc { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatBillingTaxApplication? TaxApplication { get; set; }
    public virtual List<TruDatBillingOrderItemTaxBreakdown> OrderItemTaxBreakdowns { get; set; } = new();
}
