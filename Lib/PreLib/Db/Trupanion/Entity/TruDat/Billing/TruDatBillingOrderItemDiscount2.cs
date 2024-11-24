namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingOrderItemDiscount2
{
    public int Id { get; set; }
    public int OrderItemId { get; set; }
    public int DiscountId { get; set; }
    public decimal DiscountValue { get; set; }
    public decimal DiscountTax { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
