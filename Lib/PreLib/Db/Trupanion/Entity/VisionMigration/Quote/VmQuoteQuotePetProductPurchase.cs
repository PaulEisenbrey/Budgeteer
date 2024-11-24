namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteQuotePetProductPurchase
{
    public int Id { get; set; }
    public int ProductPurchaseId { get; set; }
    public int TermId { get; set; }
    public int PetProductId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
