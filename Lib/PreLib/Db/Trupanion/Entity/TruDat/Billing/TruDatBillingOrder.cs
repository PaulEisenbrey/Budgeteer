namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingOrder
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public DateTime BillingDate { get; set; }
    public DateTime ScheduledPaymentDate { get; set; }
    public bool AutomatedGeneration { get; set; }
    public int StatusId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public int? CorporateAccountId { get; set; }

    public virtual List<TruDatBillingOrderItem> OrderItems { get; set; } = new();
    public virtual List<TruDatBillingPaymentAttemptOrder> PaymentAttemptOrders { get; set; } = new();
}
