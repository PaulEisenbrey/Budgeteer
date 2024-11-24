namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboCommandStatus
{
    public Guid Id { get; set; }
    public Guid CommandId { get; set; }
    public Guid EntityUniqueId { get; set; }
    public DateTimeOffset StartDateTimeUtc { get; set; }
    public DateTimeOffset DueDateTimeUtc { get; set; }
    public bool IsCanceled { get; set; }
    public Guid CommandTypeId { get; set; }
}
