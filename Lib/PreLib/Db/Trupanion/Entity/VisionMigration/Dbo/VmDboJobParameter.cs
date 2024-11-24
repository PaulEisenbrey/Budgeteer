namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboJobParameter
{
    public int Id { get; set; }
    public int JobId { get; set; }
    public string? Name { get; set; }
    public string? Value { get; set; }

    public virtual VmDboJob? Job { get; set; }
}
