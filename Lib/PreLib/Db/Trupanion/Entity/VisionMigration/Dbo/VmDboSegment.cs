namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboSegment
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int SegmentTypeId { get; set; }
    public int? SegmentSelectionScriptId { get; set; }

    public virtual VmDboSegmentSelectionScript? SegmentSelectionScript { get; set; }
    public virtual VmDboSegmentType? SegmentType { get; set; }
    public virtual List<VmDboDataQualityExecution> DataQualityExecutions { get; set; } = new();
    public virtual List<VmDboJob> Jobs { get; set; } = new();
    public virtual List<VmDboSegmentBatch> SegmentBatches { get; set; } = new();
    public virtual List<VmDboSegmentOwner> SegmentOwners { get; set; } = new();
}
