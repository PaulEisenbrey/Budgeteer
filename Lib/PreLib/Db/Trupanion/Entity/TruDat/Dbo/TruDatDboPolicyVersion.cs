namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyVersion
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime DateEffective { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public string? PolicyPath { get; set; }

    public virtual List<TruDatDboPolicyState> PolicyStates { get; set; } = new();
}
