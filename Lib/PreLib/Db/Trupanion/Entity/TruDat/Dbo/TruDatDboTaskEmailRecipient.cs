namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboTaskEmailRecipient
{
    public int TaskId { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime? Executed { get; set; }
    public string? Error { get; set; }

    public virtual TruDatDboEntity? EntityType { get; set; }
    public virtual TruDatDboTask? Task { get; set; }
}
