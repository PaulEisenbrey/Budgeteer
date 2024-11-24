namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingUserMap
{
    public int LegacyUserId { get; set; }
    public Guid VisionGuidId { get; set; }
}
