namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingOrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ItemId { get; set; }
    public int? PetPolicyId { get; set; }
    public int? ProratedDays { get; set; }
    public int? CharityId { get; set; }
    public decimal Subtotal { get; set; }
    public decimal Taxtotal { get; set; }
    public int StatusId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatBillingItem? Item { get; set; }
    public virtual TruDatBillingOrder? Order { get; set; }
    public virtual List<TruDatBillingOrderItemDiscount> OrderItemDiscounts { get; set; } = new();
    public virtual List<TruDatBillingOrderItemTaxBreakdown> OrderItemTaxBreakdowns { get; set; } = new();
    public virtual List<TruDatBillingRefundItem> RefundItems { get; set; } = new();
}
