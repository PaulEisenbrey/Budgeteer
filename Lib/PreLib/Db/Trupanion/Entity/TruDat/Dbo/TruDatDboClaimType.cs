namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboClaimType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboClaim> Claims { get; set; } = new();
}
