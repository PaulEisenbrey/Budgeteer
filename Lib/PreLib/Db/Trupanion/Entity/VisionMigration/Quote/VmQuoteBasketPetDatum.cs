namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteBasketPetDatum
{
    public int Id { get; set; }
    public int? FinancialsId { get; set; }
    public Guid Reference { get; set; }
    public int? BasketId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
