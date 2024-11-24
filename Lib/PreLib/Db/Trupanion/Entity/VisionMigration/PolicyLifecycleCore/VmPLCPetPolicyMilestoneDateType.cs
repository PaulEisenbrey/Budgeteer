namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCPetPolicyMilestoneDateType
{
    public int Id { get; set; }
    public string? Description { get; set; }
    public bool PolicyYear { get; set; }
    public bool CoverageTerm { get; set; }
    public bool PolicyTerm { get; set; }

    public virtual List<VmPLCPetPolicyMilestoneDate> PetPolicyMilestoneDates { get; set; } = new();
}
