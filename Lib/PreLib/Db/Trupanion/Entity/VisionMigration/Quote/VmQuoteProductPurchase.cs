namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteProductPurchase
{
    public int Id { get; set; }
    public int ProductId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
