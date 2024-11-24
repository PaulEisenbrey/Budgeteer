namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboPolicyAttribute
{
    public int Id { get; set; }
    public int PolicyId { get; set; }
    public string? Attribute { get; set; }
    public string? Value { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatDboPolicy? Policy { get; set; }
}
