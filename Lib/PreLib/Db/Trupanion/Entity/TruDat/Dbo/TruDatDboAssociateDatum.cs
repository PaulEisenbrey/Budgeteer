namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateDatum
{
    public int Id { get; set; }
    public int AssociateId { get; set; }
    public int AnswerId { get; set; }
    public string? Description { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboEntityTree? Answer { get; set; }
    public virtual TruDatDboAssociate? Associate { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
}
