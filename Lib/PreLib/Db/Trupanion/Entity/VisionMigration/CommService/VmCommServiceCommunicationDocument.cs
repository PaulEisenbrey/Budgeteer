namespace Database.Trupanion.Entity.VisionMigration.CommService;

public class VmCommServiceCommunicationDocument
{
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public string? FilePath { get; set; }
    public int? FileMetadataId { get; set; }
    public int Status { get; set; }
    public int DocumentType { get; set; }
    public int CommunicationId { get; set; }
    public bool CanBeSkipped { get; set; }
    public int CustomerId { get; set; }
}
