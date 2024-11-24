namespace Database.Trupanion.Entity.VisionMigration.PolicyLifecycleCore;

public class VmPLCPolicyPricingPeriod
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public int PolicyId { get; set; }
    public DateTime? RenewalDate { get; set; }
    public DateTime? RenewalProcessStartDate { get; set; }
    public int PetPolicyId { get; set; }
    public int CustomerId { get; set; }
}
