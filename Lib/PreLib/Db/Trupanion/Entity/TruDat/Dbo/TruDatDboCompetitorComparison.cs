namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCompetitorComparison
{
    public int Id { get; set; }
    public string? CompetitorName { get; set; }
    public decimal? CompetitorDogPremium { get; set; }
    public decimal? CompetitorCatPremium { get; set; }
    public string? CompetitorDescription { get; set; }
    public decimal? TruEquivDogPremium { get; set; }
    public decimal? TruEquivCatPremium { get; set; }
    public string? TruDescription { get; set; }
    public bool? Active { get; set; }
    public DateTime? Inserted { get; set; }
    public DateTime? Updated { get; set; }
}
