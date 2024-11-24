namespace Database.Trupanion.Entity.VisionMigration.Claims;

public class VMClaimsBatchFile
{
    public int Id { get; set; }
    public string? ExternalId { get; set; }
    public int? PetId { get; set; }
    public int? ClaimId { get; set; }
    public int? PolicyholderId { get; set; }
    public int? HospitalId { get; set; }
    public DateTimeOffset ActionDateTime { get; set; }
    public int? ActionType { get; set; }
    public int? Category { get; set; }
    public string? SearchField { get; set; }
    public string? DocumentType { get; set; }
    public string? FileName { get; set; }
    public Guid? UserId { get; set; }
    public int? RelatedPolicyholderId { get; set; }
    public Guid? BatchId { get; set; }
    public bool? Scanned { get; set; }
    public string? ExternalDocUrl { get; set; }
    public int? FileTypeEntityId { get; set; }
    public int? FileEntityId { get; set; }
    public int? FileMetadataId { get; set; }
}
