namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboJobTypeParameter
{
    public int Id { get; set; }
    public int JobTypeId { get; set; }
    public string? Name { get; set; }
    public string? DefaultValue { get; set; }

    public virtual VmDboJobType? JobType { get; set; }
}
