namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimExclusion
{
    public int ClaimExclusionId { get; set; }
    public string? ClaimExclusion1 { get; set; }
    public int? PolicyId { get; set; }
    public string? ClaimExclusionName { get; set; }
    public bool? IsDefaultLine { get; set; }
    public int? Sequence { get; set; }
    public string? EobBlurb { get; set; }
    public bool? IsFoodExclusion { get; set; }
    public int? EntityCategoryId { get; set; }
    public int? StateId { get; set; }

    public virtual TruDatDboEntityCategory? EntityCategory { get; set; }
    public virtual TruDatDboState? State { get; set; }
    public virtual List<TruDatDboClaim> Claims { get; set; } = new();
}
