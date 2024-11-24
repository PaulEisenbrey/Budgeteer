namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboJobLogEntry
{
    public int Id { get; set; }
    public int JobId { get; set; }
    public string? Message { get; set; }
    public string? Level { get; set; }
    public DateTime Inserted { get; set; }

    public virtual VmDboJob? Job { get; set; }
}
