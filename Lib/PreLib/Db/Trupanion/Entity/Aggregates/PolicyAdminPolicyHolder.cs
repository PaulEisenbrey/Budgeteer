using Database.Trupanion.Entity.TruDat.PolicyAdmin;

namespace Database.Trupanion.Entity.Aggregates;

public class PolicyAdminPolicyHolder
{
    private List<int> petIds = new();
    public TruDatPolicyAdminPolicyholderDatum PolicyHolderData { get; set; } = new();

    public List<TruDatPolicyAdminPendingPetPolicyChange> PetPolicyChange { get; set; } = new();
    public List<TruDatPolicyAdminPetPolicy> PetPolicies { get; set; } = new();
    public List<TruDatPolicyAdminPetPolicyDatum> PetPolicyData { get; set; } = new();
}
