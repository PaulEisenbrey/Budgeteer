namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingDiscountEngine
{
    public int DiscountId { get; set; }
    public int EngineId { get; set; }

    public virtual TruDatBillingDiscount? Discount { get; set; }
}
