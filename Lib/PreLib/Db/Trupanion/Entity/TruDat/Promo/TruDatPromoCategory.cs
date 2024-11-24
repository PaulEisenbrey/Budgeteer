namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCategory
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatPromoCampaignInstanceCategory> CampaignInstanceCategories { get; set; } = new();
}
