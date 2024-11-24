namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingUserDeduction
{
    public int DeductionTypeId { get; set; }
    public int? ClaimItemId { get; set; }
    public decimal? Amount { get; set; }
    public string? ExclusionGroupName { get; set; }
    public int AssessmentDataId { get; set; }
    public int ClaimId { get; set; }
    public int? ExtRef { get; set; }
    public Guid? BatchId { get; set; }
}
