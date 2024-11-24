namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteProductPremium
{
    public int Id { get; set; }
    public decimal DiscountedPremium { get; set; }
    public decimal Premium { get; set; }
    public decimal Payable { get; set; }
    public decimal Discount { get; set; }
    public decimal Fee { get; set; }
    public decimal Tax { get; set; }
    public decimal FirstMonthPayable { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
