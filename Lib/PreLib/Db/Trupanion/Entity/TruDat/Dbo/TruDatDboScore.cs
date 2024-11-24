namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboScore
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboEntityScore> EntityScores { get; set; } = new();
}
