namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceCategory
{
    public int Id { get; set; }
    public int CampaignInstanceId { get; set; }
    public int CategoryId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoCampaignInstance? CampaignInstance { get; set; }
    public virtual TruDatPromoCategory? Category { get; set; }
}
