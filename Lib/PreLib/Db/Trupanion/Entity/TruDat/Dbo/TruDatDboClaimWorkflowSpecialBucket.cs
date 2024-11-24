namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimWorkflowSpecialBucket
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
