namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboExclusion
{
    public ClaimsDboExclusion()
    {
        ExclusionTexts = new HashSet<ClaimsDboExclusionText>();
    }

    public Guid Id { get; set; }
    public string? Name { get; set; }
    public string? ExclusionText { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public bool AppliesToOvertCondition { get; set; }

    public virtual ICollection<ClaimsDboExclusionText> ExclusionTexts { get; set; }
}
