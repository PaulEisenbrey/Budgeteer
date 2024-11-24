namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyVersionCoveragePackage
{
    public int Id { get; set; }
    public int PolicyVersionId { get; set; }
    public int PolicyPackageId { get; set; }
    public decimal? FixedCost { get; set; }
    public bool IsOptional { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public bool? IsDecPageVisible { get; set; }
    public string? PreferredName { get; set; }

    public virtual TruDatCoveragePolicyCoveragePackage? PolicyPackage { get; set; }
    public virtual TruDatCoveragePolicyVersion? PolicyVersion { get; set; }
}
