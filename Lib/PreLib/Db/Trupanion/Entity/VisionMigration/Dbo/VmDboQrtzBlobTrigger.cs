namespace Database.Trupanion.Entity.VisionMigration.Dbo;

public class VmDboQrtzBlobTrigger
{
    public string? SchedName { get; set; }
    public string? TriggerName { get; set; }
    public string? TriggerGroup { get; set; }
    public byte[]? BlobData { get; set; }
}
