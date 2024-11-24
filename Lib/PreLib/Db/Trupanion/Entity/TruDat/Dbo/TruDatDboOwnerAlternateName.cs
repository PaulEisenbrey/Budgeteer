namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboOwnerAlternateName
{
    public int OwnerId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }
    public Guid UniqueId { get; set; }
}
