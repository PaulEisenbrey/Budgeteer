namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicyCoverageItem
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool TrackEffectiveDates { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual List<TruDatCoveragePolicyCoveragePackageItem> PolicyCoveragePackageItems { get; set; } = new();
    public virtual List<TruDatCoveragePolicyVersionCoverageItem> PolicyVersionCoverageItems { get; set; } = new();
}
