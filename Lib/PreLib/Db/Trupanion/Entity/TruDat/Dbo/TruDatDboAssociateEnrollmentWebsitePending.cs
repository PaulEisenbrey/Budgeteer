namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateEnrollmentWebsitePending
{
    public int Id { get; set; }
    public int AssociateEnrollmentPendingId { get; set; }
    public string? Url { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboAssociateEnrollmentPending? AssociateEnrollmentPending { get; set; }
}
