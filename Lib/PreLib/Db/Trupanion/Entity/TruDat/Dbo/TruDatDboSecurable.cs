namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboSecurable
{
    public int Id { get; set; }
    public int CategoryId { get; set; }
    public string? Name { get; set; }
    public string? ApplyAction { get; set; }
    public string? RevokeAction { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }

    public virtual TruDatDboEntityCategory? Category { get; set; }
    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual List<TruDatDboAssociateGroupSecurable> AssociateGroupSecurables { get; set; } = new();
    public virtual List<TruDatDboAssociateSecurable> AssociateSecurables { get; set; } = new();
    public virtual List<TruDatDboSecurableEntityRelation> SecurableEntityRelations { get; set; } = new();
    public virtual List<TruDatDboUserSecurable> UserSecurables { get; set; } = new();
}
