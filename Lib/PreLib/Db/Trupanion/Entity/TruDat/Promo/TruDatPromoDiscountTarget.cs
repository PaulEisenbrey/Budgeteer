namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoDiscountTarget
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual List<TruDatPromoCampaignInstanceEffectDiscount> CampaignInstanceEffectDiscounts { get; set; } = new();
}
