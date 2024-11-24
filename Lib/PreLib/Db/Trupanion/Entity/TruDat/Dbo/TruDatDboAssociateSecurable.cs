namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateSecurable
{
    public int Id { get; set; }
    public int AssociateId { get; set; }
    public int SecurableId { get; set; }
    public DateTime Inserted { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboAssociate? Associate { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboSecurable? Securable { get; set; }
}
