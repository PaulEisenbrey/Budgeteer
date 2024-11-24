namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimExclusion
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int? ClaimExclusionListId { get; set; }
    public string? Name { get; set; }
    public string? Label { get; set; }
    public string? Wording { get; set; }
    public string? Blurb { get; set; }

    public virtual ClaimsDboClaimExclusionList? ClaimExclusionList { get; set; }
}
