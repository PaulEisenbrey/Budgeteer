namespace Database.Trupanion.Entity.Workflow;

public class WFDboSystemCleanup
{
    public int Id { get; set; }
    public int CleanupId { get; set; }
    public int ActiveDays { get; set; }
    public DateTimeOffset LastCleanupDate { get; set; }
}
