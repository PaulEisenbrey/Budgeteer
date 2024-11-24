namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimHierarchy
{
    public int Id { get; set; }
    public int ClaimId { get; set; }
    public int ParentClaimId { get; set; }

    public virtual TruDatDboClaim? Claim { get; set; }
    public virtual TruDatDboClaim? ParentClaim { get; set; }
}
