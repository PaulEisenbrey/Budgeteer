namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingLogError
{
    public int Id { get; set; }
    public string? Error { get; set; }
    public string? MoreInfo { get; set; }
    public int? EntityId { get; set; }
    public int? EntityTypeId { get; set; }
}
