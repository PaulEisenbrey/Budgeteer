namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimExclusionList
{
    public ClaimsDboClaimExclusionList()
    {
        ClaimExclusionListProductVersions = new HashSet<ClaimsDboClaimExclusionListProductVersion>();
        ClaimExclusions = new HashSet<ClaimsDboClaimExclusion>();
    }

    public int Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public string? Name { get; set; }

    public virtual ICollection<ClaimsDboClaimExclusionListProductVersion> ClaimExclusionListProductVersions { get; set; }
    public virtual ICollection<ClaimsDboClaimExclusion> ClaimExclusions { get; set; }
}
