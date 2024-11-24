namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingPolicyDocumentMap
{
    public int Id { get; set; }
    public string? DocumentName { get; set; }
    public string? PolicyPath { get; set; }
    public int? FileMetadataId { get; set; }
    public string? FilePath { get; set; }
}
