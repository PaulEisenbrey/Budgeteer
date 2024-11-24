namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboActiveDirectoryUser
{
    public int Id { get; set; }
    public string? UserName { get; set; }

    public virtual TruDatDboUser? IdNavigation { get; set; }
}
