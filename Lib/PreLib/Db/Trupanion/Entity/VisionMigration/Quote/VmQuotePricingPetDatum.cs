namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuotePricingPetDatum
{
    public int Id { get; set; }
    public Guid Reference { get; set; }
    public int PricingId { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
