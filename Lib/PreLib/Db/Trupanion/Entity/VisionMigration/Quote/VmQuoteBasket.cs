namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteBasket
{
    public int Id { get; set; }
    public int FinancialsId { get; set; }
    public int CountryId { get; set; }
    public int CustomerId { get; set; }
    public int? PetPolicyId { get; set; }
}
