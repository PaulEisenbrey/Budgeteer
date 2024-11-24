namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentBatchClaimVersion
{
    public int ClaimId { get; set; }
    public int AssessmentDataId { get; set; }
    public int? AssessmentDataModId { get; set; }
    public Guid? BatchId { get; set; }
    public int? CategoryId { get; set; }
    public int? LinkedGroupId { get; set; }
    public int? VisionParentId { get; set; }
    public int Id { get; set; }
    public Guid? Ref { get; set; }
    public string? Operation { get; set; }
}
