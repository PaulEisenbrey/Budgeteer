namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuotePricing
{
    public int Id { get; set; }
    public int CountryId { get; set; }
    public int CustomerId { get; set; }
    public int? PetPolicyId { get; set; }
}
