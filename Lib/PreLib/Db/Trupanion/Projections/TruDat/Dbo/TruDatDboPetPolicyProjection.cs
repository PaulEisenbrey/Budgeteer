namespace Database.Trupanion.Projections.TruDat.Dbo;

public class TruDatDboPetPolicyProjection
{
    public int Id { get; set; }
    public int PetId { get; set; }
    public int? PolicyId { get; set; }
    public DateTime PolicyDate { get; set; }
    public string? PolicyNumber { get; set; }
    public string? TagNumber { get; set; }
    public int PolicyAgeId { get; set; }
    public int? EngineVersionId { get; set; }
    public int? DocumentVersionId { get; set; }
    public int? AdjustmentMonth { get; set; }
    public int? AdjustmentYear { get; set; }
    public Guid UniqueId { get; set; }
    public Guid? PlanId { get; set; }
    public decimal? CoinsurancePercentage { get; set; }
    public Guid? ProductId { get; set; }
    public DateTime? ProductEffectiveDateUtc { get; set; }
}
