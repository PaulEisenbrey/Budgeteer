namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboUserBioCategory
{
    public int Id { get; set; }
    public int? ParentId { get; set; }
    public string? Name { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? SortOrder { get; set; }

    public virtual List<TruDatDboUserBio> UserBios { get; set; } = new();
}
