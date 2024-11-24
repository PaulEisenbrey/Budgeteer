namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboJob
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public int StatusId { get; set; }
    public DateTime? Start { get; set; }
    public DateTime? Complete { get; set; }
    public int JobTypeId { get; set; }
    public string? FailureDetails { get; set; }
    public int? ParentId { get; set; }
    public bool? SuppressChildJobs { get; set; }
    public int SegmentId { get; set; }

    public virtual VmDboJobType? JobType { get; set; }
    public virtual VmDboSegment? Segment { get; set; }
    public virtual VmDboJobStatus? Status { get; set; }
    public virtual List<VmDboDataQualityExecution> DataQualityExecutions { get; set; } = new();
    public virtual List<VmDboJobLogEntry> JobLogEntries { get; set; } = new();
    public virtual List<VmDboJobParameter> JobParameters { get; set; } = new();
}
