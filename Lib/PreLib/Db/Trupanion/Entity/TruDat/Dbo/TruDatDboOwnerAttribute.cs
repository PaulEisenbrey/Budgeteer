namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerAttribute
{
    public int Id { get; set; }
    public int OwnerId { get; set; }
    public string? Attribute { get; set; }
    public string? Value { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboUser? ChangeUser { get; set; }
    public virtual TruDatDboOwner? Owner { get; set; }
}
