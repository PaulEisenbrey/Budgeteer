namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteFinancialsDatum
{
    public int Id { get; set; }
    public decimal Premium { get; set; }
    public decimal Discount { get; set; }
    public decimal Tax { get; set; }
    public decimal Fee { get; set; }
    public decimal Total { get; set; }
    public int CountryId { get; set; }
    public int CustomerId { get; set; }
    public int? PetPolicyId { get; set; }
}
