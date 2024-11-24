namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityLock
{
    public int Id { get; set; }
    public int? EntityTypeId { get; set; }
    public int? EntityId { get; set; }
    public int? SessionId { get; set; }
    public DateTime? Inserted { get; set; }

    public virtual TruDatDboSession? Session { get; set; }
}
