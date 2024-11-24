namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignInstanceValidation
{
    public int Id { get; set; }
    public int CampaignInstanceId { get; set; }
    public int ValidationId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }
    public int? ChangeUserId { get; set; }

    public virtual TruDatPromoCampaignInstance? CampaignInstance { get; set; }
    public virtual TruDatPromoValidation? Validation { get; set; }
}
