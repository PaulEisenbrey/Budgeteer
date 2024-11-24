namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuotePricingPetProductDatum
{
    public int Id { get; set; }
    public bool CanBeSelected { get; set; }
    public int MonthlyPremiumId { get; set; }
    public int PetId { get; set; }
    public DateTime CoverEndDate { get; set; }
    public DateTime CoverStartDate { get; set; }
    public int ProductRatingId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
