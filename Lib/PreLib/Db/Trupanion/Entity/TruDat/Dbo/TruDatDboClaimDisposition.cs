namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimDisposition
{
    public int ClaimId { get; set; }
    public int AssignedUserId { get; set; }
    public int UserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboUser? AssignedUser { get; set; }
    public virtual TruDatDboClaim? Claim { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
