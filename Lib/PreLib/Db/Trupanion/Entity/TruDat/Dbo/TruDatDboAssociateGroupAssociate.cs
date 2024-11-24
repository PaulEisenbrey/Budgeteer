namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateGroupAssociate
{
    public int Id { get; set; }
    public int AssociateId { get; set; }
    public int AssociateGroupId { get; set; }
    public DateTime Inserted { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboAssociate? Associate { get; set; }
    public virtual TruDatDboAssociateGroup? AssociateGroup { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
}
