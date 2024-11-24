namespace Database.Trupanion.Entity.TruDat.Coverage;

public partial class TruDatCoverageGroupPolicyVersionState
{
    public int Id { get; set; }
    public int PolicyVersionId { get; set; }
    public int StateId { get; set; }
    public DateTime EffectiveFrom { get; set; }
    public DateTime? EffectiveTo { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }

    public virtual TruDatCoveragePolicyVersion? PolicyVersion { get; set; }
}
