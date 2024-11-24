namespace Database.Trupanion.Entity.TruDat.Claim;

public class TruDatBillingClaimPayment
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public DateTime ProcessDate { get; set; }
    public int ClaimId { get; set; }
    public int StatusId { get; set; }
    public int PaymentMethodId { get; set; }
    public decimal? Amount { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public int? EntityId { get; set; }
    public int EntityTypeId { get; set; }
    public int? AssessmentDataId { get; set; }
    public string? AuditFlagName { get; set; }
    public Guid? ReceivingPartyId { get; set; }
    public Guid? PaymentUnderwriterId { get; set; }

    public virtual TruDatBillingPaymentMethod? PaymentMethod { get; set; }
}
