namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingPaymentAttemptOrder
{
    public int PaymentAttemptId { get; set; }
    public int OrderId { get; set; }
    public decimal PaymentAmount { get; set; }
    public string? PaymentMethodLast4 { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatBillingOrder? Order { get; set; }
    public virtual TruDatBillingPaymentAttempt? PaymentAttempt { get; set; }
}
