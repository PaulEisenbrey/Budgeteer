namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimReviewedEventSource
{
    public int Id { get; set; }
    public Guid UniqueId { get; set; }
    public string? ClaimsJson { get; set; }
}
