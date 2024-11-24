namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegmentBatch
{
    public Guid Id { get; set; }
    public int SegmentId { get; set; }
    public int? Size { get; set; }
    public DateTime CreatedOn { get; set; }
    public DateTime? StartedOn { get; set; }
    public DateTime? FinishedOn { get; set; }
    public bool? Success { get; set; }
    public int? AttachmentJobStatusId { get; set; }
    public string? Error { get; set; }

    public virtual VmDboSegment? Segment { get; set; }
    public virtual List<VmDboSegmentBatchOwner> SegmentBatchOwners { get; set; } = new();
    public virtual List<VmDboSegmentBatchPet> SegmentBatchPets { get; set; } = new();
}
