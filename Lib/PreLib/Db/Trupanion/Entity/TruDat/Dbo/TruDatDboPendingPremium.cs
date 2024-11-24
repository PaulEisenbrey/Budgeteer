namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPendingPremium
{
    public int Id { get; set; }
    public DateTime EffectiveDate { get; set; }
    public int PetPolicyId { get; set; }
    public string? PendingValue { get; set; }
    public decimal? UnCappedPremium { get; set; }
}
