namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerAssociation
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboEntity? EntityType { get; set; }
    public virtual TruDatDboOwner? Owner { get; set; }
}
