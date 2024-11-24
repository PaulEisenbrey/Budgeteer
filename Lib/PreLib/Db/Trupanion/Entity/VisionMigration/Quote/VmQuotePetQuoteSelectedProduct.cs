namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuotePetQuoteSelectedProduct
{
    public int Id { get; set; }
    public int? ProductId { get; set; }
    public int? CoverOptionsId { get; set; }
    public int? PetId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
