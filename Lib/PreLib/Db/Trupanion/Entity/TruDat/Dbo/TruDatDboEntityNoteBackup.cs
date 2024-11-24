namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboEntityNoteBackup
{
    public int Id { get; set; }
    public int EntityTypeId { get; set; }
    public int EntityId { get; set; }
    public int UserId { get; set; }
    public string? Note { get; set; }
    public string? SalesForceId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool InSalesForce { get; set; }
}
