namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentBatchClaimPayment
{
    public int Id { get; set; }
    public int EntityPaymentGroupId { get; set; }
    public int LastEntityPaymentGroupId { get; set; }
    public int? CheckId { get; set; }
    public string? Last4 { get; set; }
    public int PaymentStatusId { get; set; }
    public int AccountId { get; set; }
    public int PaymentBatchId { get; set; }
    public Guid? BatchId { get; set; }
    public DateTime? Inserted { get; set; }
    public string? Response { get; set; }
    public int? ClaimId { get; set; }
}
