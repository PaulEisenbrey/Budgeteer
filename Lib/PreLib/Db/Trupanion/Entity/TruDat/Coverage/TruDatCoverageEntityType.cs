namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoverageEntityType
{
    public int Id { get; set; }
    public string? SchemaName { get; set; }
    public string? TableName { get; set; }
    public bool HasWaitingPeriods { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual List<TruDatCoverageEntityPolicyDocument> EntityPolicyDocumentEntityTypeId2Navigations { get; set; } = new();
    public virtual List<TruDatCoverageEntityPolicyDocument> EntityPolicyDocumentEntityTypeId3Navigations { get; set; } = new();
    public virtual List<TruDatCoverageEntityPolicyDocument> EntityPolicyDocumentEntityTypes { get; set; } = new();
    public virtual List<TruDatCoverageEntityWaitingPeriod> EntityWaitingPeriods { get; set; } = new();
    public virtual List<TruDatCoveragePetPolicyCoverageEntity> PetPolicyCoverageEntities { get; set; } = new();
    public virtual List<TruDatCoveragePolicyDocumentInventory> PolicyDocumentInventories { get; set; } = new();
}
