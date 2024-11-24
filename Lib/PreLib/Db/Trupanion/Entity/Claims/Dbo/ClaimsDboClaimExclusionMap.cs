namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimExclusionMap
{
    public int ExclusionId { get; set; }
    public string? ExclusionGroupMap { get; set; }
    public Guid? ExclusionUniqueId { get; set; }
    public int? CategoryId { get; set; }
}
