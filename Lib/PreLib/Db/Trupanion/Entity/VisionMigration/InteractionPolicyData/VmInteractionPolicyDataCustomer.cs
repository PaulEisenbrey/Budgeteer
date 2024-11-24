namespace Database.Trupanion.Entity.VisionMigration.InteractionPolicyData;

public class VmInteractionPolicyDataCustomer
{
    public int Id { get; set; }
    public Guid Reference { get; set; }

    public virtual List<VmInteractionPolicyDataPet> Pets { get; set; } = new();
}
