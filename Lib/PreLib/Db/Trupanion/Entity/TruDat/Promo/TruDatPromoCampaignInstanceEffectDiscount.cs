namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceEffectDiscount
{
    public int Id { get; set; }
    public int CampaignInstanceId { get; set; }
    public int DiscountTypeId { get; set; }
    public int DiscountTargetId { get; set; }
    public double? DiscountValue { get; set; }
    public bool DiscountAll { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoCampaignInstance? CampaignInstance { get; set; }
    public virtual TruDatPromoDiscountTarget? DiscountTarget { get; set; }
    public virtual TruDatPromoDiscountType? DiscountType { get; set; }
}
