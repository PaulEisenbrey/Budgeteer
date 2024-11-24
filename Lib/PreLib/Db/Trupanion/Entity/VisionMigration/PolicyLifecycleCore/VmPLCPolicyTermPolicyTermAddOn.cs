namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCPolicyTermPolicyTermAddOn
{
    public int AddOnsId { get; set; }
    public int PolicyTermsId { get; set; }
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public int PetPolicyId { get; set; }
    public int CustomerId { get; set; }

    public virtual VmPLCPolicyTermAddOnProductCoverOption? AddOns { get; set; }
    public virtual VmPLCPolicyTerm? PolicyTerms { get; set; }
}
