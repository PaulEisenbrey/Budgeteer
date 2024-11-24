namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboContact
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public bool? Active { get; set; }
    public int SubTypeId { get; set; }

    public virtual List<TruDatDboEntityContact> EntityContacts { get; set; } = new();
}
