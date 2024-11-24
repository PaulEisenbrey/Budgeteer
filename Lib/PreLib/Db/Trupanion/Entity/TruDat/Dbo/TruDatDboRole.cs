namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboRole
{
    public int Id { get; set; }
    public string? RoleName { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboUser> Users { get; set; } = new();
}
