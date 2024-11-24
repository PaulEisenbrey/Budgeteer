namespace Database.Trupanion.Entity.TruDat.Coverage;

public partial class TruDatCoveragePolicyDocumentInventory
{
    public int Id { get; set; }
    public int PolicyDocumentId { get; set; }
    public int PolicyVersionId { get; set; }
    public int? EntityTypeId { get; set; }
    public int? EntityId { get; set; }
    public string? DocumentName { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public string? DocumentVersion { get; set; }
    public string? DmsdocumentId { get; set; }
    public string? DmsfileId { get; set; }

    public virtual TruDatCoverageEntityType? EntityType { get; set; }
    public virtual TruDatCoveragePolicyDocument? PolicyDocument { get; set; }
    public virtual TruDatCoveragePolicyVersion? PolicyVersion { get; set; }
}
