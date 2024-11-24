namespace Database.Trupanion.Entity.VisionMigration.Vision;

public class VmVisionLocationBodyPartMap
{
    public string? RollupLocation { get; set; }
    public short LocationId { get; set; }
    public byte BodyPartId { get; set; }
    public string? Other { get; set; }
    public string? BodyAltLocation { get; set; }
    public string? SecondaryVisLoc { get; set; }
    public int? ParentLocationId { get; set; }
}
