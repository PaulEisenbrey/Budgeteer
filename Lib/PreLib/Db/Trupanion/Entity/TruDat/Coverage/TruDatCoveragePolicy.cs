namespace Database.Trupanion.Entity.TruDat.Coverage;

public class TruDatCoveragePolicy
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public decimal MinDeductible { get; set; }
    public decimal MaxDeductible { get; set; }
    public decimal? MaximumLifetimeBenefitsPayment { get; set; }
    public decimal CoinsurancePercentage { get; set; }
    public int WaitingPeriodForAccident { get; set; }
    public int WaitingPeriodForIllness { get; set; }
    public bool? Active { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }

    public virtual List<TruDatCoveragePolicyVersion> PolicyVersions { get; set; } = new();
}
