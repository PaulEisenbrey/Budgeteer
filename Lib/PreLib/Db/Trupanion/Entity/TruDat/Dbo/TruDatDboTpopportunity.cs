namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboTpopportunity
{
    public int Id { get; set; }
    public string? Market { get; set; }
    public string? Description { get; set; }
    public string? Owner { get; set; }
    public string? Email { get; set; }
    public bool Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? SortOrder { get; set; }
}
