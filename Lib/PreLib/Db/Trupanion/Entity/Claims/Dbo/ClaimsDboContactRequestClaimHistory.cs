namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboContactRequestClaimHistory
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ContactRequestHistoryId { get; set; }
    public int ClaimId { get; set; }

    public virtual ClaimsDboContactRequestHistory? ContactRequestHistory { get; set; }
}
