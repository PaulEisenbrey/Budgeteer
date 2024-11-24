namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimWorkflowViewStatus
{
    public int Id { get; set; }
    public int ClaimId { get; set; }
    public int StatusId { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboClaim? Claim { get; set; }
    public virtual TruDatDboStatus? Status { get; set; }
}
