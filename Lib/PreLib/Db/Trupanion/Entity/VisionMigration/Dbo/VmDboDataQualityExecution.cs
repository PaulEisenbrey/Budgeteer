namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboDataQualityExecution
{
    public int Id { get; set; }
    public DateTime ExecutionDate { get; set; }
    public int? JobId { get; set; }
    public int? SegmentId { get; set; }
    public int? TotalFailureCount { get; set; }

    public virtual VmDboJob? Job { get; set; }
    public virtual VmDboSegment? Segment { get; set; }
    public virtual List<VmDboDataQualityResult> DataQualityResults { get; set; } = new();
}
