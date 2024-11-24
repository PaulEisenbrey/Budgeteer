namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimProcess
{
    public int Id { get; set; }
    public int ClaimId { get; set; }
    public int UserId { get; set; }
    public bool Batch { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool Dispute { get; set; }
    public int? AssessmentDataId { get; set; }
    public DateTime? Approved { get; set; }

    public virtual TruDatDboClaim? Claim { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
