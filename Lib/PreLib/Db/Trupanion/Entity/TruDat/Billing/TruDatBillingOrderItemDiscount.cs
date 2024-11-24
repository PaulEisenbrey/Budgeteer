namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingOrderItemDiscount
{
    public int Id { get; set; }
    public int OrderItemId { get; set; }
    public int DiscountId { get; set; }
    public decimal DiscountValue { get; set; }
    public decimal DiscountTax { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatBillingDiscount? Discount { get; set; }
    public virtual TruDatBillingOrderItem? OrderItem { get; set; }
}
