namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCappedPolicy
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public string? Note { get; set; }
    public DateTime Inserted { get; set; }
    public decimal? UnCappedPremium { get; set; }
    public int? CapPercent { get; set; }
    public decimal? FromPremium { get; set; }
    public decimal? ToPremium { get; set; }
    public int? ToEngineId { get; set; }
    public int? RateAdjId { get; set; }
    public bool? Capped { get; set; }
}
