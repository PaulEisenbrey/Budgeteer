namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyDocument
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? DisplayName { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual List<TruDatCoverageEntityPolicyDocument> EntityPolicyDocuments { get; set; } = new();
    public virtual List<TruDatCoveragePolicyDocumentInventory> PolicyDocumentInventories { get; set; } = new();
}
