namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCounty
{
    public int Id { get; set; }
    public int StateId { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboState? State { get; set; }
}
