namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboActiveDirectoryUserMapping
{
    public int Id { get; set; }
    public string? Poname { get; set; }
    public string? Adname { get; set; }
    public bool Active { get; set; }
    public Guid ExternalId { get; set; }
}
