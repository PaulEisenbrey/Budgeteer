namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCommunicationPreference
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime? Inserted { get; set; }

    public virtual List<TruDatDboOwner> Owners { get; set; } = new();
}
