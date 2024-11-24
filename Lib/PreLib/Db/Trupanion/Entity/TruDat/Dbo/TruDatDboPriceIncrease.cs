namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPriceIncrease
{
    public int OwnerId { get; set; }
    public int PetPolicyId { get; set; }
    public bool? Scheduled { get; set; }
    public decimal? ExistingPremium { get; set; }
    public decimal? NewPremium { get; set; }
    public decimal? Differ { get; set; }
    public bool? InvalidEmail { get; set; }
    public bool? PhysicallyMailed { get; set; }
    public bool? HasActivePets { get; set; }
}
