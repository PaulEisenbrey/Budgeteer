namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoverageEntityPolicyDocument
{
    public int Id { get; set; }
    public int PolicyDocumentId { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int? EntityTypeId2 { get; set; }
    public int? EntityId2 { get; set; }
    public int? EntityTypeId3 { get; set; }
    public int? EntityId3 { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual TruDatCoverageEntityType? EntityType { get; set; }
    public virtual TruDatCoverageEntityType? EntityTypeId2Navigation { get; set; }
    public virtual TruDatCoverageEntityType? EntityTypeId3Navigation { get; set; }
    public virtual TruDatCoveragePolicyDocument? PolicyDocument { get; set; }
}
