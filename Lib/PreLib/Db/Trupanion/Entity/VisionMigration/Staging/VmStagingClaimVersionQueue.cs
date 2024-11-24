namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingClaimVersionQueue
{
    public int ClaimId { get; set; }
    public int AssessmentDataId { get; set; }
    public int? AssessmentDataModId { get; set; }
    public Guid? BatchId { get; set; }
}
