namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboUsersGroup
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public int GroupId { get; set; }

    public virtual TruDatDboUserGroup? Group { get; set; }
    public virtual TruDatDboUser? User { get; set; }
}
