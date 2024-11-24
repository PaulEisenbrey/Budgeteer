namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteBasketPetProductDatum
{
    public int Id { get; set; }
    public int ProductDetailsId { get; set; }
    public int? FinancialsId { get; set; }
    public int? DiscountDetailId { get; set; }
    public int? BasketPetDataId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
