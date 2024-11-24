namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingDiscountApplication
{
    public int Id { get; set; }
    public int DiscountId { get; set; }
    public int EntityId { get; set; }
    public decimal DiscountValue { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatBillingDiscount? Discount { get; set; }
}
