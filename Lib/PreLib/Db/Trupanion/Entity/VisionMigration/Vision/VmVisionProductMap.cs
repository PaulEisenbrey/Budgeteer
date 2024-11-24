namespace Database.Trupanion.Entity.VisionMigration.Vision;

public class VmVisionProductMap
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int ProductId { get; set; }
    public int? EntityId { get; set; }
    public Guid? EntityUniqueId { get; set; }
    public int? BrandId { get; set; }
}
