namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimPrintHistory
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int ClaimBatchLetterId { get; set; }
    public Guid? BatchId { get; set; }
    public DateTime Inserted { get; set; }

    public virtual TruDatDboClaimBatchLetter? ClaimBatchLetter { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
