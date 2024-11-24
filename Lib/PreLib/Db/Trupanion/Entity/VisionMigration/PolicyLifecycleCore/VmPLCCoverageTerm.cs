namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCCoverageTerm
{
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public int PolicyYearId { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int PetPolicyId { get; set; }
    public int CustomerId { get; set; }

    public virtual VmPLCPolicyYear? PolicyYear { get; set; }
    public virtual List<VmPLCPolicyTerm> PolicyTerms { get; set; } = new();
}
