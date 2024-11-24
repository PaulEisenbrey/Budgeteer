namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityCategory
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboClaimExclusion> ClaimExclusions { get; set; } = new();
    public virtual List<TruDatDboEntityTree> EntityTrees { get; set; } = new();
    public virtual List<TruDatDboPartner> Partners { get; set; } = new();
    public virtual List<TruDatDboSecurable> Securables { get; set; } = new();
}
