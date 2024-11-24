namespace Database.Trupanion.Entity.TruDat.Coverage;

public partial class TruDatCoveragePetPolicyCoverageEntity
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int EntityTypeId { get; set; }
    public int? EntityId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? EntityUniqueId { get; set; }

    public virtual TruDatCoverageEntityType? EntityType { get; set; }
}
