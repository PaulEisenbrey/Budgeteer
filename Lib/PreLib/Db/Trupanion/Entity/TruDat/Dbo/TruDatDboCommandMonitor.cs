namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCommandMonitor
{
    public Guid Id { get; set; }
    public Guid CommandId { get; set; }
    public Guid EntityUniqueId { get; set; }
    public DateTime StartedDateTimeUtc { get; set; }
    public DateTime DueDateTimeUtc { get; set; }
    public bool IsComplete { get; set; }
}
