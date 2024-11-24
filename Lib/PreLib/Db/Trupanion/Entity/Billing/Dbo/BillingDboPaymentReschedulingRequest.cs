namespace Database.Trupanion.Entity.Billing.Dbo;

public class BillingDboPaymentReschedulingRequest
{
    public int Id { get; set; }
    public int AccountId { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime RequestedDate { get; set; }
    public DateTime? OriginalReceivedOn { get; set; }
    public DateTime? RescheduledOn { get; set; }
    public int Status { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }

    public virtual BillingDboAccount? Account { get; set; }
    public virtual BillingDboPaymentReschedulingRequestStatus? StatusNavigation { get; set; }
}
