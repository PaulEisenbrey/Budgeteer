namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboTaskType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatDboTask> Tasks { get; set; } = new();
}
