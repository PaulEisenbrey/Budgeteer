namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingClaimPaymentLegacy
{
    public int? Id { get; set; }
    public int ClaimId { get; set; }
    public int? PaymentAccountId { get; set; }
    public decimal? Gross { get; set; }
    public DateTimeOffset? TransactionDate { get; set; }
    public int PaymentType { get; set; }
    public Guid CreatedById { get; set; }
    public DateTimeOffset? CreatedDateTime { get; set; }
    public string? Comment { get; set; }
    public int PaymentStatus { get; set; }
    public int ExtRef { get; set; }
    public Guid? BatchId { get; set; }
}
