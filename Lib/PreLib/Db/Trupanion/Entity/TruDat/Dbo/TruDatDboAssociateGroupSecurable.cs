namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateGroupSecurable
{
    public int Id { get; set; }
    public int AssociateGroupId { get; set; }
    public int SecurableId { get; set; }
    public DateTime Inserted { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboAssociateGroup? AssociateGroup { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboSecurable? Securable { get; set; }
}
