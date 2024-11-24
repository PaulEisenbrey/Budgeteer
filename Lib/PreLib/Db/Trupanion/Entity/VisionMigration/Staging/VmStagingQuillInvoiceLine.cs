namespace Database.Trupanion.Entity.VisionMigration.Staging;

public class VmStagingQuillInvoiceLine
{
    public int? Id { get; set; }
    public int? InvoiceId { get; set; }
    public bool? Excluded { get; set; }
    public int PolicySectionId { get; set; }
    public int? DeductionTypeId { get; set; }
    public Guid CreatedById { get; set; }
    public Guid EditedById { get; set; }
    public int? LineNumber { get; set; }
    public int? ClaimConditionId { get; set; }
    public int ExtRef { get; set; }
    public DateTime? Date { get; set; }
    public decimal? Amount { get; set; }
    public decimal? Quantity { get; set; }
    public string? Description { get; set; }
    public int? ItemType { get; set; }
    public Guid? BatchId { get; set; }
    public string? PetName { get; set; }
    public int Confidence { get; set; }
}
