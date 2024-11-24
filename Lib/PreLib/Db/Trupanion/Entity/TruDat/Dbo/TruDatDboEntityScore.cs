namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityScore
{
    public int Id { get; set; }
    public int EntityId { get; set; }
    public int EntityTypeId { get; set; }
    public int ScoreId { get; set; }
    public string? Value { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboEntity? EntityType { get; set; }
    public virtual TruDatDboScore? Score { get; set; }
}
