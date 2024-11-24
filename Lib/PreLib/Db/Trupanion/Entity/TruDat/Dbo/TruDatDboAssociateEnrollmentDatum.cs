namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateEnrollmentDatum
{
    public int Id { get; set; }
    public string? SessionId { get; set; }
    public int PendingAssociateId { get; set; }
    public int? AnswerId { get; set; }
    public string? Description { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboEntityTree? Answer { get; set; }
    public virtual TruDatDboAssociateEnrollmentPending? PendingAssociate { get; set; }
}
