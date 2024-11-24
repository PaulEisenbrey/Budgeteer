namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingFileQueue
{
    public int Id { get; set; }
    public int? ActionType { get; set; }
    public DateTimeOffset ActionDateTime { get; set; }
    public Guid? UserId { get; set; }
    public int? ClaimId { get; set; }
    public int? PetId { get; set; }
    public int? CustomerId { get; set; }
    public int? Category { get; set; }
    public string? FileName { get; set; }
    public bool? Scanned { get; set; }
    public string? ExternalDocUrl { get; set; }
    public int? FileTypeEntityId { get; set; }
    public int? FileEntityId { get; set; }
    public string? SearchField { get; set; }
    public string? Value { get; set; }
    public int? FileMetadataId { get; set; }
    public int? RelatedPolicyholderId { get; set; }
    public Guid? BatchId { get; set; }
}
