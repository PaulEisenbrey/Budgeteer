namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingOrderItemTaxBreakdown
{
    public int Id { get; set; }
    public int OrderItemId { get; set; }
    public int TaxRateId { get; set; }
    public decimal TaxPercentage { get; set; }
    public decimal TaxAmount { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatBillingOrderItem? OrderItem { get; set; }
    public virtual TruDatBillingTaxRate? TaxRate { get; set; }
}
