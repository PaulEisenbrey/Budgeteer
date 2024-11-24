namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyCoveragePackage
{
    public int Id { get; set; }
    public string? RegulatoryName { get; set; }
    public string? MarketingName { get; set; }
    public string? Description { get; set; }
    public string? PolicyDocumentHref { get; set; }
    public int CostId { get; set; }
    public int RateId { get; set; }
    public int? Sequence { get; set; }
    public bool? Active { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public bool? HideDuringEnrollment { get; set; }
    public Guid EndorsementUniqueId { get; set; }

    public virtual List<TruDatCoveragePolicyCoveragePackageItem> PolicyCoveragePackageItems { get; set; } = new();
    public virtual List<TruDatCoveragePolicyVersionCoveragePackage> PolicyVersionCoveragePackages { get; set; } = new();
}
