namespace Database.Trupanion.Entity.TruDat.Promo;

public class TruDatPromoCampaignRequiredAssociation
{
    public int Id { get; set; }
    public int CampaignId { get; set; }
    public int EntityTypeId { get; set; }
    public DateTime Inserted { get; set; }
    public DateTime Updated { get; set; }

    public virtual TruDatPromoCampaign? Campaign { get; set; }
}
