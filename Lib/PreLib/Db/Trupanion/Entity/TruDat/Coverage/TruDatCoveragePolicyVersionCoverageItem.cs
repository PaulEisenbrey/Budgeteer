namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyVersionCoverageItem
{
    public int Id { get; set; }
    public int PolicyVersionId { get; set; }
    public int PolicyCoverageItemId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual TruDatCoveragePolicyCoverageItem? PolicyCoverageItem { get; set; }
    public virtual TruDatCoveragePolicyVersion? PolicyVersion { get; set; }
}
