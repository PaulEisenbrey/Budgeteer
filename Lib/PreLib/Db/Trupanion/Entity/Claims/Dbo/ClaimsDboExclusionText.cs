namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboExclusionText
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid ExclusionId { get; set; }
    public string? VersionNumber { get; set; }
    public string? Text { get; set; }

    public virtual ClaimsDboExclusion? Exclusion { get; set; }
}
