namespace Database.Trupanion.Entity.VisionMigration.InteractionPolicyData;

public class VmInteractionPolicyDataPolicy
{
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public int? PetId { get; set; }
    public int CustomerId { get; set; }

    public virtual VmInteractionPolicyDataPet? Pet { get; set; }
}
