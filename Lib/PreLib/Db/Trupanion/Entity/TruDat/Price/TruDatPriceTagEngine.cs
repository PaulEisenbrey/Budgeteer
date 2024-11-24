namespace Database.Trupanion.Entity.TruDat.Price;

public class TruDatPriceTagEngine
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? TagPrefix { get; set; }
    public int TagSeed { get; set; }
    public int TagNumberLength { get; set; }
    public bool? Active { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
