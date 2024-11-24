namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboJobStatus
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<VmDboJob> Jobs { get; set; } = new();
}
