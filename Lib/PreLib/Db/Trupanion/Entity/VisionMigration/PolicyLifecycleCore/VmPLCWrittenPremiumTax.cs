namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCWrittenPremiumTax
{
    public int Id { get; set; }
    public int WrittenPremiumId { get; set; }
    public decimal Amount { get; set; }
    public decimal Rate { get; set; }
    public string? Name { get; set; }
    public decimal AdjustmentAmount { get; set; }
    public int PetPolicyId { get; set; }
    public int CustomerId { get; set; }

    public virtual VmPLCWrittenPremium? WrittenPremium { get; set; }
}
