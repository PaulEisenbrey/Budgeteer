namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboRateAdjRedoPuertoRico
{
    public int Id { get; set; }
    public int PetPolicyId { get; set; }
    public int OwnerId { get; set; }
    public decimal? PendingPremium { get; set; }
    public decimal? CurrentPremium { get; set; }
    public decimal? NewPendingPremium { get; set; }
    public int? OldRateAdjustmentId { get; set; }
    public int? NewRateAdjustmentId { get; set; }
    public bool? Complete { get; set; }
    public string? Note { get; set; }
    public DateTime? DateAsOf { get; set; }
    public int? CaseCategoryId { get; set; }
    public string? Petname { get; set; }
    public DateTime? Effectivedate { get; set; }
    public DateTime? Neweffectivedate { get; set; }
}
