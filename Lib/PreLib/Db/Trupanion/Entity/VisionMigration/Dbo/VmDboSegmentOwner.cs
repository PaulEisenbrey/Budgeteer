namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentOwner
{
    public int OwnerId { get; set; }
    public int SegmentId { get; set; }
    public string? DisqualifyReason { get; set; }
    public int? VisionClaimMigrationStatusId { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime ModifiedOn { get; set; }

    public virtual VmDboSegment? Segment { get; set; }
}
