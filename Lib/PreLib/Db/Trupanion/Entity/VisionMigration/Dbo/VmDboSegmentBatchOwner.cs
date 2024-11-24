namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentBatchOwner
{
    public int OwnerId { get; set; }
    public Guid Ref { get; set; }
    public int? VisionCustomerId { get; set; }
    public Guid BatchId { get; set; }

    public virtual VmDboSegmentBatch? Batch { get; set; }
}
