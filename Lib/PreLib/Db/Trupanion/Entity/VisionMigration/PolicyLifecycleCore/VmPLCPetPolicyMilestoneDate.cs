namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCPetPolicyMilestoneDate
{
    public int PetPolicyId { get; set; }
    public DateTime MilestoneDate { get; set; }
    public int TypeId { get; set; }

    public virtual VmPLCPetPolicyMilestoneDateType? Type { get; set; }
}
