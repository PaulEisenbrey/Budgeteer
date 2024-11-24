namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteBasketPetProductDetailDatum
{
    public int Id { get; set; }
    public int? ProductId { get; set; }
    public int? FinancialsId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
