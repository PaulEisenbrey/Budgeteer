namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboUserSecurable
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int SecurableId { get; set; }
    public DateTime Inserted { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatDboSecurable? Securable { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
