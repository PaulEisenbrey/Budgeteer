namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboClaimExclusionListProductVersion
{
    public Guid Id { get; set; }
    public DateTime CreatedOn { get; set; }
    public Guid CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime ModifiedOn { get; set; }
    public Guid ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int? ClaimExclusionListId { get; set; }
    public string? ProductVersionNumber { get; set; }
    public Guid ProductId { get; set; }
    public Guid RegulatoryAgencyId { get; set; }
    public Guid? ProductPlanId { get; set; }

    public virtual ClaimsDboClaimExclusionList? ClaimExclusionList { get; set; }
}
