namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboBatchQueue
{
    public Guid Id { get; set; }
    public bool? Success { get; set; }
    public DateTime? QueuedOn { get; set; }
    public DateTime? ScheduledOn { get; set; }
    public DateTime? FinishedOn { get; set; }
    public int? NumberOfCustomers { get; set; }
    public int? SegmentId { get; set; }
}
