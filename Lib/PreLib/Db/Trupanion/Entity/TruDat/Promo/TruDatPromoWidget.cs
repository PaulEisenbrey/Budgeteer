namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoWidget
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ObjectUrl { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public string? PageSection { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int ChangeUserId { get; set; }
}
