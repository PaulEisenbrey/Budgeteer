namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingPaymentMethod
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public Guid? UniqueTypeId { get; set; }

    public virtual List<TruDatBillingClaimPayment> ClaimPayments { get; set; } = new();
    public virtual List<TruDatBillingPaymentAttempt> PaymentAttempts { get; set; } = new();
}
