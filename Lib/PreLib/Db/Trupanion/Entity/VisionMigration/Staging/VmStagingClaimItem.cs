namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingClaimItem
{
    public int? Id { get; set; }
    public int ClaimId { get; set; }
    public int? ClaimConditionId { get; set; }
    public int PolicySectionId { get; set; }
    public int TreatmentPeriodType { get; set; }
    public DateTime? TreatmentStartDate { get; set; }
    public DateTime? TreatmentEndDate { get; set; }
    public decimal? Amount { get; set; }
    public decimal? TotalAmount { get; set; }
    public int? FileMetadataId { get; set; }
    public int? NonFinancialNumber { get; set; }
    public int? WaitingPeriodId { get; set; }
    public decimal? IneligibleAmount { get; set; }
    public int? OriginalClaimId { get; set; }
    public int? ExtRef { get; set; }
    public Guid? BatchId { get; set; }
}
