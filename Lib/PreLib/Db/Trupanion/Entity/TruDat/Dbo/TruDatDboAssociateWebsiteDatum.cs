namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateWebsiteDatum
{
    public int Id { get; set; }
    public int AssociateId { get; set; }
    public string? Url { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboAssociate? Associate { get; set; }
}
