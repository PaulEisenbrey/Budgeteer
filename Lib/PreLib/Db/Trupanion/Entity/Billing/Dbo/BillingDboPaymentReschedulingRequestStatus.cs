namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboPaymentReschedulingRequestStatus
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<BillingDboPaymentReschedulingRequest> PaymentReschedulingRequests { get; set; } = new();
}
