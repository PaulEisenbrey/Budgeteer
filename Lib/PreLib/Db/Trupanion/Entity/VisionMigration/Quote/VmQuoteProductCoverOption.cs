namespace Database.Trupanion.Entity.VisionMigration.Quote;

public class VmQuoteProductCoverOption
{
    public int Id { get; set; }
    public string? Limit { get; set; }
    public string? CoInsurance { get; set; }
    public string? Excess { get; set; }
    public int CustomerId { get; set; }
    public int PetPolicyId { get; set; }
}
