namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCPolicyYear
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int PetPolicyId { get; set; }
    public int CustomerId { get; set; }

    public virtual List<VmPLCCoverageTerm> CoverageTerms { get; set; } = new();
}
