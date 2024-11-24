namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentBatchClaim
{
    public int ClaimId { get; set; }
    public Guid? BatchId { get; set; }
    public int? LinkedGroupId { get; set; }
    public Guid? Ref { get; set; }
    public string? Operation { get; set; }
}
