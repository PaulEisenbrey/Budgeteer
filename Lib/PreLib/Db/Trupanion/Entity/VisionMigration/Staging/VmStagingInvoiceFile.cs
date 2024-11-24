namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingInvoiceFile
{
    public int ExternalId { get; set; }
    public int? PetId { get; set; }
    public int ClaimId { get; set; }
    public int Category { get; set; }
    public string? FileName { get; set; }
    public bool? Scanned { get; set; }
    public DateTime? CreateDate { get; set; }
    public string? ExternalDocUrl { get; set; }
    public int ExtRef { get; set; }
    public int? AttachmentId { get; set; }
    public Guid? BatchId { get; set; }
}
