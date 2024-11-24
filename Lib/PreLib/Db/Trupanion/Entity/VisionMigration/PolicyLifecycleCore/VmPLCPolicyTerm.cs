namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCPolicyTerm
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int CustomerId { get; set; }
    public int PolicyId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Status { get; set; }
    public int? CurrentVersionId { get; set; }
    public string? ProductCode { get; set; }
    public decimal? Limit { get; set; }
    public decimal? CoInsurance { get; set; }
    public decimal? Excess { get; set; }
    public Guid PaClaimsSyncId { get; set; }
    public int Length { get; set; }
    public int LengthType { get; set; }
    public decimal DiscountedPeriodicalPremium { get; set; }
    public int CoverageTermId { get; set; }

    public virtual VmPLCCoverageTerm? CoverageTerm { get; set; }
    public virtual VmPLCPolicy? Policy { get; set; }
    public virtual List<VmPLCPolicyTermPolicyTermAddOn> PolicyTermPolicyTermAddOns { get; set; } = new();
}
