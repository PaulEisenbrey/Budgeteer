namespace Database.Trupanion.Entity.TruDat.Coverage;

public partial class TruDatCoveragePolicyCoveragePackageItem
{
    public int Id { get; set; }
    public int PolicyCoveragePackageId { get; set; }
    public int PolicyCoverageItemId { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual TruDatCoveragePolicyCoverageItem? PolicyCoverageItem { get; set; }
    public virtual TruDatCoveragePolicyCoveragePackage? PolicyCoveragePackage { get; set; }
}
