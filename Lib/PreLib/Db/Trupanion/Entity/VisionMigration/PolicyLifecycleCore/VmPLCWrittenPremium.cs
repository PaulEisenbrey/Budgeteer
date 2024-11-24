namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCWrittenPremium
{
    public int Id { get; set; }
    public int AdjustmentTypeId { get; set; }
    public DateTime CoverFrom { get; set; }
    public DateTime CoverTo { get; set; }
    public decimal FullTermPremium { get; set; }
    public int TermVersionId { get; set; }
    public DateTime AdjustmentRequestDate { get; set; }
    public decimal PremiumAdjustment { get; set; }
    public int PetPolicyId { get; set; }
    public int CustomerId { get; set; }

    public virtual List<VmPLCWrittenPremiumTax> WrittenPremiumTaxes { get; set; } = new();
}
