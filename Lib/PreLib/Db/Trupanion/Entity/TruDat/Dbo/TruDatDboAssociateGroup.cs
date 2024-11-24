namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboAssociateGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual List<TruDatDboAssociateGroupAssociate> AssociateGroupAssociates { get; set; } = new();
    public virtual List<TruDatDboAssociateGroupSecurable> AssociateGroupSecurables { get; set; } = new();
}
