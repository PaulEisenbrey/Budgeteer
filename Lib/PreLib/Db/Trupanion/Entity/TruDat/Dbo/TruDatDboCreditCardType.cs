namespace Database.Trupanion.Entity.TruDat.Dbo;

public class TruDatDboCreditCardType
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int? NumberLength { get; set; }
    public int? Ccvlength { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
}
