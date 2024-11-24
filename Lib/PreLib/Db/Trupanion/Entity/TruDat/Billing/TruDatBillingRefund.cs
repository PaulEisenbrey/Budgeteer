namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingRefund
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public DateTime RefundDate { get; set; }
    public int ReasonId { get; set; }
    public int StatusId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual List<TruDatBillingRefundItem> RefundItems { get; set; } = new();
}
