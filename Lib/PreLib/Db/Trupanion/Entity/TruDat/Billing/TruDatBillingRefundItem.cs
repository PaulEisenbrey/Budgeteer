namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingRefundItem
{
    public int Id { get; set; }
    public int RefundId { get; set; }
    public int OrderItemId { get; set; }
    public int? ProratedDays { get; set; }
    public decimal Amount { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatBillingOrderItem? OrderItem { get; set; }
    public virtual TruDatBillingRefund? Refund { get; set; }
}
