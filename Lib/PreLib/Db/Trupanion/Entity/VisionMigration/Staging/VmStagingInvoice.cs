namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingInvoice
{
    public int? Id { get; set; }
    public int? FileMetadataId { get; set; }
    public string? InvoiceNumber { get; set; }
    public string? VendorName { get; set; }
    public int PredictionFlags { get; set; }
    public string? CustomerName { get; set; }
    public Guid? BatchId { get; set; }
    public int? HospitalInvoiceId { get; set; }
    public int? OcrinvoiceId { get; set; }
    public int? ClaimId { get; set; }
    public int AssessmentDataId { get; set; }
    public bool? MultiSubmission { get; set; }
    public int InvoiceTotal { get; set; }
    public int Confidence { get; set; }
    public DateTime? InvoiceDate { get; set; }
}
