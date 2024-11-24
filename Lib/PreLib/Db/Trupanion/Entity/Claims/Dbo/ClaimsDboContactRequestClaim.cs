namespace Database.Trupanion.Entity.Claims.Dbo;

public class ClaimsDboContactRequestClaim
{
    public int Id { get; set; }
    public DateTime? CreatedOn { get; set; }
    public Guid? CreatedBy { get; set; }
    public Guid? CreatedOnBehalfOf { get; set; }
    public DateTime? ModifiedOn { get; set; }
    public Guid? ModifiedBy { get; set; }
    public Guid? ModifiedOnBehalfOf { get; set; }
    public int ContactRequestId { get; set; }
    public int ClaimId { get; set; }

    public virtual ClaimsDboContactRequest? ContactRequest { get; set; }
}
