namespace Database.Trupanion.Entity.VisionMigration.InteractionPolicyData;

public class VmInteractionPolicyDataPet
{
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public int? CustomerId { get; set; }

    public virtual VmInteractionPolicyDataCustomer? Customer { get; set; }
    public virtual List<VmInteractionPolicyDataPolicy> Policies { get; set; } = new();
}
