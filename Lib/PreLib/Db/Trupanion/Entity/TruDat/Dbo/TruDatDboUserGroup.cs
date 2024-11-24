namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboUserGroup
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public virtual List<TruDatDboUsersGroup> UsersGroups { get; set; } = new();
}
